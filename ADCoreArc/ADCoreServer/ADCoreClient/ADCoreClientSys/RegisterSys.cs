using ADCore.ADCoreCommon;
using ADCoreClient.ADCoreClientWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreClient.ADCoreClientSys
{
    public  class RegisterSys
    {
        public static RegisterSys Instance;
        public static RegisterWindow RegisterWindow;
        ServerSettingSys ServerSettingSys ;
        LoginSys LoginSys = new LoginSys();

        public  void Awake()
        {
            Instance = this;
        }
        public  void Init()
        {
            StartGameRoot();
        }

        private void StartGameRoot(bool IsActive= true )
        {
            if (IsActive)
            {
                if (RegisterWindow == null)
                {
                    RegisterWindow = new RegisterWindow();
                    RegisterWindow.Show();
                }
                else
                {
                    if (RegisterWindow.IsDisposed)
                    {
                        RegisterWindow = new RegisterWindow();
                        RegisterWindow .Show ();
                    }
                    else
                    {
                        RegisterWindow.Activate();
                    }
                }
            }
            else
            {
                if (RegisterWindow != null)
                {
                    RegisterWindow.Dispose();
                }
            }
        }

        public  void Req_register(string acc, string tel, string pass)
        {
            if(String.IsNullOrEmpty(acc )||String .IsNullOrEmpty(tel)||String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("请将信息填写完整！！");
                return;
            }
            else
            {
                ServerSettingSys = new ServerSettingSys();
                if (ServerSettingSys.IsCheckConnect())
                {
                    ClientData clientData = new ClientData()
                    {
                        dataType = DataType.Register ,
                        req_DataMsg = new Req_DataMsg()
                        {
                            req_Register = new Req_Register ()
                            {
                                accountName =acc,
                                password = pass,
                                phoneNum = tel,
                            }
                        }
                    };
                    ServerSettingSys.SendMessageToServer(clientData);
                }
                else
                {
                    MessageBox.Show("请先连接服务器");
                    return;
                }
            }
        }

        public  void Rsp_Register(ServerData serverData)
        {
            if (serverData.serverDataMsg.registerData.IsRegister)
            {
                DialogResult dialogResult = MessageBox.Show("注册成功，是否前往登录?", "恭喜您！！", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes) 
                {
                    RegisterWindow.ClearAllData();
                    RegisterWindow.SetWindowState();
                    LoginSys.Init();
                }
                RegisterWindow.SetWindowState();
            }
            else
            {
                MessageBox.Show("注册失败，请检测是否输入正确");
                return;
            }
        }
    }
}
