

using ADCore.ADCoreCommon;
using ADCore.ADCoreServer.MessageManager;
using Newtonsoft.Json;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCore.ADCoreSystem.ADCoreSys
{
    public class ADCoreServerSys
    {
        public static ADCoreServerSys Instance;
        static ADCoreServerWindow ADCoreServerWindow;

        public  void Awake()
        {
            Instance = this;    
        }
        public  void Init()
        {
            StartGame();
        }

        
        private void StartGame(bool isActive = true)
        {
            if (isActive)
            {
                if (ADCoreServerWindow == null)
                {
                    Application.Run(ADCoreServerWindow = new ADCoreServerWindow());
                }
                else
                {
                    if (ADCoreServerWindow.IsDisposed)
                    {
                        Application.Run(ADCoreServerWindow = new ADCoreServerWindow());
                    }
                    else
                    {
                        ADCoreServerWindow.Activate();
                    }
                }
            }
            else
            {
                if (ADCoreServerWindow != null)
                {
                    ADCoreServerWindow.Dispose();
                }
            }
        }
         
        
        /// <summary>
        ///往客户端发送消息
        /// </summary>
        /// <param name="strMsg"></param>
        public  void  SendMsgToClient(string strMsg)
        {
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(strMsg);
            ADCoreServerWindow.ServerSendMsgToClient(arrSendMsg);
        }
        /// <summary>
        ///  处理来自客户端的消息
        /// </summary>
        /// <param name="str"></param>
        public  void HandelMsgFromClient(string str)
        {
            ClientData data = JsonConvert.DeserializeObject<ClientData>(str);
            MsgDataManager.Instance.AddClientDataMsgToQueue(data); 
        }
    }
}
