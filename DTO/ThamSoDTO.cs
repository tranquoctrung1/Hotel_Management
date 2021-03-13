using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSoDTO
    {
        int _soKhachToiDa;
        int _soKhachNuocNgoai;
        int _soKhachNoiDia;
        float _tiLePhuThu;

        public int SoKhachToiDa { get => _soKhachToiDa; set => _soKhachToiDa = value; }
        public int SoKhachNuocNgoai { get => _soKhachNuocNgoai; set => _soKhachNuocNgoai = value; }
        public float TiLePhuThu { get => _tiLePhuThu; set => _tiLePhuThu = value; }
        public int SoKhachNoiDia { get => _soKhachNoiDia; set => _soKhachNoiDia = value; }
    }
}
