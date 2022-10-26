using ADCore.ADCoreCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCore.ADCoreSystem 
{
    public class RegisterSql
    {
        public static RegisterSql Instance;

        public void Awake()
        {
            Instance = this;
        }
        public int   IsExtenceAdminData(string name)
        {
            string PATH = Application.StartupPath + GameConst.UserDBPath;
            SqlDbCommand sql = new SqlDbCommand(PATH);
            return  sql.IsCreateTable(name);
        }

        public   bool   RegisterUser(Admin admin ,string name )
        {
            string PATH = Application.StartupPath + GameConst.UserDBPath;
            SqlDbCommand sql = new SqlDbCommand(PATH);
            IsExtenceAdminData(name);
            List<Admin> admins = new List<Admin>();
            admins.Add(admin);
            var l = sql.Insert<Admin>(admins,name );
            if (l == 0  ){
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
