
namespace Hotel_Management.GUI
{
    partial class MH_ReportView_BaoCaoMatDo
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
            this.CrytalView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrytalView
            // 
            this.CrytalView.ActiveViewIndex = -1;
            this.CrytalView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrytalView.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrytalView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrytalView.Location = new System.Drawing.Point(0, 0);
            this.CrytalView.Margin = new System.Windows.Forms.Padding(2);
            this.CrytalView.Name = "CrytalView";
            this.CrytalView.Size = new System.Drawing.Size(800, 450);
            this.CrytalView.TabIndex = 1;
            this.CrytalView.ToolPanelWidth = 100;
            // 
            // MH_ReportView_BaoCaoMatDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrytalView);
            this.Name = "MH_ReportView_BaoCaoMatDo";
            this.Text = "MH_ReportView_BaoCaoMatDo";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrytalView;
    }
}