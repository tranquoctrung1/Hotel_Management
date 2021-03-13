using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DTO
{
    public class LoaiTinhTrangDTO
    {
        string _maTinhTrang;
        string _tenTinhTrang;

        public string MaTinhTrang { get => _maTinhTrang; set => _maTinhTrang = value; }
        public string TenTinhTrang { get => _tenTinhTrang; set => _tenTinhTrang = value; }
    }
}
