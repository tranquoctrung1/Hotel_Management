using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietThuePhongDTO
    {
        string _maChiTietThuePhong;
        string _maPhieuThuePhong;
        string _maKhachHang;

        public string MaChiTietThuePhong { get => _maChiTietThuePhong; set => _maChiTietThuePhong = value; }
        public string MaPhieuThuePhong { get => _maPhieuThuePhong; set => _maPhieuThuePhong = value; }
        public string MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
    }
}
