using Hotel_Management.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.GUI
{
    public partial class MH_ReportView_BaoCaoMatDo : Form
    {
        public MH_ReportView_BaoCaoMatDo()
        {
            InitializeComponent();
        }

        ReportBLL xl = new ReportBLL();
        private void MH_ReportView_BaoCaoMatDo_Load(object sender, EventArgs e)
        {
            string MaPhong = TruyenDuLieuManHinh.MaPhong;
            string Thang = TruyenDuLieuManHinh.Thang;


            DataTable baocao = new DataTable();
            baocao = xl.PhieuCaoBaoMatDo(Thang);


            //rpMatDo rp = new rpMatDo();
            //rp.SetDataSource(baocao);

            //CrytalView.ReportSource = rp;
        }
    }
}
