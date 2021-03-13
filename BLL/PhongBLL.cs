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
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadPhongChuaThue();
        }

        public DataTable loadPhongDaThue()
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadPhongDaThue();
        }

        public string loadTenPhong(string maPhong)
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadTenPhong(maPhong);
        }

        public DateTime loadNgayThuePhong(string maPhong)
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadNgayThuePhong(maPhong);
        }

        public double loadDonGia(string maPhong)
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadDonGia(maPhong);
        }

        public double loadPhuThuNuocNgoai(string maPhong)
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadPhuThuNuocNgoai(maPhong);
        }

        public double loadTiLePhuThuNuocNgoai(string maPhong)
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.loadTiLePhuThuNuocNgoai(maPhong);
        }
    }
}
