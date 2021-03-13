using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuePhongDTO
    {
        string _maPhieuThuePhong;
        string _ngayThue;
        string _maPhong;

        public string MaPhieuThuePhong { get => _maPhieuThuePhong; set => _maPhieuThuePhong = value; }
        public string NgayThue { get => _ngayThue; set => _ngayThue = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
    }
}
