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
    public partial class Lap_Phieu_Thue_Phong : UserControl
    {
        public Lap_Phieu_Thue_Phong()
        {
            InitializeComponent();
        }
        PhongBLL phongBus = new PhongBLL();
        KhachHangBLL khachHangBUS = new KhachHangBLL();
        LapPhieuThuePhongBLL lapPhieuThuePhongBUS = new LapPhieuThuePhongBLL();

        int index = 0;
        int soKhachToiDa = 0;
        private void Lap_Phieu_Thue_Phong_Load(object sender, EventArgs e)
        {
            soKhachToiDa = lapPhieuThuePhongBUS.SoLuongKhachToiDaTrongPhong();
            DanhSachPhieuThuePhong.Rows.Add(1);
            noteAmount.Text = "* Số lượng khách tối đa trong một phòng là: " + soKhachToiDa;
            loadData();
        }
        void loadData()
        {
            DanhSachPhieuThuePhong.Rows[index].Cells[0].Value = index + 1;
            DataGridViewComboBoxCell cbMaKhachHang = DanhSachPhieuThuePhong.Rows[index].Cells[1] as DataGridViewComboBoxCell;

            cbMaKhachHang.DataSource = khachHangBUS.loadKhachHang();
            cbMaKhachHang.DisplayMember = "TenKhachHang";
            cbMaKhachHang.ValueMember = "MaKhachHang";
            cbMaKhachHang.ValueType = typeof(string);

            cbMaPhong.DataSource = phongBus.loadPhongChuaThue();
            cbMaPhong.DisplayMember = "TenPhong";
            cbMaPhong.ValueMember = "MaPhong";

            index++;
        }

        private void addALineButton_Click(object sender, EventArgs e)
        {
            if (index > soKhachToiDa - 1)
            {
                MessageBox.Show("Số khách tối đa cho một phòng là: " + soKhachToiDa);
            }
            else
            {
                DanhSachPhieuThuePhong.Rows.Add(1);
                loadData();
            }
        }

        private void removeALineButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                int select = DanhSachPhieuThuePhong.Rows.Count;
                select = DanhSachPhieuThuePhong.SelectedCells[0].RowIndex;

                DanhSachPhieuThuePhong.Rows.RemoveAt(select);
                index--;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
            List<ChiTietThuePhongDTO> dSChiTietThuePhongDTO = new List<ChiTietThuePhongDTO>();

            for (int i = 0; i < DanhSachPhieuThuePhong.Rows.Count; i++)
            {
                ChiTietThuePhongDTO chiTietThuePhongDTO = new ChiTietThuePhongDTO();
                if (DanhSachPhieuThuePhong.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("Không được bỏ trống khách hàng", "THÔNG BÁO");
                    return;
                }

                chiTietThuePhongDTO.MaKhachHang = DanhSachPhieuThuePhong.Rows[i].Cells[1].Value.ToString();
                dSChiTietThuePhongDTO.Add(chiTietThuePhongDTO);
            }

            phieuThuePhongDTO.MaPhong = cbMaPhong.SelectedValue.ToString();
            phieuThuePhongDTO.NgayThue = ngayThuePhong.Value.Date.ToString("yyyy-MM-dd");

            lapPhieuThuePhongBUS.ThemPhieuThuePhong(phieuThuePhongDTO, dSChiTietThuePhongDTO);
            MessageBox.Show("Thêm thành công");
            DanhSachPhieuThuePhong.Rows.Clear();
            index = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            index = 0;
            DanhSachPhieuThuePhong.Rows.Clear();
        }
    }
}
