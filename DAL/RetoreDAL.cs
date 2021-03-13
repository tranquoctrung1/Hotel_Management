using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class RetoreDAL
    {
        public int xlRetore(string path)
        {
            Provider provider = new Provider();
            int n = 0;
            try
            {
                provider.Connect();
                string database = provider.TenDaTaBase().ToString();
                string sql2 = string.Format("ALTER DATABASE[" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                n = provider.ExecuteNonQuery(CommandType.Text, sql2);

                string sql3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + path + "'WITH REPLACE;";
                n = provider.ExecuteNonQuery(CommandType.Text, sql3);

                string sql4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                n = provider.ExecuteNonQuery(CommandType.Text, sql4);
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
