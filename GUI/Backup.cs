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
    public partial class Backup : UserControl
    {
        public Backup()
        {
            InitializeComponent();
        }
        xlBackupBLL xlBackup = new xlBackupBLL();
        private void browserbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathtxt.Text = dlg.SelectedPath;
                backupbtn.Enabled = true;
            }
        }

        private void backupbtn_Click(object sender, EventArgs e)
        {
            if (pathtxt.Text == string.Empty)
            {
                MessageBox.Show("Vui Long Nhan Duong Dan!");

            }
            else
            {

                xlBackup.xlBackup(pathtxt.Text);
                backupbtn.Enabled = false;
                progressBar1.PerformStep();
                timer1.Start();
                label3.Text = progressBar1.Value.ToString();
                if (progressBar1.Value.ToString() == "10")
                {
                    trangthai.Text = "Đã Backup Thành Công";
                }
                else
                {
                    trangthai.Text = "Đang Backup";
                }
               
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label3.Text = progressBar1.Value.ToString();
            if (progressBar1.Value.ToString() == "100")
            {
                trangthai.Text = "Đã Backup Thành Công";
            }
            else
            {
                trangthai.Text = "Đang Backup";
            }
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }
    }
}
