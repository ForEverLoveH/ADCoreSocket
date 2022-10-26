using ADCore.ADCoreCommon;
using ADCoreClient.ADCoreClientSys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreClient
{
    public class ServerSettingSys
    {
        public static ServerSettingSys Instance;

        public static ServerSetting ServerSetting;

        public  void Awake()
        {
            Instance = this;
        }
        public void Init()
        {
            StartGame();
        }

        private void StartGame(bool  IsActive=true)
        {
            if (IsActive)
            {
                if  (ServerSetting == null)
                {
                   ServerSetting = new ServerSetting();
                    ServerSetting.Show();
                }
                else
                {
                    if (ServerSetting.IsDisposed)
                    {
                       ServerSetting = new ServerSetting();
                        ServerSetting.Show();
                    }
                    else
                    {
                        ServerSetting  .Activate();
                    }
                }
            }
            else
            {
                if (ServerSetting != null)
                {
                    ServerSetting .Dispose();
                }
            }
        }
        /// <summary>
        ///  处理从服务器发来的数据
        /// </summary>
        /// <param name="msg"></param>
        public  void HandelRecieveMessage(string msg)
        {
            var ls = JsonConvert.DeserializeObject<ServerData>(msg);
            switch (ls.ServerDataType)
            {
                case ServerDataType.Login:
                    LoginSys.Instance.Rsp_Login(ls);
                    break;
                case ServerDataType.Register:
                    RegisterSys.Instance.Rsp_Register(ls);
                    break;
                       
            }

        }
        /// <summary>
        ///  发送数据到服务器
        /// </summary>
        /// <param name="clientData"></param>
        public void SendMessageToServer(ClientData clientData)
        {
            var sl = JsonConvert.SerializeObject(clientData);
            ServerSetting.SendDataToServer(sl);
        }
        /// <summary>
        ///  检测服务器连接状态
        /// </summary>
        /// <returns></returns>
        public   bool IsCheckConnect()
        {
            return ServerSetting.CheckServerConnectionState();
        }
    }
}
