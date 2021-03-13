using DTO;
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
    public class ImportKhachHangDAL
    {

        public DataTable DuLieuMCuoiDanhSach()
        {
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();

            string sqlQuery = "select max(kh.MaKhachHang) from KHACHHANG kh";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;

        }
        public DataTable DanhSachLoaiKhachHang()
        {
            Provider provider = new Provider();

            provider.Connect();

            DataTable dt = new DataTable();

            string sqlQuery = "select lkh.MaLoaiKhachHang,lkh.TenLoaiKhach from LOAIKHACHHANG lkh";
            dt = provider.Select(CommandType.Text, sqlQuery);

            provider.DisConnect();
            return dt;

        }
        public int ThemKhachHnag(KhachHangDTO kh)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string SqlPhong = "INSERT INTO KHACHHANG(MaKhachHang,TenKhachHang,CMND,DiaChi,MaLoaiKhachHang) VALUES (@MaKhachHang,@TenKhachHang,@CMND,@DiaChi,@MaLoaiKhachHang)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, SqlPhong,
                            new SqlParameter { ParameterName = "@MaKhachHang", Value = kh.MaKhachHang },
                            new SqlParameter { ParameterName = "@TenKhachHang", Value = kh.TenKhachHang },
                            new SqlParameter { ParameterName = "@CMND", Value =kh.CMND},
                            new SqlParameter { ParameterName = "@DiaChi", Value = kh.DiaChi },
                            new SqlParameter { ParameterName = "@MaLoaiKhachHang", Value = kh.MaLoaiKhachHang }
                    );

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
    }
}
