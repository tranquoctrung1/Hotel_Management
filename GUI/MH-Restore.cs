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
    public partial class MH_Restore : UserControl
    {
        public MH_Restore()
        {
            InitializeComponent();
        }
        xlRetoreBLL XlRetore = new xlRetoreBLL();
        private void browsebtn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathtxt.Text = dlg.FileName;
                restorebtn.Enabled = true;
            }
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            if (pathtxt.Text == string.Empty)
            {
                MessageBox.Show("Them Duong Dan De Phuc Hoi");

            }
            else
            {
                XlRetore.xlRetore(pathtxt.Text);
                timer1.Start();
                restorebtn.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label3.Text = progressBar1.Value.ToString();
            if (progressBar1.Value.ToString() == "100")
            {
                trangthai.Text = "Đã Restore Thành Công";
            }
            else
            {
                trangthai.Text = "Đang Restore";
            }
        }
    }
}
