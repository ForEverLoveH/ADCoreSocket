using ADCore.ADCoreCommon;
 
using ADCore.ADCoreServer;
using ADCore.ADCoreServer.MessageManager;
using ADCore.ADCoreSystem;
using ADCore.ADCoreSystem.ADCoreDB;
using ADCore.ADCoreSystem.ADCoreSys;
 
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore
{
    public  class GameRootSvc
    {
        static ADCoreServerSys ADCoreServerSys = new ADCoreServerSys();
        

        static   LoginSql  LoginSql = new LoginSql();
        static RegisterSql RegisterSql = new RegisterSql();
        static  SqliteDB SqliteDB = new SqliteDB();
        static MsgDataManager MsgDataManager = new MsgDataManager();

        public  static void  StartGameRoot()
        {
            Awake();
            Start();
        }

        private static void Start()
        {

            SqliteDB.Init();
            ADCoreServerSys.Init();
        }

        private static void Awake()
        {
            ADCoreServerSys.Awake();
           
            SqliteDB.Awake();
            
            LoginSql .Awake();
            RegisterSql.Awake();
            MsgDataManager.Awake();

        }
    }
}
