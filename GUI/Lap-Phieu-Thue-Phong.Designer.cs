
namespace Hotel_Management.GUI
{
    partial class Lap_Phieu_Thue_Phong
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
            this.DanhSachPhieuThuePhong = new System.Windows.Forms.DataGridView();
            this.sTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noteAmount = new System.Windows.Forms.Label();
            this.removeALineButton = new System.Windows.Forms.Button();
            this.addALineButton = new System.Windows.Forms.Button();
            this.ngayThuePhong = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhieuThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachPhieuThuePhong
            // 
            this.DanhSachPhieuThuePhong.AllowUserToAddRows = false;
            this.DanhSachPhieuThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachPhieuThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTT,
            this.MaKhachHang});
            this.DanhSachPhieuThuePhong.Location = new System.Drawing.Point(44, 155);
            this.DanhSachPhieuThuePhong.Name = "DanhSachPhieuThuePhong";
            this.DanhSachPhieuThuePhong.Size = new System.Drawing.Size(687, 261);
            this.DanhSachPhieuThuePhong.TabIndex = 14;
            // 
            // sTT
            // 
            this.sTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTT.DataPropertyName = "sTT";
            this.sTT.FillWeight = 20.30457F;
            this.sTT.HeaderText = "STT";
            this.sTT.Name = "sTT";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.FillWeight = 179.6954F;
            this.MaKhachHang.HeaderText = "Tên Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhachHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày Thuê Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "LẬP PHIẾU THUÊ PHÒNG";
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(114, 95);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(176, 21);
            this.cbMaPhong.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Phòng:";
            // 
            // noteAmount
            // 
            this.noteAmount.AutoSize = true;
            this.noteAmount.ForeColor = System.Drawing.Color.Red;
            this.noteAmount.Location = new System.Drawing.Point(481, 130);
            this.noteAmount.Name = "noteAmount";
            this.noteAmount.Size = new System.Drawing.Size(10, 13);
            this.noteAmount.TabIndex = 20;
            this.noteAmount.Text = " ";
            // 
            // removeALineButton
            // 
            this.removeALineButton.Location = new System.Drawing.Point(135, 126);
            this.removeALineButton.Name = "removeALineButton";
            this.removeALineButton.Size = new System.Drawing.Size(75, 23);
            this.removeALineButton.TabIndex = 19;
            this.removeALineButton.Text = "Xóa";
            this.removeALineButton.UseVisualStyleBackColor = true;
            this.removeALineButton.Click += new System.EventHandler(this.removeALineButton_Click);
            // 
            // addALineButton
            // 
            this.addALineButton.Location = new System.Drawing.Point(44, 126);
            this.addALineButton.Name = "addALineButton";
            this.addALineButton.Size = new System.Drawing.Size(75, 23);
            this.addALineButton.TabIndex = 18;
            this.addALineButton.Text = "Thêm";
            this.addALineButton.UseVisualStyleBackColor = true;
            this.addALineButton.Click += new System.EventHandler(this.addALineButton_Click);
            // 
            // ngayThuePhong
            // 
            this.ngayThuePhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayThuePhong.Location = new System.Drawing.Point(531, 98);
            this.ngayThuePhong.Name = "ngayThuePhong";
            this.ngayThuePhong.Size = new System.Drawing.Size(200, 20);
            this.ngayThuePhong.TabIndex = 17;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(154, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(44, 422);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Lập";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Lap_Phieu_Thue_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DanhSachPhieuThuePhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noteAmount);
            this.Controls.Add(this.removeALineButton);
            this.Controls.Add(this.addALineButton);
            this.Controls.Add(this.ngayThuePhong);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "Lap_Phieu_Thue_Phong";
            this.Size = new System.Drawing.Size(755, 485);
            this.Load += new System.EventHandler(this.Lap_Phieu_Thue_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhieuThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DanhSachPhieuThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noteAmount;
        private System.Windows.Forms.Button removeALineButton;
        private System.Windows.Forms.Button addALineButton;
        private System.Windows.Forms.DateTimePicker ngayThuePhong;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
    }
}
