using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;
using BLL;
using DTO;

namespace Hotel_Management.GUI
{
    public partial class MH_ImportKhachHang : UserControl
    {
        public MH_ImportKhachHang()
        {
            InitializeComponent();
        }
        ImportKhacHangBLL xl = new ImportKhacHangBLL();
        private void MH_ImportKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Select file";
                openDialog.InitialDirectory = @"c:\";
                openDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.RestoreDirectory = true;
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openDialog.FileName != "")
                    {
                        pathtxt.Text = openDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("chose Excel sheet path..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                btnImport.Enabled = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(pathtxt.Text))
            {
                using (FileStream stream = File.Open(pathtxt.Text, FileMode.Open, FileAccess.Read))
                {
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                        });

                        var item = result.Tables;
                        DataTable dt = item[0];
                        dgvds.DataSource = dt;
                        btnaddCSDL.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("No File is Selected");
            }
        }

        private void btnaddCSDL_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            LoaiKhachHangDTO lkh = new LoaiKhachHangDTO();
            int n = 0;
            if (dgvds.Rows.Count > 0)
            {
                
                foreach (DataGridViewRow row in dgvds.Rows)
                {
                    string MaKhachHangCuoi = xl.DuLieuMCuoiDanhSach();
                    int num = int.Parse(MaKhachHangCuoi.Substring(2)) + 1;
                    string MaKhachHang = "KH" + num.ToString("000");

                    kh.MaKhachHang = MaKhachHang;

                    kh.TenKhachHang = (row.Cells["TenKhachHang"].Value.ToString());
                    kh.CMND = (row.Cells["CMND"].Value.ToString());
                    kh.DiaChi = (row.Cells["DiaChi"].Value.ToString());
                    lkh.LoaiKhach= row.Cells["TenLoaiKhachHang"].Value.ToString();

                    DataTable loaiKhachHang = xl.DanhSachLoaiKhachHang();
                    



                    foreach (DataRow row1 in loaiKhachHang.Rows)
                    {

                        if (row1["TenLoaiKhach"].ToString() == lkh.LoaiKhach)
                        {
                            kh.MaLoaiKhachHang = row1["MaLoaiKhachHang"].ToString();
                        }
                    }


                    n += xl.ThemKhachHnag(kh);


                }
            }
            else
            {

            }
            if ( n< 0)
            {
                MessageBox.Show("Không Thêm Vào CSDL");
            }
            else
            {
                MessageBox.Show("Đã Thêm Vào CSDL");
            }
        }
    }
}
