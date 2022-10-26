using ADCoreClient.ADCoreClientSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoreClient
{
    
    public class StartGameRoot
    {
        static LoginSys loginSys = new LoginSys();
        static  ServerSettingSys ServerSettingSys = new ServerSettingSys();
        static  RegisterSys RegisterSys = new RegisterSys();

        public void StartGame()
        {
            Awake();
            Start();

        }

        private void Start()
        {
            
            loginSys.Init();
        }

        private void Awake()
        {
             loginSys.Awake();
            ServerSettingSys.Awake();  
            RegisterSys.Awake();
        }
    }
}
