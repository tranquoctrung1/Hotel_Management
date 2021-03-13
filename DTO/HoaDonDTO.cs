using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        string _maHoaDon;
        string _ngayThanhToan;
        double _triGia;
        string _maKhachHang;

        public string MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
        public string NgayThanhToan { get => _ngayThanhToan; set => _ngayThanhToan = value; }
        public double TriGia { get => _triGia; set => _triGia = value; }
        public string MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
    }
}
