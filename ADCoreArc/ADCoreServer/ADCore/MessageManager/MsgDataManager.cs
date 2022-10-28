using ADCore.ADCoreCommon;
using ADCore.ADCoreSystem.ADCoreSys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore. ADCoreServer.MessageManager
{
    public class MsgDataManager
    {
        public static MsgDataManager Instance;
        public  void Awake()
        {
            Instance = this;   
        }
        Queue<ClientData> dataMessage = new Queue<ClientData>();  

        public  void AddClientDataMsgToQueue(ClientData msg)
        {
            lock (dataMessage)
            {
                dataMessage.Enqueue(msg);
            }
            Updata();
        }
        private void Updata()
        {
            while (dataMessage.Count > 0)
            {
                lock (dataMessage)
                {
                    ClientData msg = dataMessage.Dequeue();
                    HandelMsg(msg);
                }
            }
        }
        private void HandelMsg(ClientData msg)
        {
            switch (msg.dataType)
            {
                case DataType.Login:
                    SqliteDB.Instance .Req_Login(msg.req_DataMsg.req_Login);
                    break;
                case DataType.Register:
                    SqliteDB.Instance.Req_Register(msg.req_DataMsg.req_Register);
                    break;
            }
        }
        Queue<ServerData> serverDatas = new Queue<ServerData>();
        public   void  AddServerDataToQueue(ServerData serverData)
        {
            lock (serverDatas)
            {
                serverDatas.Enqueue(serverData);    
            }
            UpdataServerData(serverData);
        }

        private void UpdataServerData( ServerData serverData)
        {
            if (serverDatas.Count > 0)
            {
                lock (serverDatas)
                {
                   HandelServer(serverDatas.Dequeue()); 
                }
            }
        }

        private void HandelServer(ServerData serverData)
        {
            string msgdata = JsonConvert.SerializeObject(serverData);
            ADCoreServerSys.Instance.SendMsgToClient(msgdata);
        }
    }
}
