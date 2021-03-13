namespace Hotel_Management.GUI
{
    partial class MH_BaoCao
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
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBaoCaoLoaiPhong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbThang1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMatDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbThang
            // 
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(220, 103);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(245, 24);
            this.cbbThang.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(114, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Chọn Tháng:";
            // 
            // btnBaoCaoLoaiPhong
            // 
            this.btnBaoCaoLoaiPhong.Location = new System.Drawing.Point(481, 93);
            this.btnBaoCaoLoaiPhong.Name = "btnBaoCaoLoaiPhong";
            this.btnBaoCaoLoaiPhong.Size = new System.Drawing.Size(133, 43);
            this.btnBaoCaoLoaiPhong.TabIndex = 19;
            this.btnBaoCaoLoaiPhong.Text = "Xuất Cáo Báo Theo Tháng Loại Phòng";
            this.btnBaoCaoLoaiPhong.UseVisualStyleBackColor = true;
            this.btnBaoCaoLoaiPhong.Click += new System.EventHandler(this.btnBaoCaoLoaiPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lập Phiếu Báo Cáo Danh Thu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(21, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Lập Phiếu Báo Cáo Mật Độ Sử Dụng Phòng";
            // 
            // cbbThang1
            // 
            this.cbbThang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbThang1.FormattingEnabled = true;
            this.cbbThang1.Location = new System.Drawing.Point(220, 282);
            this.cbbThang1.Name = "cbbThang1";
            this.cbbThang1.Size = new System.Drawing.Size(245, 24);
            this.cbbThang1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(114, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Chọn Tháng:";
            // 
            // btnMatDo
            // 
            this.btnMatDo.Location = new System.Drawing.Point(481, 269);
            this.btnMatDo.Name = "btnMatDo";
            this.btnMatDo.Size = new System.Drawing.Size(133, 49);
            this.btnMatDo.TabIndex = 25;
            this.btnMatDo.Text = "Xuất Cáo Báo Theo Tháng Loại Phòng";
            this.btnMatDo.UseVisualStyleBackColor = true;
            this.btnMatDo.Click += new System.EventHandler(this.btnMatDo_Click);
            // 
            // MH_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbThang1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMatDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBaoCaoLoaiPhong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MH_BaoCao";
            this.Size = new System.Drawing.Size(737, 430);
            this.Load += new System.EventHandler(this.MH_BaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBaoCaoLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThang1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMatDo;
    }
}
