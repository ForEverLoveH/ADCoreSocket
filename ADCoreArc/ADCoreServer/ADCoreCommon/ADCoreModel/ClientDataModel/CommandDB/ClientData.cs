using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore.ADCoreCommon 
{ 
    // 客户端发给服务器端的数据模型 
    public  class ClientData
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        public DataType dataType { get; set; }
        /// <summary>
        /// 请求信息
        /// </summary>
        public Req_DataMsg req_DataMsg { get; set; }
    }
}
