using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        string _maKhachHang;
        string _tenKhachHang;
        string _maLoaiKhachHang;
        string _cMND;
        string _diaChi;

        public string MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
        public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
        public string MaLoaiKhachHang { get => _maLoaiKhachHang; set => _maLoaiKhachHang = value; }
        public string CMND { get => _cMND; set => _cMND = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
    }
}
