using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Hotel_Management.GUI
{
    public partial class MH_BaoCao : UserControl
    {
        public MH_BaoCao()
        {
            InitializeComponent();
        }
        ReportBLL report = new ReportBLL();
        PhieuCaoBaoDanhThu bc = new PhieuCaoBaoDanhThu();
        PhieuCaoBaoMatDo mt = new PhieuCaoBaoMatDo();
        private void btnBaoCaoLoaiPhong_Click(object sender, EventArgs e)
        {
           
            MH_ReportView_BaoCaoDanhThu mH_Report = new MH_ReportView_BaoCaoDanhThu();

            TruyenDuLieuManHinh.Thang = cbbThang.Text;
            mH_Report.ShowDialog();
        }
        List<int> thang = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        
        
        private void MH_BaoCao_Load(object sender, EventArgs e)
        {
            //cbbloaiPhong.DataSource = xl.DanhSachLoaiPhong();
            //cbbloaiPhong.DisplayMember = "TenLoaiPhong";
            //cbbloaiPhong.ValueMember = "MaLoaiPhong";

           


            for(int i=0;i<thang.Count;i++)
            {
                cbbThang.Items.Add(thang[i].ToString());
            }
            cbbThang.SelectedIndex = 0;
            for (int i = 0; i < thang.Count; i++)
            {
                cbbThang1.Items.Add(thang[i].ToString());
            }
            cbbThang1.SelectedIndex = 0;


           
        }

        private void btnMatDo_Click(object sender, EventArgs e)
        {

            MH_ReportView_BaoCaoMatDo mH_Report = new MH_ReportView_BaoCaoMatDo();
            
            TruyenDuLieuManHinh.Thang = cbbThang1.Text;
            mH_Report.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
