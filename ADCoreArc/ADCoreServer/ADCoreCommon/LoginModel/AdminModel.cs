 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ADCore .ADCoreCommon
{
    public  class AdminModel
    {
        
        private string _user;
        private string _Phone;
        private string _password;
         
        [ModeHelp(true, "User", "string", false, false)]
        public string User { get { return _user; } set { _user = value; } }
        [ModeHelp(true ,"Phone","string",false,false  )]
        public  string Phone { get => _Phone;set=> _Phone = value; }

        [ModeHelp(true, "Password", "string", false, false)]
        public string Password { get { return _password; } set { _password = value; } }
    }

}
