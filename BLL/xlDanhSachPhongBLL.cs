using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class xlDanhSachPhongBLL
    {
        public DataTable DanhSachPhong()
        {
            xlDanhSachPhongDAL xlDanhSachPhong = new xlDanhSachPhongDAL();
            return xlDanhSachPhong.DanhSachPhong();
        }
        public DataTable DanhSachPhongDaThue()
        {
            xlDanhSachPhongDAL xlDanhSachPhong = new xlDanhSachPhongDAL();
            return xlDanhSachPhong.DanhSachPhongDaThue();
        }
        public DataTable DanhSachPhongChuaThue()
        {
            xlDanhSachPhongDAL xlDanhSachPhong = new xlDanhSachPhongDAL();
            return xlDanhSachPhong.DanhSachPhongChuaThue();
        }
    }
}
