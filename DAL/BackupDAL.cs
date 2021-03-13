using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class BackupDAL
    {
        public int xlBackup(string path)
        {
            Provider provider = new Provider();
            int n = 0;
 
            try
            {
                provider.Connect();
                string database = provider.TenDaTaBase().ToString();
                string sql = "BACKUP DATABASE [" + database + "] TO DISK= '" + path + "\\" + "" + database + "" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH--mm--ss") + ".bak'";
                n = provider.ExecuteNonQuery(CommandType.Text, sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return n;
        }
    }
}
