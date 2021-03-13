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
            KhachHangDAL khachHangDAL = new KhachHangDAL();

            return khachHangDAL.loadKhachHang();
        }
        public DataTable loadKhachHangDangThue(string MaPhong)
        {
            KhachHangDAL khachHangDAL = new KhachHangDAL();

            return khachHangDAL.loadKhachHangDangThue(MaPhong);
        }
    }
}
