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
    public partial class Report_MatDo : UserControl
    {
        ReportBLL report = new ReportBLL();
        PhieuCaoBaoMatDo mt = new PhieuCaoBaoMatDo();
        public Report_MatDo()
        {
            InitializeComponent();
        }

        private void Report_MatDo_Load(object sender, EventArgs e)
        {

        }
        private bool IsNumber(string text)
        {
            return text.All(char.IsDigit);
        }

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
                    //MessageBox.Show(report.BaoCaoMatDo(month).ToString());
                    dgvDoanhThu.DataSource = report.BaoCaoMatDo(month);

                }
            }
            else
            {
                MessageBox.Show("Tháng không hợp lệ!", "THÔNG BÁO");
            }
        }

        private void SaveCDSL_Click(object sender, EventArgs e)
        {
            //THêm vào CDSL Bảng Mật Độ

            if (dgvDoanhThu.Rows.Count.ToString() == "0")
            {
                MessageBox.Show("Không Có Dữ Liệu");

            }
            else
            {
                DataTable dataMatDo = report.BaoCaoMatDo(int.Parse(inputMonth.Text));
                foreach (DataRow row in dataMatDo.Rows)
                {

                    mt.MaLoaiPhong = (row["MaLoaiPhong"].ToString());
                    mt.MatDo = ((row["MatDo"].ToString()));
                    string Tile1 = (row["TiLe"].ToString());
                    if (Tile1.Length > 7)
                    {
                        mt.TiLe = Tile1.Substring(0, 6) + "%";
                    }
                    else
                    {
                        mt.TiLe = Tile1 + "%";
                    }

                    string MaPhieuBaoCao;
                    if (report.LayMaPhieuBaoCaoMatDOCuoiCung() == string.Empty)
                    {
                        MaPhieuBaoCao = "BCMD001";
                    }
                    else
                    {
                        string MaPhieu = (report.LayMaPhieuBaoCaoMatDOCuoiCung());
                        //MessageBox.Show(MaPhieu);
                        int num = int.Parse(MaPhieu.Substring(4)) + 1;
                        MaPhieuBaoCao = "BCMD" + num.ToString("000");
                    }
                    mt.MaPhieuMatDo = MaPhieuBaoCao;
                    mt.Thang = inputMonth.Text;
                    //report.ThemDataVaoPhieuBaoCaoMatDo(mt);

                    //MessageBox.Show(mt.MaPhieuMatDo);
                    //MessageBox.Show(mt.MaLoaiPhong);
                    //MessageBox.Show(mt.Thang);
                    //MessageBox.Show(mt.TiLe);
                    //MessageBox.Show(mt.MatDo);

                }



                MessageBox.Show("Đã Lưu");
            }
        }
    }
}
