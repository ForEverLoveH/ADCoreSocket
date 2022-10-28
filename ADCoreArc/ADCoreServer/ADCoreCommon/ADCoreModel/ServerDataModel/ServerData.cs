
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore. ADCoreCommon
{ 
    /// <summary>
    ///  服务器端发给客户端的数据模型
    /// </summary>
    public  class ServerData
    {
        public ErrorType errorType;
        public ServerDataType ServerDataType;
        public ServerDataMsg serverDataMsg;
    }
}
