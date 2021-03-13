using DTO;
using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class ReportBLL
    {
        public DataTable DanhSachLoaiPhong()
        {
            ReportDAL xl = new ReportDAL();
            return xl.DanhSachLoaiPhong();
        }
        public DataTable PhieuCaoBaoDanhThu(string Thang)
        {
            ReportDAL xl = new ReportDAL();
            return xl.PhieuCaoBaoDanhThu(Thang);
        }
        public DataTable PhieuCaoBaoMatDo(string Thang)
        {
            ReportDAL xl = new ReportDAL();
            return xl.PhieuCaoBaoMatDo(Thang);
        }

        public DataTable BaoCaoDoanhThu(int month)
        {
            ReportDAL doanhThuDAL = new ReportDAL();
            return doanhThuDAL.getRevenue(month);
        }

        public DataTable BaoCaoMatDo(int month)
        {
            ReportDAL doanhThuDAL = new ReportDAL();
            return doanhThuDAL.getMatDo(month);
        }
        public string LayMaPhieuBaoCaoCuoiCung()
        {
            ReportDAL xl = new ReportDAL();
            DataTable dt = xl.LayMaPhieuBaoCaoCuoiCung();
            return dt.Rows[0][0].ToString();
        }
        public int ThemDataVaoPhieuBaoCao(PhieuCaoBaoDanhThu bc)
        {
            ReportDAL xl = new ReportDAL();
            return xl.ThemDataVaoPhieuBaoCao(bc);
        }
        public int ThemDataVaoPhieuBaoCaoMatDo(PhieuCaoBaoMatDo bc)
        {
            ReportDAL xl = new ReportDAL();
            return xl.ThemDataVaoPhieuBaoCaoMatDo(bc);
        }
        public string LayMaPhieuBaoCaoMatDOCuoiCung()
        {
            ReportDAL xl = new ReportDAL();
            DataTable dt = xl.LayMaPhieuBaoCaoMatDOCuoiCung();
            return dt.Rows[0][0].ToString();
        }
    }
}
