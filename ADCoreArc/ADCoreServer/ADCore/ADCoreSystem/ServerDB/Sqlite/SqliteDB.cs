
using ADCore.ADCoreCommon;
 
using ADCore.ADCoreServer.MessageManager;
using ADCore.ADCoreSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCore.ADCoreServer

{
    public  class SqliteDB
    {
        public static SqliteDB Instance;
        MsgDataManager msgDataManager = new MsgDataManager();

        public  void Awake()
        {
            Instance = this;    
        }
        private string DBpath = Application.StartupPath + GameConst.DBPath;


        /// <summary>
        ///  初始化
        /// </summary>
        public void Init()
        {
            if (!System.IO.Directory.Exists(DBpath))
            {
                System.IO.Directory.CreateDirectory(DBpath);
                Console.WriteLine($"数据库文件夹已丢失，已重新创建dataBase文件夹的路径为{DBpath}");
            }
            string dbPath = Application.StartupPath + GameConst.UserDBPath;
            if (File.Exists(dbPath))
            {
                Console.WriteLine("SaveData文件存在");
            }
            else
            {
                SqlDbCommand sql = new SqlDbCommand(dbPath);
                sql.Dispose();
            }
            string UserdbPath = Application.StartupPath + GameConst.SaveDBPath;
            if (File.Exists(UserdbPath))
            {
                Console.WriteLine($" {UserdbPath}文件存在");
            }
            else
            {
                Console.WriteLine($" {UserdbPath}文件不存在");
                SqlDbCommand sql = new SqlDbCommand(UserdbPath);
                sql.Dispose();
            }
           /* string FacedbPath = Application.StartupPath + GameConst.FaceDBPath;
            if (File.Exists(FacedbPath))
            {
                Console.WriteLine($" {FacedbPath}文件存在");
            }
            else
            {
                Console.WriteLine($" {FacedbPath}文件不存在");
                SqlDbCommand sql = new SqlDbCommand(FacedbPath);
                sql.Dispose();

            }*/
            Export_database(dbPath, "Init");
        }
       

        private void Export_database(string ExportPath, string Cmd, bool IsExport = GameConst.IsExport)
        {
            if (IsExport)
            {
                try
                {
                    var dirName = new FileInfo(ExportPath).Directory.FullName;
                    dirName += "/ExportDatabase/";
                    if (!Directory.Exists(dirName))
                    {
                        Directory.CreateDirectory(dirName);
                    }
                    File.Copy(ExportPath, dirName + $"{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss-ms")}_{Cmd}_backups.db", true);//拷贝文件 可以覆盖
                    if (File.Exists(dirName + $"{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss-ms")}_{Cmd}_backups.db"))
                    {
                        Console.WriteLine("数据库文件备份成功,文件路径： " + dirName + $"{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss-ms")}_{Cmd}_backups.db");
                    }

                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"备份数据库异常：{e.Message}");
                }
            }
        }
        /// <summary>
        ///  登录请求
        /// </summary>
        /// <param name="req_Login"></param>
        public  void Req_Login(Req_Login req_Login)
        {
            ServerData serverData = new ServerData()
            {
                ServerDataType = ServerDataType.Login,
            };
            if(String.IsNullOrEmpty (req_Login.account )||string.IsNullOrEmpty (req_Login .password))
            {
                serverData.errorType = ErrorType.AccountOrPasswordEmpty;
            }
            else if(!String.IsNullOrEmpty(req_Login.account)&& !string.IsNullOrEmpty(req_Login.password))
            {
                serverData.errorType = ErrorType.None;
                LoginSql.Instance.IsExtenceAdminData(GameConst.DBLoginName);
                var L = LoginSql.Instance.JudgeIsTelPhone(req_Login.account);
                if (LoginSql.Instance.IsLogin(GameConst.DBLoginName, req_Login.account, req_Login.password, L))
                {
                    //登录成功
                    PlayerData playerData = new PlayerData() {  IsSucessLogin = 0 };
                    serverData.serverDataMsg = new ServerDataMsg()
                    {
                        LoginData = new LoginData()
                        {
                            playerData = playerData ,
                        }
                    };
                }
                else
                {
                    PlayerData playerData = new PlayerData() { IsSucessLogin = -1 };
                    serverData.serverDataMsg = new ServerDataMsg()
                    {
                        LoginData = new LoginData()
                        {
                            playerData = playerData,
                        }
                    };
                }
                MsgDataManager.Instance.AddServerDataToQueue(serverData);
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="req_Login"></param>
        public void Req_Register( Req_Register req_Register)
        {
            ServerData serverData = new ServerData()
            {
                ServerDataType = ServerDataType.Register,
            };
            if (string.IsNullOrEmpty(req_Register.accountName) || string.IsNullOrEmpty(req_Register.password) || string.IsNullOrEmpty(req_Register.phoneNum))
            {
                serverData.errorType = ErrorType.RegisterDataIsEmpty;
            }
            else
            {
                serverData.errorType = ErrorType.None;
                Admin admin = new Admin
                {
                    User = req_Register.accountName,
                    Password = req_Register.password,
                    Phone = req_Register.phoneNum,
                };
                RegisterSql.Instance.IsExtenceAdminData(GameConst.DBLoginName);
                  bool  l=   RegisterSql.Instance.RegisterUser(admin, GameConst.DBLoginName);
                 serverData.serverDataMsg = new ServerDataMsg()
                 {
                     registerData = new RegisterData()
                     {
                         IsRegister = l,
                     }
                 };
                 MsgDataManager.Instance.AddServerDataToQueue(serverData);
                  
            }
        }


    }
}
