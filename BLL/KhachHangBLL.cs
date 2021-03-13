using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class KhachHangBLL
    {
        public DataTable loadKhachHang()
        {
            KhachHangDAL khachHangDAO = new KhachHangDAL();

            return khachHangDAO.loadKhachHang();
        }
        public DataTable loadKhachHangDangThue(string MaPhong)
        {
            KhachHangDAL khachHangDAO = new KhachHangDAL();

            return khachHangDAO.loadKhachHangDangThue(MaPhong);
        }
    }
}
