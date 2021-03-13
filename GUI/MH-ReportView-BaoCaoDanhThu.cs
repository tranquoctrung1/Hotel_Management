using BLL;
using Hotel_Management.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class MH_ReportView_BaoCaoDanhThu : Form
    {
        public MH_ReportView_BaoCaoDanhThu()
        {
            InitializeComponent();
        }
        ReportBLL xl = new ReportBLL();
        private void MH_ReportView_BaoCaoDanhThu_Load(object sender, EventArgs e)
        {
            string MaPhong = TruyenDuLieuManHinh.MaPhong;
            string Thang = TruyenDuLieuManHinh.Thang;



            DataTable baocao = new DataTable();
            baocao = xl.PhieuCaoBaoDanhThu(Thang);

            //foreach(DataRow row in baocao.Rows)
            //{
            //    MessageBox.Show(row["TiLe"].ToString());
            //}

            rpDoanhThu rp = new rpDoanhThu();
            rp.SetDataSource(baocao);

            CrytalViewBaoCao.ReportSource = rp;
        }
    }
}
