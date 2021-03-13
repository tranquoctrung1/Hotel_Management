using DTO;
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
    public partial class Bao_Cao_Danh_Thu_Theo_Loai_Phong : UserControl
    {
        ReportBLL report = new ReportBLL();
        PhieuCaoBaoDanhThu bc = new PhieuCaoBaoDanhThu();
        public Bao_Cao_Danh_Thu_Theo_Loai_Phong()
        {
            InitializeComponent();
        }
        private bool IsNumber(string text)
        {
            return text.All(char.IsDigit);
        }
        int n = 0;

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputMonth.Text))
            {
                MessageBox.Show("Vui lòng nhập tháng cần xem báo cáo!", "THÔNG BÁO");
                return;
            }

            if (IsNumber(inputMonth.Text))
            {
                int month = int.Parse(inputMonth.Text);
                if (month < 1 || month > 12)
                    MessageBox.Show("Tháng không hợp lệ!", "THÔNG BÁO");
                else
                {
                    dgvDoanhThu.DataSource = report.BaoCaoDoanhThu(month);
                }
            }
            else
            {
                MessageBox.Show("Tháng không hợp lệ!", "THÔNG BÁO");
            }
        }

        private void SaveCSLD_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.Rows.Count.ToString() == "0")
            {
                MessageBox.Show("Không Có Dữ Liệu");

            }
            else
            {
                DataTable dataDoanhThu = report.BaoCaoDoanhThu(int.Parse(inputMonth.Text));
                foreach (DataRow row in dataDoanhThu.Rows)
                {

                    bc.MaLoaiPhong = (row["MaLoaiPhong"].ToString());
                    bc.DoanhThu = float.Parse((row["DoanhThu"].ToString()));
                    string Tile1 = (row["TiLe"].ToString());
                    if (Tile1.Length > 7)
                    {
                        bc.TiLe = Tile1.Substring(0, 6) + "%";
                    }
                    else
                    {
                        bc.TiLe = Tile1 + "%";
                    }


                    string MaPhieuBaoCao;
                    if (report.LayMaPhieuBaoCaoCuoiCung() == string.Empty)
                    {
                        MaPhieuBaoCao = "BCDT001";
                    }
                    else
                    {
                        string MaPhieu = (report.LayMaPhieuBaoCaoCuoiCung());
                        int num = int.Parse(MaPhieu.Substring(4)) + 1;
                        MaPhieuBaoCao = "BCDT" + num.ToString("000");
                    }
                    bc.MaPhieuBaoCao = MaPhieuBaoCao;
                    bc.Thang = inputMonth.Text;
                    n = report.ThemDataVaoPhieuBaoCao(bc);




                    //MessageBox.Show(bc.MaPhieuBaoCao);
                    //MessageBox.Show(bc.MaLoaiPhong);
                    //MessageBox.Show(bc.Thang);
                    //MessageBox.Show(bc.TiLe);
                    //MessageBox.Show(bc.DoanhThu.ToString());

                }




                MessageBox.Show("Đã Lưu");

            }
        }
    }
}
