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
    public class xlTraCuuPhongBLL
    {

        public DataTable LoadTimKiem(PhongDTO p, LoaiPhongDTO lp, LoaiTinhTrangDTO tt)
        {
            xlTraCuuPhongDAL xl = new xlTraCuuPhongDAL();
            return xl.LoadTimKiem(p, lp, tt);
        }

        public DataTable LoadLoaiPhong()
        {
            xlTraCuuPhongDAL xl = new xlTraCuuPhongDAL();
            return xl.LoadLoaiPhong();
        }

        public DataTable LoadTinhTrang()
        {
            xlTraCuuPhongDAL xl = new xlTraCuuPhongDAL();
            return xl.LoadTinhTrang();
        }
        public DataTable LoadTraCuu()
        {
            xlTraCuuPhongDAL xl = new xlTraCuuPhongDAL();
            return xl.LoadTraCuu();
        }
    }
}
