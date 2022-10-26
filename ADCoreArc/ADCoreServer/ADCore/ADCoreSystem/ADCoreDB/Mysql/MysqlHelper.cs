using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ADCore.ADCoreSystem.ADCoreDB 
{
    public class MysqlHelper:IDisposable
    {
        MySqlConnection sqlConnection;
        String server;
        string dataBase;
        string userID;
        String password;
        public MysqlHelper(string _server,string database,string _userID,string _password)
        {
            server = _server;
            dataBase = database;
            userID = _userID;
            password = _password;

        }

         
        /// <summary>
        /// 
        /// </summary>
        public  void OpenMysqlConnection()
        {
            string con = $"server={server};database={dataBase};userID={userID};password = {password}";
            sqlConnection = new MySqlConnection(con);
            try
            {
                sqlConnection.Open();
            }
            catch(Exception ex)
            {
               Console.WriteLine ("数据库打开异常"+ex.Message);
                return;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public  void EnSureMysqlConnection()
        {
            if(sqlConnection == null)
            {
                Console.Write("没有数据库的连接");
            }
            if(sqlConnection .State  != System.Data.ConnectionState.Open)
            {
                OpenMysqlConnection();
            }
        }
        public bool VerifyLoginData(string userName, string password, string loginTableName)
        {
            
            try
            {
                EnSureMysqlConnection();
                IsExitLoginTable(loginTableName);
                if (Regex.IsMatch(userName, @"^(1)\d{10}$")) // 手机号
                {
                    string sql = $"select * from {loginTableName}  where TelPhone ={userName} and Password= {password }";
                    MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                    var  result = cmd. ExecuteNonQuery();
                    Console.WriteLine(result); 
                    if(result == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return  true;
                    }


                }
                else
                {
                    string sql = $"select * from {loginTableName}  where Account =@param1 and Password= @param2";
                    MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                    var result = cmd.ExecuteNonQuery();
                    Console.WriteLine(result);
                    if (result == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
            finally
            {
                Dispose();

            }
            return false;

        }

        private void IsExitLoginTable(string loginTableName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console .WriteLine(ex.Message);
            }
        }

        private  int   CreateLoginTable(string tableName)
        {
            EnSureMysqlConnection();
            try
            {
                string sql = $"CREATE TABLE{tableName}(ID int ,Account varchar(255),TekPhone varchar(255) ,password  varchar(255)";
                MySqlCommand cmd = new MySqlCommand(sql,sqlConnection );
                return cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                Console.WriteLine("创建数据表异常！！");
                return -1;
            }
        }

        public void Dispose()
        {
             sqlConnection?.Close();
             sqlConnection?.Dispose();
        }
    }
}
