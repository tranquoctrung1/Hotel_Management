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
    public partial class Thay_Doi_Quy_Dinh : UserControl
    {
        public Thay_Doi_Quy_Dinh()
        {
            InitializeComponent();
        }
        LoaiPhongDTO lp = new LoaiPhongDTO();
        LoaiPhongDTO loai;

        ThamSoDTO ts = new ThamSoDTO();

        xlThayDoiQuyDinhBLL bus = new xlThayDoiQuyDinhBLL();

        private void Thay_Doi_Quy_Dinh_Load(object sender, EventArgs e)
        {
            DataTable data = bus.LoadLoaiPhong();
            cmbLoaiPhong.DataSource = data;
            cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";

            DataTable dataLK = bus.LoadLoaiKhach();
            cmbLoaiKhach.DataSource = dataLK;
            cmbLoaiKhach.DisplayMember = "TenLoaiKhach";
            cmbLoaiKhach.ValueMember = "MaLoaiKhachHang";

            DataTable dataThamSo = bus.LoadThamSo(ts);
            txtSoLuongToiDaTrongPhong.Text = dataThamSo.Rows[0]["SoKhachToiDa"].ToString();
            txtSoLuongKhachNuocNgoai.Text = dataThamSo.Rows[0]["SoKhachNuocNgoai"].ToString();
            txtSoLuongKhachNoiDia.Text = dataThamSo.Rows[0]["SoKhachNoiDia"].ToString();
            txtTiLePhuThu.Text = dataThamSo.Rows[0]["TiLePhuThu"].ToString();
        }

        private void btnLuuThongTinLoaiPhong_Click(object sender, EventArgs e)
        {
            if (txtSoLuongPhong.Text == "" || txtSoLuongPhong.Text == null)
            {
                MessageBox.Show("Ô số lượng không thể để trống! Vui lòng chọn lại Loại Phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongPhong.Focus();
            }
            else if (txtDonGia.Text == "" || txtDonGia.Text == null)
            {
                MessageBox.Show("Ô đơn giá không thể để trống! Vui lòng chọn lại Loại Phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else if (bus.IsNumber(txtSoLuongPhong.Text) == false)
            {
                MessageBox.Show("Ô số lượng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongPhong.Focus();
            }
            else if (bus.IsNumber(txtDonGia.Text) == false)
            {
                MessageBox.Show("Ô đơn giá phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else
            {

                loai = new LoaiPhongDTO();
                loai.MaLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
                loai.SoLuong = int.Parse(txtSoLuongPhong.Text);
                loai.DonGia = int.Parse(txtDonGia.Text);
                int n = 0;

                n = bus.SuaThongTinLoaiPhong(loai);

                if (n == 0)
                {
                    MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuuThongTinTrongPhong_Click(object sender, EventArgs e)
        {
            if (bus.IsNumber(txtSoLuongToiDaTrongPhong.Text) == false)
            {
                MessageBox.Show("Ô số tối đa trong phòng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else if (bus.IsNumber(txtSoLuongKhachNuocNgoai.Text) == false)
            {
                MessageBox.Show("Ô số lượng khách Nước Ngoài tối đa trong phòng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else if (bus.IsNumber(txtSoLuongKhachNoiDia.Text) == false)
            {
                MessageBox.Show("Ô số lượng khách Nội Địa tối đa trong phòng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else if (bus.IsNumber(txtTiLePhuThu.Text) == false)
            {
                MessageBox.Show("Ô tỉ lệ phụ thu phải là số thực hoặc số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else
            {
                ThamSoDTO ts = new ThamSoDTO();
                ts.SoKhachToiDa = int.Parse(txtSoLuongToiDaTrongPhong.Text);
                ts.SoKhachNuocNgoai = int.Parse(txtSoLuongKhachNuocNgoai.Text);
                ts.SoKhachNoiDia = int.Parse(txtSoLuongKhachNoiDia.Text);
                ts.TiLePhuThu = float.Parse(txtTiLePhuThu.Text);

                int n = 0;

                n = bus.SuaThamSo(ts);

                if (n == 0)
                {
                    MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmb = cmbLoaiPhong.SelectedValue.ToString();
            DataTable dt = bus.LoadThongTinLoaiPhong(cmb);

            foreach (DataRow row in dt.Rows)
            {
                txtSoLuongPhong.Text = row["SoLuongPhong"].ToString();
                txtDonGia.Text = row["DonGia"].ToString();
            }
        }

        private void cmbLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int cmb = int.Parse(cmbLoaiKhach.SelectedValue.ToString()) + 1;
            int cmb = Convert.ToInt32(cmbLoaiKhach.SelectedIndex.ToString()) + 1;
            //MessageBox.Show(cmb.ToString());
            DataTable dt = bus.LoadThongTinLoaiKhach(cmb);

            foreach (DataRow row in dt.Rows)
            {
                txtHeSoKhach.Text = row["HeSoKhach"].ToString();
            }
        }

        private void btnLuuHeSoKhach_Click(object sender, EventArgs e)
        {
            if (txtHeSoKhach.Text == "" || txtHeSoKhach.Text == null)
            {
                MessageBox.Show("Ô hệ số khách không thể để trống! Vui lòng chọn lại loại khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeSoKhach.Focus();
            }
            else if (bus.IsNumber(txtHeSoKhach.Text) == false)
            {
                MessageBox.Show("Ô hệ số khách phải là số nguyên hoặc số thực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
            }
            else
            {
                LoaiKhachHangDTO lkh = new LoaiKhachHangDTO();
                lkh.MaLoaiKhachHang = Convert.ToInt32(cmbLoaiKhach.SelectedValue.ToString());
                lkh.HeSoKhach = float.Parse(txtHeSoKhach.Text);
                int n = 0;

                n = bus.SuaHeSoKhach(lkh);

                if (n == 0)
                {
                    MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
