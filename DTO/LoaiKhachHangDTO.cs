using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHangDTO
    {
        int _maLoaiKhachHang;
        string _loaiKhach;
        float _heSoKhach;

        public int MaLoaiKhachHang { get => _maLoaiKhachHang; set => _maLoaiKhachHang = value; }
        
        public float HeSoKhach { get => _heSoKhach; set => _heSoKhach = value; }
        public string LoaiKhach { get => _loaiKhach; set => _loaiKhach = value; }
    }
}
