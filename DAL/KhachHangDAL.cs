using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class KhachHangDAL
    {
        public DataTable loadKhachHang()
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT KH.MaKhachHang , KH.TenKhachHang FROM KHACHHANG KH";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;
        }


        public DataTable loadKhachHangDangThue(string MaPhong)
        {
            Provider provider = new Provider();

            provider.Connect();
            DataTable dt = new DataTable();
            string sqlQuery = "SELECT KH.MaKhachHang,KH.TenKhachHang FROM KHACHHANG KH JOIN CHITIETTHUEPHONG CTPT ON CTPT.MaKhachHang = KH.MaKhachHang JOIN PHIEUTHUEPHONG PT ON CTPT.MaPhieuThuePhong = PT.MaPhieuThuePhong WHERE PT.MaPhong = @MaPhong";
            dt = provider.Select(CommandType.Text, sqlQuery,
               new SqlParameter { ParameterName = "@MaPhong", Value = MaPhong });

            provider.DisConnect();
            return dt;
        }
    }
}
