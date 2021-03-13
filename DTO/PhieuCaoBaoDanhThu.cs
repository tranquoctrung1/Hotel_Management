using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
   public  class PhieuCaoBaoDanhThu
    {
        string _maPhieuBaoCao;
        string _thang;
        float _doanhThu;
        string _tiLe;
        string _maLoaiPhong;

        public string MaPhieuBaoCao { get => _maPhieuBaoCao; set => _maPhieuBaoCao = value; }
        public string Thang { get => _thang; set => _thang = value; }
        public float DoanhThu { get => _doanhThu; set => _doanhThu = value; }
        public string TiLe { get => _tiLe; set => _tiLe = value; }
        public string MaLoaiPhong { get => _maLoaiPhong; set => _maLoaiPhong = value; }
    }
}
