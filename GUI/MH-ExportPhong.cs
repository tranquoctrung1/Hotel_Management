using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DTO;
using BLL;
using app = Microsoft.Office.Interop.Excel.Application;
using Hotel_Management.GUI;
using Hotel_Management.BLL;

namespace Hotel_Management
{
    public partial class MH_ExportPhong : UserControl
    {
        PhongDTO p = new PhongDTO();
        LoaiPhongDTO lp = new LoaiPhongDTO();
        LoaiTinhTrangDTO tt = new LoaiTinhTrangDTO();
        xlTraCuuPhongBLL traCuuPhongBLL = new xlTraCuuPhongBLL();

        public MH_ExportPhong()
        {
            InitializeComponent();
        }

        private void MH_ExportPhong_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dttracuu = traCuuPhongBLL.LoadTraCuu();
            dgvDanhSachPhong.DataSource = dttracuu;


            TruyenDuLieuManHinh.p.TenPhong = dgvDanhSachPhong.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            TruyenDuLieuManHinh.lp.LoaiPhong = dgvDanhSachPhong.SelectedRows[0].Cells["TenLoaiPhong"].Value.ToString();
            TruyenDuLieuManHinh.lp.DonGia = float.Parse(dgvDanhSachPhong.SelectedRows[0].Cells["DonGia"].Value.ToString());
            TruyenDuLieuManHinh.tt.TenTinhTrang = dgvDanhSachPhong.SelectedRows[0].Cells["TenTinhTrang"].Value.ToString();
        }

        private void ExportPhongExcel(DataGridView g, string duongdan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for(int i = 1; i<g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < g.Rows.Count; i++)
            {
                for(int j = 0; j<g.Columns.Count;j++)
                {
                    if(g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan+ tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string path= pathtxt.Text + @"\";
            ExportPhongExcel(dgvDanhSachPhong, path, txtFileName.Text);
            MessageBox.Show("Đã Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                pathtxt.Text = folderBrowser.SelectedPath;
                btnXuatFile.Enabled = true;
            }
        }
    }
}
