using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class xlExportDAL
    {
        public DataTable LoadKhachHang()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "select kh.MaKhachHang, kh.TenKhachHang, kh.CMND, kh.DiaChi, lkh.TenLoaiKhach FROM KHACHHANG kh join LOAIKHACHHANG lkh on kh.MaLoaiKhachHang = lkh.MaLoaiKhachHang";
                provider.Connect(); ;
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
