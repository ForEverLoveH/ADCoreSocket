
using ADCore.ADCoreCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCore.ADCoreSystem
{
    public class LoginSql
    {
        public static LoginSql Instance;
        public void Awake()
        {
            Instance = new LoginSql();
        }



        public void IsExtenceAdminData(string name)
        {
            string path = Application.StartupPath + GameConst.UserDBPath;
            SqlDbCommand sql = new SqlDbCommand(path);
            int isExistenceAdminData = sql.IsCreateTable(name);
            if (isExistenceAdminData == 0)
            {
                Console.WriteLine($"数据库表{name}不存在");
                sql.CreateTable<AdminModel>(name);
                //初始化Admin表
                Admin admin = new Admin() { User = GameConst.InitAdminAcct, Password = GameConst.InitAdminPass ,Phone = GameConst.InitPhone};
                List<Admin> admins = new List<Admin>();
                admins.Add(admin);
                sql.Insert<Admin>(admins, name);
            }
            if (isExistenceAdminData == 1)
            {
                Console.WriteLine($"数据库表{name}存在");
            }
            sql.Dispose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="acc"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsLogin(string Name, string acc, string password, bool IsPhone)
        {
            try
            {
                string path = Application.StartupPath + GameConst.UserDBPath;
                SqlDbCommand sql = new SqlDbCommand(path);
                List<Admin> UserAdmin = new List<Admin>();
                if (IsPhone != true)
                {
                    UserAdmin = sql.SelectBySql<Admin>(Name, $"User = '{acc}' and Password = '{password}'"); 
                }
                else
                {
                    UserAdmin = sql.SelectBySql<Admin>(Name, $" Phone  = '{acc}' and Password = '{password}'");
                }
                if (UserAdmin.Count == 1)
                {
                    sql.Dispose();
                    return true;
                }
                else if (UserAdmin.Count > 1)
                {
                    sql.Dispose();
                    Console.WriteLine($"数据库已被非法修改");
                    return false;
                }
                sql.Dispose();
                return false;
            }

            catch (Exception e)
            {
                Console.WriteLine("登录异常" + e.Message);
                return false;
            }

        }

        public  bool JudgeIsTelPhone(string account)
        {
            if (string.IsNullOrEmpty(account))
                return false;
            return Regex.IsMatch(account, @"^(1)\d{10}$");
        }
    }
}
