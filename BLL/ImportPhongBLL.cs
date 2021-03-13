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
    public class ImportPhongBLL
    {
        public string DuLieuMCuoiDanhSach()
        {
            ImportPhongDAL xl = new ImportPhongDAL();
            DataTable dt = xl.DuLieuMCuoiDanhSach();
            return dt.Rows[0][0].ToString();
        }

        public int ThemPhong(PhongDTO p)
        {
            

           
            ImportPhongDAL xl = new ImportPhongDAL();
            return xl.ThemPhong(p);



        }
        public DataTable DanhSachLoaiPhong()
        {
            ImportPhongDAL xl = new ImportPhongDAL();

            return xl.DanhSachLoaiPhong();
        }
        public DataTable DanhSachLoaiTinhTrang()
        {
            ImportPhongDAL xl = new ImportPhongDAL();

           
            return  xl.DanhSachLoaiTinhTrang();
        }
    }
}
