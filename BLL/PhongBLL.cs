using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class PhongBLL
    {
        public DataTable loadPhongChuaThue()
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadPhongChuaThue();
        }

        public DataTable loadPhongDaThue()
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadPhongDaThue();
        }

        public string loadTenPhong(string maPhong)
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadTenPhong(maPhong);
        }

        public DateTime loadNgayThuePhong(string maPhong)
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadNgayThuePhong(maPhong);
        }

        public double loadDonGia(string maPhong)
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadDonGia(maPhong);
        }

        public double loadPhuThuNuocNgoai(string maPhong)
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadPhuThuNuocNgoai(maPhong);
        }

        public double loadTiLePhuThuNuocNgoai(string maPhong)
        {
            PhongDAL phongDAO = new PhongDAL();
            return phongDAO.loadTiLePhuThuNuocNgoai(maPhong);
        }
    }
}
