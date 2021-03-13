namespace Hotel_Management
{
    partial class MH_ReportView_BaoCaoDanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrytalViewBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrytalViewBaoCao
            // 
            this.CrytalViewBaoCao.ActiveViewIndex = -1;
            this.CrytalViewBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrytalViewBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrytalViewBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrytalViewBaoCao.Location = new System.Drawing.Point(0, 0);
            this.CrytalViewBaoCao.Name = "CrytalViewBaoCao";
            this.CrytalViewBaoCao.Size = new System.Drawing.Size(1600, 865);
            this.CrytalViewBaoCao.TabIndex = 0;
            // 
            // MH_ReportView_BaoCaoDanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.CrytalViewBaoCao);
            this.Name = "MH_ReportView_BaoCaoDanhThu";
            this.Text = "MH_ReportView_BaoCaoDanhThu";
            this.Load += new System.EventHandler(this.MH_ReportView_BaoCaoDanhThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrytalViewBaoCao;
    }
}