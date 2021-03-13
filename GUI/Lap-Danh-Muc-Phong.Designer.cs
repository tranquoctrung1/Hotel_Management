namespace Hotel_Management.GUI
{
    partial class Lap_Danh_Muc_Phong
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
            this.DanhSachThemPhong = new System.Windows.Forms.DataGridView();
            this.sTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.addALineButton1 = new System.Windows.Forms.Button();
            this.removeALineButton1 = new System.Windows.Forms.Button();
            this.cancelButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachThemPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachThemPhong
            // 
            this.DanhSachThemPhong.AllowUserToAddRows = false;
            this.DanhSachThemPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachThemPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTT,
            this.MaPhong,
            this.TenPhong,
            this.MaLoaiPhong,
            this.TinhTrang,
            this.GhiChu});
            this.DanhSachThemPhong.Location = new System.Drawing.Point(50, 141);
            this.DanhSachThemPhong.Margin = new System.Windows.Forms.Padding(6);
            this.DanhSachThemPhong.Name = "DanhSachThemPhong";
            this.DanhSachThemPhong.RowHeadersWidth = 82;
            this.DanhSachThemPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DanhSachThemPhong.Size = new System.Drawing.Size(666, 222);
            this.DanhSachThemPhong.TabIndex = 2;
            // 
            // sTT
            // 
            this.sTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTT.DataPropertyName = "sTT";
            this.sTT.FillWeight = 74.79124F;
            this.sTT.HeaderText = "STT";
            this.sTT.MinimumWidth = 10;
            this.sTT.Name = "sTT";
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 89.50876F;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 10;
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.FillWeight = 89.50876F;
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 10;
            this.TenPhong.Name = "TenPhong";
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.FillWeight = 177.665F;
            this.MaLoaiPhong.HeaderText = "Tên Loại Phòng";
            this.MaLoaiPhong.MinimumWidth = 10;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoaiPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.FillWeight = 89.50876F;
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 10;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 89.50876F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 10;
            this.GhiChu.Name = "GhiChu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "LẬP DANH MỤC PHÒNG";
            // 
            // addALineButton1
            // 
            this.addALineButton1.Location = new System.Drawing.Point(50, 105);
            this.addALineButton1.Name = "addALineButton1";
            this.addALineButton1.Size = new System.Drawing.Size(87, 27);
            this.addALineButton1.TabIndex = 4;
            this.addALineButton1.Text = "Thêm Phòng";
            this.addALineButton1.UseVisualStyleBackColor = true;
            this.addALineButton1.Click += new System.EventHandler(this.addALineButton1_Click);
            // 
            // removeALineButton1
            // 
            this.removeALineButton1.Location = new System.Drawing.Point(153, 105);
            this.removeALineButton1.Name = "removeALineButton1";
            this.removeALineButton1.Size = new System.Drawing.Size(88, 27);
            this.removeALineButton1.TabIndex = 5;
            this.removeALineButton1.Text = "Xóa Phòng";
            this.removeALineButton1.UseVisualStyleBackColor = true;
            this.removeALineButton1.Click += new System.EventHandler(this.removeALineButton1_Click);
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(620, 373);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(96, 26);
            this.cancelButton1.TabIndex = 7;
            this.cancelButton1.Text = "Hủy";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(514, 372);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(100, 27);
            this.addButton1.TabIndex = 6;
            this.addButton1.Text = "Lập";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // Lap_Danh_Muc_Phong
            // 
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.removeALineButton1);
            this.Controls.Add(this.addALineButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DanhSachThemPhong);
            this.Name = "Lap_Danh_Muc_Phong";
            this.Size = new System.Drawing.Size(743, 430);
            this.Load += new System.EventHandler(this.Lap_Danh_Muc_Phong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachThemPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button cancelButton;
        //private System.Windows.Forms.Button addButton;
        //private System.Windows.Forms.Button removeALineButton;
        //private System.Windows.Forms.Button addALineButton;

        private System.Windows.Forms.DataGridView DanhSachThemPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addALineButton1;
        private System.Windows.Forms.Button removeALineButton1;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}
