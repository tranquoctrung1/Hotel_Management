
namespace Hotel_Management.GUI
{
    partial class Lap_Hoa_Don
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
            this.addRoomButton = new System.Windows.Forms.Button();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ngayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongGiaTri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachPhongThanhToan = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhongThanhToan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(621, 73);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 48;
            this.addRoomButton.Text = "Thêm Phòng";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(359, 44);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(132, 21);
            this.cbMaPhong.TabIndex = 46;
            this.cbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbMaPhong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tên Phòng:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ngayThanhToan
            // 
            this.ngayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayThanhToan.Location = new System.Drawing.Point(114, 41);
            this.ngayThanhToan.Name = "ngayThanhToan";
            this.ngayThanhToan.Size = new System.Drawing.Size(144, 20);
            this.ngayThanhToan.TabIndex = 44;
            this.ngayThanhToan.ValueChanged += new System.EventHandler(this.ngayThanhToan_ValueChanged);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(359, 73);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(132, 21);
            this.cbKhachHang.TabIndex = 43;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Location = new System.Drawing.Point(600, 385);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(99, 28);
            this.btnLapHoaDon.TabIndex = 42;
            this.btnLapHoaDon.Text = "LẬP HÓA ĐƠN";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(19, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "TỔNG GIÁ TRỊ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTongGiaTri
            // 
            this.txtTongGiaTri.Enabled = false;
            this.txtTongGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongGiaTri.ForeColor = System.Drawing.Color.Red;
            this.txtTongGiaTri.Location = new System.Drawing.Point(139, 384);
            this.txtTongGiaTri.Name = "txtTongGiaTri";
            this.txtTongGiaTri.Size = new System.Drawing.Size(136, 26);
            this.txtTongGiaTri.TabIndex = 40;
            this.txtTongGiaTri.TextChanged += new System.EventHandler(this.txtTongGiaTri_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(497, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "* Chọn mã khách hàng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.FillWeight = 112.3096F;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 10;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 112.3096F;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 10;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoNgayThue.DataPropertyName = "SoNgayThue";
            this.SoNgayThue.HeaderText = "Số Ngày Thuê";
            this.SoNgayThue.MinimumWidth = 10;
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.ReadOnly = true;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBatDau.DataPropertyName = "NgayThue";
            this.NgayBatDau.FillWeight = 112.3096F;
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu Thuê";
            this.NgayBatDau.MinimumWidth = 10;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.FillWeight = 112.3096F;
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 10;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 10;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // sTT
            // 
            this.sTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTT.DataPropertyName = "sTT";
            this.sTT.FillWeight = 50.76142F;
            this.sTT.HeaderText = "STT";
            this.sTT.MinimumWidth = 10;
            this.sTT.Name = "sTT";
            this.sTT.ReadOnly = true;
            // 
            // dgvDanhSachPhongThanhToan
            // 
            this.dgvDanhSachPhongThanhToan.AllowUserToAddRows = false;
            this.dgvDanhSachPhongThanhToan.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhongThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhongThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTT,
            this.MaPhong,
            this.TenPhong,
            this.NgayBatDau,
            this.SoNgayThue,
            this.DonGia,
            this.ThanhTien});
            this.dgvDanhSachPhongThanhToan.Location = new System.Drawing.Point(6, 16);
            this.dgvDanhSachPhongThanhToan.Name = "dgvDanhSachPhongThanhToan";
            this.dgvDanhSachPhongThanhToan.ReadOnly = true;
            this.dgvDanhSachPhongThanhToan.RowHeadersWidth = 82;
            this.dgvDanhSachPhongThanhToan.Size = new System.Drawing.Size(665, 253);
            this.dgvDanhSachPhongThanhToan.TabIndex = 1;
            this.dgvDanhSachPhongThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhongThanhToan_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(497, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "* Chọn phòng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachPhongThanhToan);
            this.groupBox2.Location = new System.Drawing.Point(19, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 275);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng khách hàng thanh toán";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên khách hàng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ngày thanh toán:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(13, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lập Hóa Đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lap_Hoa_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ngayThanhToan);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongGiaTri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Lap_Hoa_Don";
            this.Size = new System.Drawing.Size(724, 458);
            this.Load += new System.EventHandler(this.Lap_Hoa_Don_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhongThanhToan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ngayThanhToan;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongGiaTri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTT;
        private System.Windows.Forms.DataGridView dgvDanhSachPhongThanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
