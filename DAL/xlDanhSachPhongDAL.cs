using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAL
{
    class xlDanhSachPhongDAL
    {
        public DataTable DanhSachPhong()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT KH.MaKhachHang,KH.TenKhachHang,P.MaPhong,P.TenPhong,PT.NgayThue,LTT.TenTinhTrang,KH.CMND,KH.DiaChi,P.GhiChu,HD.NgayThanhToan FROM KHACHHANG KH JOIN PHIEUTHUEPHONG PT ON KH.MaKhachHang = PT.MaKhachHang JOIN CHITIETTHUEPHONG CTPT ON CTPT.MaPhieuThuePhong = PT.MaPhieuThuePhong JOIN PHONG P ON P.MaPhong = CTPT.MaPhong JOIN LOAITINHTRANG LTT ON LTT.MaTinhTrang=P.MaTinhTrang left JOIN  HOADON HD ON HD.MaKhachHang=KH.MaKhachHang ORDER BY KH.MaKhachHang";
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

        public DataTable DanhSachPhongDaThue()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT KH.MaKhachHang,P.MaPhong,KH.TenKhachHang,P.TenPhong,PT.NgayThue,LTT.TenTinhTrang,KH.CMND,KH.DiaChi,P.GhiChu FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoaiPhong = LP.MaLoaiPhong JOIN LOAITINHTRANG LTT ON LTT.MaTinhTrang = P.MaTinhTrang JOIN PHIEUTHUEPHONG PT ON P.MaPhong = PT.MaPhong JOIN CHITIETTHUEPHONG CTPT ON CTPT.MaPhieuThuePhong = PT.MaPhieuThuePhong JOIN KHACHHANG KH ON CTPT.MaKhachHang = KH.MaKhachHang WHERE LTT.TenTinhTrang=N'Đã Sử Dụng'  ORDER BY P.MaPhong";
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
        public DataTable DanhSachPhongChuaThue()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT P.MaPhong,P.TenPhong,LTT.TenTinhTrang FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoaiPhong = LP.MaLoaiPhong JOIN LOAITINHTRANG LTT ON LTT.MaTinhTrang = P.MaTinhTrang WHERE LTT.TenTinhTrang=N'Chưa Sử Dụng'";
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
