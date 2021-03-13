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
    public partial class Danh_Sach_Phong : UserControl
    {
        public Danh_Sach_Phong()
        {
            InitializeComponent();
        }
        xlDanhSachPhongBLL xlDanhSachPhong = new xlDanhSachPhongBLL();
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_DanhSach()
        {
            DataTable xlDSDaThue = xlDanhSachPhong.DanhSachPhongDaThue();
            dgvDanhSach.DataSource = xlDSDaThue;

            if (dgvDanhSach.Rows.Count > 0)
            {
                dgvDanhSach.Rows[0].Selected = true;

                //Các Dòng Trong DaTaGView Của Khách Hàng;

                //TruyenDuLieuManHinh.kh.MaKhachHang = dgvDanhSach.Rows[0].Cells["MaKhachhang"].Value.ToString();
                //TruyenDuLieuManHinh.kh.TenKhachHang = dgvDanhSach.Rows[0].Cells["TenKhachHang"].Value.ToString();
                //TruyenDuLieuManHinh.kh.CMND = dgvDanhSach.Rows[0].Cells["CMND"].Value.ToString();
                //TruyenDuLieuManHinh.kh.DiaChi = dgvDanhSach.Rows[0].Cells["DiaChi"].Value.ToString();

                ////Các Dòng Trong DaTaGView Của Phòng;
                //TruyenDuLieuManHinh.p.MaPhong = dgvDanhSach.Rows[0].Cells["MaPhong"].Value.ToString();
                //TruyenDuLieuManHinh.p.TenPhong = dgvDanhSach.Rows[0].Cells["TenPhong"].Value.ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void XemChuaThue_Click(object sender, EventArgs e)
        {
            DataTable xlDSChuaThue = xlDanhSachPhong.DanhSachPhongChuaThue();
            dgvDanhSach.DataSource = xlDSChuaThue;
        }

        private void XemDangThue_Click(object sender, EventArgs e)
        {
            Load_DanhSach();
        }
    }
}
