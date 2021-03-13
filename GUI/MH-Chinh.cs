
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
    public partial class MH_Chinh : Form
    {
        public MH_Chinh()
        {
            InitializeComponent();
        }

        private void DanhSachPhong_Click(object sender, EventArgs e)
        {
            Danh_Sach_Phong dsPhong = new Danh_Sach_Phong();

            ShowUserControl.showControl(dsPhong, MHContent);
        }

        private void LapPhieuThuePhong_Click(object sender, EventArgs e)
        {
            Lap_Phieu_Thue_Phong lapPhieuThuePhong = new Lap_Phieu_Thue_Phong();
            ShowUserControl.showControl(lapPhieuThuePhong, MHContent);
        }

        private void LapHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            Lap_Hoa_Don lapHoaDon = new Lap_Hoa_Don();
            ShowUserControl.showControl(lapHoaDon, MHContent);
        }

        private void LapBaoCaoThang_Click(object sender, EventArgs e)
        {
            Bao_Cao_Danh_Thu_Theo_Loai_Phong doanhThu = new Bao_Cao_Danh_Thu_Theo_Loai_Phong();
            ShowUserControl.showControl(doanhThu, MHContent);
        }

        private void ThayDoiQuyDinh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TimPhong_Click(object sender, EventArgs e)
        {

        }

        private void DanhMucPhong_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
