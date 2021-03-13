using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Hotel_Management.GUI
{
    public partial class MH_ExportKhachHang : UserControl
    {
        xlExportBLL BLLExport = new xlExportBLL();
        public MH_ExportKhachHang()
        {
            InitializeComponent();
        }

        private void MH_ExportKhachHang_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dgvKhachHang = BLLExport.LoadKhachHang();
            dgvDanhSachKhachHang.DataSource = dgvKhachHang;


            TruyenDuLieuManHinh.kh.MaKhachHang = dgvDanhSachKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            TruyenDuLieuManHinh.kh.TenKhachHang = dgvDanhSachKhachHang.SelectedRows[0].Cells["TenKhachHang"].Value.ToString();
            TruyenDuLieuManHinh.kh.CMND = dgvDanhSachKhachHang.SelectedRows[0].Cells["CMND"].Value.ToString();
            TruyenDuLieuManHinh.kh.DiaChi = dgvDanhSachKhachHang.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            TruyenDuLieuManHinh.lkh.LoaiKhach = dgvDanhSachKhachHang.SelectedRows[0].Cells["TenLoaiKhach"].Value.ToString();



        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                pathtxt.Text = folderBrowser.SelectedPath;
                btnXuatFile.Enabled = true;
            }
        }

        private void ExportPhongExcel(DataGridView g, string duongdan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string path = pathtxt.Text + @"\";
            ExportPhongExcel(dgvDanhSachKhachHang, path, txtFileName.Text);
            MessageBox.Show("Đã Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
