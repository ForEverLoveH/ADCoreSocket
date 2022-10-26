using ADCore.ADCoreSystem.ADCoreSys;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCore.ADCoreSystem
{
    public partial class ADCoreServerWindow : Form
    {
        ADCoreServerSys ADCoreServerSys = new ADCoreServerSys();
        public ADCoreServerWindow()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void ADCoreServerWindow_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.PortInput.Text = "9966";
        }
        Thread threadWatch = null;// 负责监听客户端的线程
        Socket socketWatch = null;// 负责监听客户端的套接字

        private void GetIPButton_Click(object sender, EventArgs e)
        {
            IPAddress localIPAddress = GetLocalIPv4Address();
            this.IPAddressInput.Text = localIPAddress.ToString();
            GetIPButton.Enabled = false;
        }

        private IPAddress GetLocalIPv4Address()
        {
            IPAddress localIP = null;
            IPAddress[] IPList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in IPList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip;
                }
                else
                {
                    continue;
                }
            }
            return localIP;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                uiButton1.Enabled = false;
                //创建服务器端的Socket
                Socket tcpserivce = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //将服务器端的Socket绑定Ip和端口号
                IPAddress ip = IPAddress.Parse(IPAddressInput.Text);//将ip转换为对应的格式
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(PortInput.Text));//将IP和端口号组成point类
                tcpserivce.Bind(point);//服务器绑定
                ShowMsg( RecieveMsg    ,"监听成功");
                //允许连接总数
                tcpserivce.Listen(10);
                Thread th = new Thread(Listen);//开启线程监听客户端的连接情况
                th.IsBackground = true;
                th.Start(tcpserivce);


            }
            catch (Exception ex)
            {
                ShowMsg(RecieveMsg, "服务器启动失败！！");
                uiButton1.Enabled = true;
            }
        }

        private void Listen(object  t)
        {  //获取服务器端的Socket
            Socket tcpserivce = t as Socket;
            while (true)//循环，保证一直可以接收客户端的连接
            {
                //接收到客户端的连接，创建新的socket与之通信
                socketConnection = tcpserivce.Accept();
                //将远程连接的客户端的IP地址和Socket存入集合中
                dicSocket.Add(socketConnection.RemoteEndPoint.ToString(), socketConnection);
                //将远程连接的客户端的IP地址和端口号存储下拉框中
                ClientDrop.Items.Add(socketConnection.RemoteEndPoint.ToString());
                ClientDrop.SelectedIndex = 0;
                //显示连接成功
                ShowMsg( RecieveMsg,socketConnection.RemoteEndPoint.ToString() + "连接成功");
                //开启线程接收客户端的消息
                Thread th1 = new Thread(ReciveDataFromClient);
                th1.IsBackground = true;
                th1.Start(socketConnection);
            }

 
        }

        private void ReciveDataFromClient(object  o)
        { //获取到客户端的socket
            Socket socketSend = o as Socket;
            while (true)
            {
                //判断该客户端是否断开连接
                if (socketSend.Poll(10, SelectMode.SelectRead))
                {
                    break;
                }
                byte[] buffer = new byte[1024 * 1024 * 2];
                //实际接受到的有效字节数
                int r = socketSend.Receive(buffer);
                //将byte数组转换为string类型
                string str = Encoding.UTF8.GetString(buffer, 0, r);
                
                ShowMsg(RecieveMsg, "收到" + socketSend.RemoteEndPoint + str);
                ADCoreServerSys.HandelMsgFromClient(str);
            }
        }

        private void ShowMsg(UIRichTextBox  msg, string v)
        {
             msg.AppendText (v);    
        }

        // 创建一个负责和客户端通信的套接字
        Socket socketConnection = null;
        //将远程连接的客户端的IP地址和Socket存入集合中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        ///监听客户端发来的请求


        /// <summary>
        /// 接收来自客户端的消息
        /// </summary>
        /// <param name="msg"></param>

        public  void ServerSendMsgToClient( byte[]  msg)
        {
             
            byte[] buffer = msg;
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            //将泛型集合转换为数组
            byte[] newBuffer = list.ToArray();
            if (ClientDrop.SelectedItem == null)
            {
                ShowMsg(SendMessage, "没有选择需要发送到的客户端！！");
                return;
            }
            else
            {
                string ip = ClientDrop.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //每100毫秒检测客户端是否断开连接
            
                //创建字典存放断开的客户端
                Dictionary<string, Socket> delSocket = new Dictionary<string, Socket>();
                //遍历检查哪些客户端断开了
                foreach (var item in dicSocket)
                {
                    if (item.Value.Poll(10, SelectMode.SelectRead))
                    {
                        delSocket.Add(item.Key, item.Value);
                    }
                }
                //删除掉断开的客户端
                foreach (var item in delSocket)
                {
                    dicSocket.Remove(item.Key);
                   ClientDrop.Items.Remove(item.Key);
                }
            

         }
    }
}
