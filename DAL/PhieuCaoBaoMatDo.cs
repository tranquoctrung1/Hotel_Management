using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    public class PhieuCaoBaoMatDo
    {
        string _maPhieuMatDo;
        string _maLoaiPhong;
        string _matDo;
        string _tiLe;
        string _thang;

        public string MaPhieuMatDo { get => _maPhieuMatDo; set => _maPhieuMatDo = value; }
        public string MaLoaiPhong { get => _maLoaiPhong; set => _maLoaiPhong = value; }
        public string MatDo { get => _matDo; set => _matDo = value; }
        public string TiLe { get => _tiLe; set => _tiLe = value; }
        public string Thang { get => _thang; set => _thang = value; }
    }
}
