
namespace Hotel_Management.GUI
{
    partial class Backup
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.trangthai = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backupbtn = new System.Windows.Forms.Button();
            this.browserbtn = new System.Windows.Forms.Button();
            this.pathtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 39);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sao Lưu Dữ Liệu";
            // 
            // trangthai
            // 
            this.trangthai.AutoSize = true;
            this.trangthai.Location = new System.Drawing.Point(202, 202);
            this.trangthai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(87, 13);
            this.trangthai.TabIndex = 31;
            this.trangthai.Text = "Chưa Hoạt Động";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(151, 202);
            this.state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(38, 13);
            this.state.TabIndex = 30;
            this.state.Text = "State: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(204, 141);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 26);
            this.progressBar1.TabIndex = 28;
            // 
            // backupbtn
            // 
            this.backupbtn.Enabled = false;
            this.backupbtn.Location = new System.Drawing.Point(401, 141);
            this.backupbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(73, 26);
            this.backupbtn.TabIndex = 27;
            this.backupbtn.Text = "Backup";
            this.backupbtn.UseVisualStyleBackColor = true;
            this.backupbtn.Click += new System.EventHandler(this.backupbtn_Click);
            // 
            // browserbtn
            // 
            this.browserbtn.Location = new System.Drawing.Point(401, 103);
            this.browserbtn.Margin = new System.Windows.Forms.Padding(2);
            this.browserbtn.Name = "browserbtn";
            this.browserbtn.Size = new System.Drawing.Size(73, 26);
            this.browserbtn.TabIndex = 26;
            this.browserbtn.Text = "Browse";
            this.browserbtn.UseVisualStyleBackColor = true;
            this.browserbtn.Click += new System.EventHandler(this.browserbtn_Click);
            // 
            // pathtxt
            // 
            this.pathtxt.Location = new System.Drawing.Point(208, 113);
            this.pathtxt.Margin = new System.Windows.Forms.Padding(2);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(172, 20);
            this.pathtxt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Location";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.backupbtn);
            this.Controls.Add(this.browserbtn);
            this.Controls.Add(this.pathtxt);
            this.Controls.Add(this.label1);
            this.Name = "Backup";
            this.Size = new System.Drawing.Size(665, 515);
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trangthai;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button backupbtn;
        private System.Windows.Forms.Button browserbtn;
        private System.Windows.Forms.TextBox pathtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
