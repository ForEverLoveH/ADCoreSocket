using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCore. ADCoreCommon
{
    public class SqliteConnection:IDisposable
    {
        public SQLiteConnection connection;
        public SqliteConnection(string Path)
        {
            if (!File.Exists(Path))
            {
                CreateDataSqlite(Path);
            }
            ConnectionDBSqlite(Path);
        }

        private bool  ConnectionDBSqlite(string path)
        {
            try
            {
                connection = new SQLiteConnection(new SQLiteConnectionStringBuilder() { DataSource = path }.ToString());
                connection.Open();
                return true;
            }
            catch(Exception ex)
            {
                Console .WriteLine("数据库连接异常："+ex.Message);
                 return false;
            }
        }

        private bool CreateDataSqlite(string path)
        {
            try
            {
                string  dirName = new FileInfo(path).Directory.FullName;
                if (!Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(dirName);
                }
                SQLiteConnection .CreateFile(path);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("数据库创建异常"+e.Message);
                return false;
            }
        }

        public void Dispose()
        {
            connection?.Close();
            connection?.Dispose();
             
        }
    }
}
