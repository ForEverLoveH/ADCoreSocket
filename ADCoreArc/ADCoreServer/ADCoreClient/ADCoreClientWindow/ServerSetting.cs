using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreClient
{
    public partial class ServerSetting : Form
    {
        public ServerSetting()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        ServerSettingSys ServerSettingSys = new ServerSettingSys();  
        // 创建一个TCP客户端套接字
        Socket Socket_TCP = null;
         

        static  bool  IsConnect = false ;
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (ConnectBtn.Text == "连接")
            {
                //定义一个套接字用于监听客户端发来的消息，包含三个参数（ipv4寻址协议，流式连接，tcp协议）
                //创建客户端的socket，绑定服务器端ip和端口，准备连接
                Socket_TCP = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(IPAddressInput.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(PortInput.Text));
                try
                {
                    Socket_TCP.Connect(point);//连接服务器
                    ShowMsg( RecieveMsgText,"连接成功");
                    ConnectBtn.Text = "关闭";
                    IsConnect = true;
                }
                catch (Exception ex)
                {
                     ShowMsg(MessageSendText,ex.Message);
                    return;

                }
                //开启一个新的线程不停的接收服务端发来的消息
                Thread th = new Thread(ReciveDataFromServer);
                th.IsBackground = true;
                th.Start();

            }
            else if (ConnectBtn.Text == "关闭")
            {
                ConnectBtn.Text = "连接";
                string str = "断开连接";
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                try
                {
                    Socket_TCP.Send(buffer);
                    //断开客户端
                    Socket_TCP.Shutdown(SocketShutdown.Both);
                    Socket_TCP.Close();
                    IsConnect = false;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("断开异常" + ex.Message);
                }

             }

        }
        /// <summary>
        ///  从服务器接收数据
        /// </summary>
        private void ReciveDataFromServer()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = Socket_TCP.Receive(buffer);
                    //实际接收到的有效字节数
                    if (r == 0)
                    {
                        break;
                    }
                    //表示接收的是文字消息
                    if (buffer[0] == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);  
                        ShowMsg(RecieveMsgText, Socket_TCP.RemoteEndPoint + ":" + s);
                        ServerSettingSys.HandelRecieveMessage(s);
                    }
                    else if (buffer[0] == 1)//接收的是文件
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Title = "请选择要保存的文件";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("接收信息异常！！" + ex.Message);
                }
            }
        }
        /// <summary>
        ///  发送消息到服务器端
        /// </summary>
        public void SendDataToServer(string msg)
        {
            ShowMsg(MessageSendText, msg);
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            Socket_TCP.Send(buffer);
        }
         
        public static  bool CheckServerConnectionState()
        {
            return IsConnect;
        }
    

        private void ShowMsg(UIRichTextBox recieveMsgText, string v)
        {
             recieveMsgText.Text = v;
        }

        
    }
}
