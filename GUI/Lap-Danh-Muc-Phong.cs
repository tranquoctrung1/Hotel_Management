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
using BLL;

namespace Hotel_Management.GUI
{
    public partial class Lap_Danh_Muc_Phong : UserControl
    {
        public Lap_Danh_Muc_Phong()
        {
            InitializeComponent();
        }

        LoaiPhongBLL loaiPhongBLL = new LoaiPhongBLL();
        LoaiTinhTrangBLL loaiTinhTrangBLL = new LoaiTinhTrangBLL();
        LapDanhMucPhongBLL lapDanhMucPhongBLL = new LapDanhMucPhongBLL();
        int index = 0;

       

        private void Lap_Danh_Muc_Phong_Load_1(object sender, EventArgs e)
        {
            DanhSachThemPhong.Rows.Add(1);
            loadData();
        }

        private void loadData()
        {
            DanhSachThemPhong.Rows[index].Cells[0].Value = index + 1;
            DanhSachThemPhong.Rows[index].Cells[1].Value = "";
            DanhSachThemPhong.Rows[index].Cells[2].Value = "";
            DanhSachThemPhong.Rows[index].Cells[5].Value = "";
            DataGridViewComboBoxCell cbLoaiPhong = DanhSachThemPhong.Rows[index].Cells[3] as DataGridViewComboBoxCell;
            DataGridViewComboBoxCell cbTinhTrang = DanhSachThemPhong.Rows[index].Cells[4] as DataGridViewComboBoxCell;

            cbLoaiPhong.DataSource = loaiPhongBLL.loadLoaiPhong();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "MaLoaiPhong";

            cbTinhTrang.DataSource = loaiTinhTrangBLL.loadLoaiTinhTrang();
            cbTinhTrang.DisplayMember = "TenTinhTrang";
            cbTinhTrang.ValueMember = "MaTinhTrang";

            index++;
        }

        private void addALineButton1_Click(object sender, EventArgs e)
        {
            DanhSachThemPhong.Rows.Add(1);
            loadData();
        }

        private void removeALineButton1_Click(object sender, EventArgs e)
        {
            int select = DanhSachThemPhong.Rows.Count;
            select = DanhSachThemPhong.SelectedCells[0].RowIndex;

            DanhSachThemPhong.Rows.RemoveAt(select);
            index--;
        }

     

        private void addButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DanhSachThemPhong.Rows.Count; i++)
            {
                PhongDTO phong = new PhongDTO();

                for(int j= 1; j < 6;j++)
                {
                    if(String.IsNullOrEmpty(DanhSachThemPhong.Rows[i].Cells[j].Value.ToString()))
                    {
                        MessageBox.Show("Không được bỏ trống dữ liệu", "THÔNG BÁO");
                        return;
                    }
                }

                phong.MaPhong = DanhSachThemPhong.Rows[i].Cells[1].Value.ToString();
                phong.TenPhong = DanhSachThemPhong.Rows[i].Cells[2].Value.ToString();
                phong.MaLoaiPhong = DanhSachThemPhong.Rows[i].Cells[3].Value.ToString();
                phong.TinhTrang = DanhSachThemPhong.Rows[i].Cells[4].Value.ToString();
                phong.GhiChu = DanhSachThemPhong.Rows[i].Cells[5].Value.ToString();

                if (lapDanhMucPhongBLL.KiemTraMaPhong(phong.MaPhong) == false)
                {
                    MessageBox.Show("Phòng " + i + 1 + " bị trùng mã phòng");
                }
                else if (lapDanhMucPhongBLL.KiemTraTrongDuLieu(phong) == false)
                {
                    MessageBox.Show("Dòng " + i + 1 + " có dữ liệu trống");
                }
                else
                {
                    lapDanhMucPhongBLL.ThemPhong(phong);
                    DanhSachThemPhong.Rows.RemoveAt(i);
                    MessageBox.Show("Thêm phòng thành công!");
                }
            }
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            DanhSachThemPhong.Rows.Clear();
            index = 0;
        }

        private void removeALineButton_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                int select = DanhSachThemPhong.Rows.Count;
                select = DanhSachThemPhong.SelectedCells[0].RowIndex;

                DanhSachThemPhong.Rows.RemoveAt(select);
                index--;
            }    
        }
    }
}
