using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        string _maChiTietHoaDon;
        int _soNgayThue;
        double _donGia;
        double _thanhTien;
        string _maPhong;
        string _maHoaDon;

        public string MaChiTietHoaDon { get => _maChiTietHoaDon; set => _maChiTietHoaDon = value; }
        public int SoNgayThue { get => _soNgayThue; set => _soNgayThue = value; }
        public double DonGia { get => _donGia; set => _donGia = value; }
        public double ThanhTien { get => _thanhTien; set => _thanhTien = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public string MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
    }
}
