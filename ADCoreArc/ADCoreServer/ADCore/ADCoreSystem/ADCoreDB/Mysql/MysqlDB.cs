
using ADCore.ADCoreCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore.ADCoreSystem.ADCoreDB
{
    public  class MysqlDB
    {
        public static MysqlDB Instance;

        public void Awake()
        {
            Instance = this;    
        }

        public  void Req_Login(Req_Login req_Login)
        {
            
        }
    }
}
