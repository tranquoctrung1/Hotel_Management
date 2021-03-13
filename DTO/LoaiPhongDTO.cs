using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    public class LoaiPhongDTO
    {
        string _maLoaiPhong;
        string _loaiPhong;
        float _donGia;
        int _soLuong;
        string _tenLoaiPhong;



        public string MaLoaiPhong { get => _maLoaiPhong; set => _maLoaiPhong = value; }
        public string LoaiPhong { get => _loaiPhong; set => _loaiPhong = value; }
        public float DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string TenLoaiPhong { get => _tenLoaiPhong; set => _tenLoaiPhong = value; }
    }
}
