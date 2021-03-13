using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    public class Provider
    {
        SqlConnection Connection { get; set; }
        public string TenDaTaBase()
        {
            return Connection.Database;
        }
        //Hàm kết Nối CSDL
        public void Connect()
        {
            try
            {
                var ConnectionString = @"Data Source=DESKTOP-FFOHST3\THANHNT0500;Initial Catalog=QLKS;Integrated Security=True";
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Hàm Bỏ Kết Nối CSDL
        public void DisConnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }
        //Hàm Truy Vấn Vào CSDL
        // Tham Số đầu vào 
        //+ CommandType kiểu Text hay StoredProcedure
        //+ Câu truy ván sql
        //+Mảng SqlParamater tham số đầu vào sql
        //Hàm này để chỉnh sửa Với CSDL đầu ra kiểu int
        public int ExecuteNonQuery(CommandType cmtType, string strSql,
                            params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Hàm Truy Vấn Vào CSDL
        // Tham Số đầu vào 
        //+ CommandType kiểu Text hay StoredProcedure
        //+ Câu truy ván sql
        //+Mảng SqlParamater tham số đầu vào sql
        //Hàm này để truy vấn lấy dữ liệu ra bỏ vào datatable
        public DataTable Select(CommandType cmtType, string strSql,
                            params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
