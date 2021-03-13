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
    public partial class Lap_Hoa_Don : UserControl
    {
        public Lap_Hoa_Don()
        {
            InitializeComponent();
        }
        KhachHangDTO kh = new KhachHangDTO();
        PhongDTO p = new PhongDTO();
        LoaiPhongDTO lp = new LoaiPhongDTO();

        xlLapHoaDonBLL bus = new xlLapHoaDonBLL();
        KhachHangBLL khachHangBUS = new KhachHangBLL();
        PhongBLL phongBUS = new PhongBLL();
        int index = 0;
        DateTime ngayHienTai = DateTime.Now;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhongThue = cbMaPhong.SelectedValue.ToString();

            DataTable dataKH = khachHangBUS.loadKhachHangDangThue(maPhongThue);

            cbKhachHang.DataSource = dataKH;
            cbKhachHang.DisplayMember = "TenKhachHang";
            cbKhachHang.ValueMember = "MaKhachHang";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ngayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            DateTime NgayTra = ngayThanhToan.Value;
            //DateTime ngayHienTai1 = ngayThanhToan.SelectedValue
            //MessageBox.Show(NgayTra.ToString());
            ngayHienTai = NgayTra;
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhongThanhToan.Rows.Count > 0)
            {


                HoaDonDTO hd = new HoaDonDTO();
                List<ChiTietHoaDonDTO> dscthd = new List<ChiTietHoaDonDTO>();

                for (int i = 0; i < dgvDanhSachPhongThanhToan.Rows.Count; i++)
                {
                    ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();

                    cthd.MaPhong = dgvDanhSachPhongThanhToan.Rows[i].Cells[1].Value.ToString();
                    cthd.SoNgayThue = int.Parse(dgvDanhSachPhongThanhToan.Rows[i].Cells[4].Value.ToString());
                    cthd.DonGia = double.Parse(dgvDanhSachPhongThanhToan.Rows[i].Cells[5].Value.ToString());
                    cthd.ThanhTien = double.Parse(dgvDanhSachPhongThanhToan.Rows[i].Cells[6].Value.ToString());

                    dscthd.Add(cthd);
                }

                hd.MaKhachHang = cbKhachHang.SelectedValue.ToString();
                hd.NgayThanhToan = ngayThanhToan.Value.Date.ToString("yyyy-MM-dd");
                hd.TriGia = double.Parse(txtTongGiaTri.Text);

                bus.ThemThanhToan(hd, dscthd);
                MessageBox.Show("Thêm thành công");
                dgvDanhSachPhongThanhToan.Rows.Clear();
                txtTongGiaTri.Text = "0";
                index = 0;
            }
            else
            {
                MessageBox.Show("Chưa Nhập Phòng Thanh Toán");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTongGiaTri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachPhongThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            string maPhong = cbMaPhong.SelectedValue.ToString();
            string tenPhong = phongBUS.loadTenPhong(cbMaPhong.SelectedValue.ToString());

            DateTime ngayThue = phongBUS.loadNgayThuePhong(cbMaPhong.SelectedValue.ToString());


            double songayThue = (ngayHienTai.Date - ngayThue.Date).TotalDays;

            double donGia = phongBUS.loadDonGia(cbMaPhong.SelectedValue.ToString());
            double phuThu = phongBUS.loadPhuThuNuocNgoai(cbMaPhong.SelectedValue.ToString());
            double tiLePhuThu = phongBUS.loadTiLePhuThuNuocNgoai(cbMaPhong.SelectedValue.ToString());
            double thanhTien = donGia * songayThue * phuThu * tiLePhuThu;


            string[] row = new string[] { (index + 1).ToString(), maPhong, tenPhong, ngayThue.ToString("yyyy-MM-dd"), songayThue.ToString(), donGia.ToString(), thanhTien.ToString() };


            dgvDanhSachPhongThanhToan.Rows.Add(row);

            txtTongGiaTri.Text = (double.Parse(txtTongGiaTri.Text) + thanhTien).ToString();

            index++;
        }

        private void Lap_Hoa_Don_Load(object sender, EventArgs e)
        {
            loadData();
            txtTongGiaTri.Text = 0.ToString();
        }
        void loadData()
        {
            cbMaPhong.DataSource = phongBUS.loadPhongDaThue();
            cbMaPhong.DisplayMember = "TenPhong";
            cbMaPhong.ValueMember = "MaPhong";



        }
    }
}
