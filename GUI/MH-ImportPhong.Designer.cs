namespace Hotel_Management
{
    partial class MH_ImportPhong
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.pathtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddCSDL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(344, 118);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 26);
            this.btnImport.TabIndex = 34;
            this.btnImport.Text = "Thêm phòng";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(344, 77);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(73, 26);
            this.btnBrowser.TabIndex = 33;
            this.btnBrowser.Text = "Browse";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // pathtxt
            // 
            this.pathtxt.Location = new System.Drawing.Point(156, 81);
            this.pathtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(177, 20);
            this.pathtxt.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Đường Dẫn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 39);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nạp File Excel Lên CSDL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvds);
            this.groupBox1.Location = new System.Drawing.Point(36, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 246);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // dgvds
            // 
            this.dgvds.AllowUserToAddRows = false;
            this.dgvds.AllowUserToDeleteRows = false;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.TenLoaiPhong,
            this.DonGia,
            this.TenTinhTrang});
            this.dgvds.Location = new System.Drawing.Point(6, 19);
            this.dgvds.MultiSelect = false;
            this.dgvds.Name = "dgvds";
            this.dgvds.ReadOnly = true;
            this.dgvds.RowHeadersWidth = 82;
            this.dgvds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvds.Size = new System.Drawing.Size(640, 221);
            this.dgvds.TabIndex = 0;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "Tên Phòng";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 10;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiPhong.DataPropertyName = "Loại Phòng";
            this.TenLoaiPhong.HeaderText = "Loại Phòng";
            this.TenLoaiPhong.MinimumWidth = 10;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "Đơn Giá";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 10;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TenTinhTrang
            // 
            this.TenTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTinhTrang.DataPropertyName = "Tình Trạng";
            this.TenTinhTrang.HeaderText = "Tình Trạng";
            this.TenTinhTrang.MinimumWidth = 10;
            this.TenTinhTrang.Name = "TenTinhTrang";
            this.TenTinhTrang.ReadOnly = true;
            // 
            // btnaddCSDL
            // 
            this.btnaddCSDL.Enabled = false;
            this.btnaddCSDL.Location = new System.Drawing.Point(580, 394);
            this.btnaddCSDL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnaddCSDL.Name = "btnaddCSDL";
            this.btnaddCSDL.Size = new System.Drawing.Size(102, 26);
            this.btnaddCSDL.TabIndex = 36;
            this.btnaddCSDL.Text = "Thêm vào CSDL";
            this.btnaddCSDL.UseVisualStyleBackColor = true;
            this.btnaddCSDL.Click += new System.EventHandler(this.btnaddCSDL_Click);
            // 
            // MH_ImportPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnaddCSDL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.pathtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MH_ImportPhong";
            this.Size = new System.Drawing.Size(737, 430);
            this.Load += new System.EventHandler(this.MH_ImportPhong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox pathtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTinhTrang;
        private System.Windows.Forms.Button btnaddCSDL;
    }
}
