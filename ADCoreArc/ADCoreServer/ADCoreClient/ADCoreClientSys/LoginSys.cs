
using ADCore.ADCoreCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreClient.ADCoreClientSys
{
    internal class LoginSys
    {
        public static LoginSys Instance;
        public  LoginWindow LoginWindow;
        RegisterSys RegisterSys = new RegisterSys();
        ServerSettingSys ServerSettingSys= new ServerSettingSys();   


        public  void Awake()
        {
            Instance = this;    
        }

        public  void Init()
        {
            StartGame();
        }

        public  void GoToRegister()
        {
            RegisterSys.Init();
        }

        private void StartGame(bool  IsActive =true )
        {
            if (IsActive)
            {
                if (LoginWindow == null)
                {
                    Application.Run(LoginWindow = new LoginWindow());
                    LoginWindow.Show(); 
                }
                else
                {
                    if (LoginWindow.IsDisposed)
                    {
                        Application.Run(LoginWindow = new LoginWindow());
                    }
                    else
                    {
                        LoginWindow.Activate();
                    }
                }
            }
            else
            {
                if (LoginWindow != null)
                {
                    LoginWindow.Dispose();
                }
            }
        }

        public  void LoginGame(string acc, string pass)
        {
            if (string.IsNullOrEmpty(acc) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("请将信息填写完整！！");
                return;
            }
            else
            {
               if(ServerSettingSys.IsCheckConnect())
               {
                    ClientData clientData = new ClientData()
                    {
                        dataType = DataType.Login,
                        req_DataMsg = new Req_DataMsg()
                        {
                            req_Login = new Req_Login()
                            {
                                account = acc,
                                password = pass,
                            }
                        }
                    };
                    ServerSettingSys.SendMessageToServer(clientData);
               }
                else
                {
                    MessageBox.Show("请先连接服务器！！");
                    return;
                }
            }
        }

        public void Rsp_Login(ServerData serverData)
        {
            if(serverData.errorType==ErrorType.AccountOrPasswordEmpty)
            {
                MessageBox.Show("登录信息为空，请重新输入！！");
                return;
            }
            else
            {
                ServerDataMsg serverDataMsg = new ServerDataMsg()
                {
                    LoginData = new LoginData()
                    {
                        playerData = serverData.serverDataMsg.LoginData.playerData
                    }
                };
                if(serverDataMsg.LoginData.playerData.IsSucessLogin == 0)
                {
                    MessageBox.Show("登录成功！！");
                }
                else
                {
                    MessageBox.Show("登录账号或者密码错误，请重新输入！！");
                    return;
                }
            }
        }

        public  void ToServerSetting()
        {
             ServerSettingSys.Init();
        }
    }
}
