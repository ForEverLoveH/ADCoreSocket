using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore.ADCoreCommon { 
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
