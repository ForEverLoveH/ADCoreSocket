using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore.ADCoreCommon 
{
    public  class Req_Register
    {
        public  string accountName { get; set; }// 账号名字
        public  string  password { get; set; }// 密码
        public string phoneNum { get; set; }    //手机号
                                                
    }
}
