using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImportKhacHangBLL
    {
        public string DuLieuMCuoiDanhSach()
        {
            ImportKhachHangDAL xl = new ImportKhachHangDAL();
            DataTable dt = xl.DuLieuMCuoiDanhSach();
            return dt.Rows[0][0].ToString();
        }
        public DataTable DanhSachLoaiKhachHang()
        {
            ImportKhachHangDAL xl = new ImportKhachHangDAL();
            return xl.DanhSachLoaiKhachHang();
        }
        public int ThemKhachHnag(KhachHangDTO kh)
        {
            ImportKhachHangDAL xl = new ImportKhachHangDAL();
            return xl.ThemKhachHnag(kh);
        }
    }
}
