using DTO;
using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiPhongDAL
    {
        public DataTable loadLoaiPhong()
        {
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();

            string sqlQuery = "SELECT MaLoaiPhong, TenLoaiPhong FROM LOAIPHONG";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;

        }
    }
}
