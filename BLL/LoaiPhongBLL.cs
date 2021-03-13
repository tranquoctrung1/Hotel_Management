using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiPhongBLL
    {
        public DataTable loadLoaiPhong()
        {
            LoaiPhongDAL DAL = new LoaiPhongDAL();

            return DAL.loadLoaiPhong();
        }

    }
}
