using DTO;
using Hotel_Management.DAL;
using System;
using System.Collections.Generic;
﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.BLL
{
    class xlLapHoaDonBLL
    {
        public int ThemThanhToan(HoaDonDTO hoaDonDTO, List<ChiTietHoaDonDTO> dSChiTietHoaDonDTO)
        {
            xlLapHoaDonDAO dao = new xlLapHoaDonDAO();
            return dao.ThemThanhToan(hoaDonDTO, dSChiTietHoaDonDTO);
        }
    }
}

