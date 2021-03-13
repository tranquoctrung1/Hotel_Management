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
using Hotel_Management.GUI;

namespace Hotel_Management
{
    public partial class Tra_Cuu : UserControl
    {
        public Tra_Cuu()
        {
            InitializeComponent();
        }
        PhongDTO p = new PhongDTO();
        LoaiPhongDTO lp = new LoaiPhongDTO();
        LoaiTinhTrangDTO tt = new LoaiTinhTrangDTO();
        xlTraCuuPhongBLL traCuuPhongBLL = new xlTraCuuPhongBLL();


        private void btnTim_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaPhong.Text == "")
                {
                    p.MaPhong = "1";
                }
                else
                {
                    p.MaPhong = txtMaPhong.Text;
                }

                if (txtTenPhong.Text == "")
                {
                    p.TenPhong = "1";
                }
                else
                {
                    p.TenPhong = txtTenPhong.Text;
                }

                if (txtDonGia.Text == "")
                {
                    lp.DonGia = 1;

                }
                else
                {
                    lp.DonGia = float.Parse(txtDonGia.Text);
                }

                if (cmbTinhTrang.Text == "")
                {
                    tt.TenTinhTrang = "1";

                }
                else
                {
                    tt.TenTinhTrang = cmbTinhTrang.Text;
                }

                if (cmbLoaiPhong.Text == string.Empty)
                {
                    lp.MaLoaiPhong = "1";

                }
                else
                {
                    lp.MaLoaiPhong = cmbLoaiPhong.Text;
                }

                DataTable dt= traCuuPhongBLL.LoadTimKiem(p, lp, tt);
                 dgvTraCuu.DataSource = dt;



            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



        private void Tra_Cuu_Load(object sender, EventArgs e)
        {
           


            DataTable data = traCuuPhongBLL.LoadLoaiPhong();
            cmbLoaiPhong.DataSource = data;
            cmbLoaiPhong.DisplayMember = "MaLoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbLoaiPhong.SelectedIndex = cmbLoaiPhong.Items.IndexOf(3);

            DataTable tinhtrang = traCuuPhongBLL.LoadTinhTrang();
            cmbTinhTrang.DataSource = tinhtrang;
            cmbTinhTrang.DisplayMember = "TenTinhTrang";
            cmbTinhTrang.ValueMember = "MaTinhTrang";

            cmbTinhTrang.SelectedIndex = cmbLoaiPhong.Items.IndexOf(3);

            DataTable dttracuu = traCuuPhongBLL.LoadTraCuu();
            dgvTraCuu.DataSource = dttracuu;


            TruyenDuLieuManHinh.p.TenPhong = dgvTraCuu.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            TruyenDuLieuManHinh.lp.LoaiPhong = dgvTraCuu.SelectedRows[0].Cells["TenLoaiPhong"].Value.ToString();
            TruyenDuLieuManHinh.lp.DonGia = float.Parse(dgvTraCuu.SelectedRows[0].Cells["DonGia"].Value.ToString());
            TruyenDuLieuManHinh.tt.TenTinhTrang = dgvTraCuu.SelectedRows[0].Cells["TenTinhTrang"].Value.ToString();
        }

        private void dgvTraCuu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TruyenDuLieuManHinh.p.TenPhong = dgvTraCuu.SelectedRows[0].Cells["TenPhong"].Value.ToString();
                TruyenDuLieuManHinh.lp.LoaiPhong = dgvTraCuu.SelectedRows[0].Cells["TenLoaiPhong"].Value.ToString();
                TruyenDuLieuManHinh.lp.DonGia = float.Parse(dgvTraCuu.SelectedRows[0].Cells["DonGia"].Value.ToString());
                TruyenDuLieuManHinh.tt.TenTinhTrang = dgvTraCuu.SelectedRows[0].Cells["TenTinhTrang"].Value.ToString();
            }
        }

       
    }
}
