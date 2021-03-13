using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using ExcelDataReader;
using BLL;
using DTO;

namespace Hotel_Management
{
    public partial class MH_ImportPhong : UserControl
    {
        public MH_ImportPhong()
        {
            InitializeComponent();
        }
        ImportPhongBLL xl = new ImportPhongBLL();
        private void BtnBrowser_Click(object sender, EventArgs e)
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
        DataTable dt = new DataTable();
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
            PhongDTO p = new PhongDTO();
            LoaiPhongDTO lp = new LoaiPhongDTO();
            LoaiTinhTrangDTO ltt = new LoaiTinhTrangDTO();


            int n = 0;




            if (dgvds.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dgvds.Rows)
                {
                    string MaPhongCuoi = xl.DuLieuMCuoiDanhSach();
                    int num = int.Parse(MaPhongCuoi.Substring(1)) + 1;
                    string MaPhong = "P" + num.ToString();

                    p.MaPhong = MaPhong;
                    p.TenPhong = (row.Cells["TenPhong"].Value.ToString());
                    lp.TenLoaiPhong = (row.Cells["TenLoaiPhong"].Value.ToString());
                    lp.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                    ltt.TenTinhTrang = (row.Cells["TenTinhTrang"].Value.ToString());
                    DataTable loaiphong = xl.DanhSachLoaiPhong();
                    DataTable loaitinhtrang = xl.DanhSachLoaiTinhTrang();



                    foreach (DataRow row1 in loaiphong.Rows)
                    {

                        if (row1["TenLoaiPhong"].ToString() == lp.TenLoaiPhong)
                        {
                            p.MaLoaiPhong = row1["MaLoaiPhong"].ToString();
                        }
                    }

                    foreach (DataRow row2 in loaitinhtrang.Rows)
                    {

                        if (row2["TenTinhTrang"].ToString() == ltt.TenTinhTrang)
                        {
                            p.MaLoaiTinhTrang = row2["MaTinhTrang"].ToString();
                        }
                    }


                    n = xl.ThemPhong(p);
                }
            }
            else
            {

            }
            if (n < 0)
            {
                MessageBox.Show("Không Thêm Vào CSDL");
            }
            else
            {
                MessageBox.Show("Đã Thêm Vào CSDL");
            }
        }

        private void MH_ImportPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
