using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class PhongDTO
    {
        string _maPhong;
        string _tenPhong;
        string _maLoaiPhong;
        string _ghiChu;
        string _tinhTrang;
        string _maLoaiTinhTrang;
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public string TenPhong { get => _tenPhong; set => _tenPhong = value; }
        public string MaLoaiPhong { get => _maLoaiPhong; set => _maLoaiPhong = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
        public string MaLoaiTinhTrang { get => _maLoaiTinhTrang; set => _maLoaiTinhTrang = value; }
    }
}
