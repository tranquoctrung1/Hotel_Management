
namespace Hotel_Management.GUI
{
    partial class Bao_Cao_Danh_Thu_Theo_Loai_Phong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.inputMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveCSLD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiPhong,
            this.DoanhThu,
            this.TiLe});
            this.dgvDoanhThu.Location = new System.Drawing.Point(38, 120);
            this.dgvDoanhThu.MultiSelect = false;
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 82;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(602, 241);
            this.dgvDoanhThu.TabIndex = 10;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 64.51613F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 10;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.FillWeight = 150F;
            this.MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            this.MaLoaiPhong.MinimumWidth = 10;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.ReadOnly = true;
            this.MaLoaiPhong.Width = 96;
            // 
            // DoanhThu
            // 
            this.DoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.FillWeight = 117.7419F;
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 10;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TiLe.DataPropertyName = "TiLe";
            this.TiLe.FillWeight = 117.7419F;
            this.TiLe.HeaderText = "Tỉ Lệ";
            this.TiLe.MinimumWidth = 10;
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(449, 60);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(118, 29);
            this.btnViewReport.TabIndex = 9;
            this.btnViewReport.Text = "Xem Báo Cáo";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // inputMonth
            // 
            this.inputMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMonth.Location = new System.Drawing.Point(208, 62);
            this.inputMonth.Name = "inputMonth";
            this.inputMonth.Size = new System.Drawing.Size(218, 27);
            this.inputMonth.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập tháng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "BÁO CÁO DOANH THU THEO LOẠI PHÒNG";
            // 
            // SaveCSLD
            // 
            this.SaveCSLD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCSLD.Location = new System.Drawing.Point(522, 376);
            this.SaveCSLD.Name = "SaveCSLD";
            this.SaveCSLD.Size = new System.Drawing.Size(118, 29);
            this.SaveCSLD.TabIndex = 11;
            this.SaveCSLD.Text = "Lưu Báo Cáo";
            this.SaveCSLD.UseVisualStyleBackColor = true;
            this.SaveCSLD.Click += new System.EventHandler(this.SaveCSLD_Click);
            // 
            // Bao_Cao_Danh_Thu_Theo_Loai_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.inputMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveCSLD);
            this.Name = "Bao_Cao_Danh_Thu_Theo_Loai_Phong";
            this.Size = new System.Drawing.Size(666, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.TextBox inputMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveCSLD;
    }
}
