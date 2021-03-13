using DTO;
using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class LapPhieuThuePhongBLL
    {
        public Int32 ThemPhieuThuePhong(PhieuThuePhongDTO phieuThuePhong, List<ChiTietThuePhongDTO> dSChiTietThuePhongDTO)
        {
            LapPhieuThuePhongDAL lapPhieuThuePhongDAO = new LapPhieuThuePhongDAL();

            return lapPhieuThuePhongDAO.ThemPhieuThuePhong(phieuThuePhong, dSChiTietThuePhongDTO);
        }

        public int SoLuongKhachToiDaTrongPhong()
        {
            LapPhieuThuePhongDAL lapPhieuThuePhongDAO = new LapPhieuThuePhongDAL();

            return lapPhieuThuePhongDAO.SoLuongKhachToiDaTrongPhong();
        }
    }
}
