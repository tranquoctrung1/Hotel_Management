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
    public class xlLapHoaDonBLL
    {
        public int ThemThanhToan(HoaDonDTO hoaDonDTO, List<ChiTietHoaDonDTO> dSChiTietHoaDonDTO)
        {
            xlLapHoaDonDAL DAL = new xlLapHoaDonDAL();
            return DAL.ThemThanhToan(hoaDonDTO, dSChiTietHoaDonDTO);
        }
    }
}
