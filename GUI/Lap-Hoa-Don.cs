using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Hotel_Management.BLL;

namespace Hotel_Management
{
    public partial class Lap_Hoa_Don : UserControl
    {
        KhachHangDTO kh = new KhachHangDTO();
        PhongDTO p = new PhongDTO();
        LoaiPhongDTO lp = new LoaiPhongDTO();

        xlLapHoaDonBLL BLL = new xlLapHoaDonBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        PhongBLL phongBLL = new PhongBLL();

        int index = 0;

        public Lap_Hoa_Don()
        {
            InitializeComponent();
        }

        private void Lap_Hoa_Don_Load(object sender, EventArgs e)
        {
            loadData();
            txtTongGiaTri.Text = 0.ToString();
        }

        void loadData()
        {
            cbMaPhong.DataSource = phongBLL.loadPhongDaThue();
            cbMaPhong.DisplayMember = "TenPhong";
            cbMaPhong.ValueMember = "MaPhong";


            
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            string maPhong = cbMaPhong.SelectedValue.ToString();
            string tenPhong = phongBLL.loadTenPhong(cbMaPhong.SelectedValue.ToString());

            DateTime ngayThue = phongBLL.loadNgayThuePhong(cbMaPhong.SelectedValue.ToString());
            DateTime ngayHienTai = DateTime.Now;

            double songayThue = (ngayHienTai.Date - ngayThue.Date).TotalDays;
            double donGia = phongBLL.loadDonGia(cbMaPhong.SelectedValue.ToString());
            double phuThu = phongBLL.loadPhuThuNuocNgoai(cbMaPhong.SelectedValue.ToString());
            double tiLePhuThu = phongBLL.loadTiLePhuThuNuocNgoai(cbMaPhong.SelectedValue.ToString());
            double thanhTien = donGia * songayThue * phuThu * tiLePhuThu;


            string[] row = new string[] { (index + 1).ToString(), maPhong, tenPhong, ngayThue.ToString("yyyy-MM-dd"), songayThue.ToString(), donGia.ToString(), thanhTien.ToString() };


            dgvDanhSachPhongThanhToan.Rows.Add(row);

            txtTongGiaTri.Text = (double.Parse(txtTongGiaTri.Text) + thanhTien).ToString();

            index++;
            
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

                BLL.ThemThanhToan(hd, dscthd);
                MessageBox.Show("Thêm thành công");
                dgvDanhSachPhongThanhToan.Rows.Clear();
                txtTongGiaTri.Text = "0";
                index = 0;
            }else
            {
                MessageBox.Show("Chưa Nhập Phòng Thanh Toán");
            }
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhongThue = cbMaPhong.SelectedValue.ToString();

            DataTable dataKH = khachHangBLL.loadKhachHangDangThue(maPhongThue);

            cbKhachHang.DataSource = dataKH;
            cbKhachHang.DisplayMember = "TenKhachHang";
            cbKhachHang.ValueMember = "MaKhachHang";
        }
    }
}
