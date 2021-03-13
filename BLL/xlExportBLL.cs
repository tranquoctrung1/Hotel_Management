using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class xlExportBLL
    {
        public DataTable LoadKhachHang()
        {
            xlExportDAL BLL = new xlExportDAL();
            return BLL.LoadKhachHang();
        }
    }
}
