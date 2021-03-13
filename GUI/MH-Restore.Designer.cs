
namespace Hotel_Management.GUI
{
    partial class MH_Restore
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
            this.trangthai = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.restorebtn = new System.Windows.Forms.Button();
            this.browsebtn2 = new System.Windows.Forms.Button();
            this.pathtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // trangthai
            // 
            this.trangthai.AutoSize = true;
            this.trangthai.Location = new System.Drawing.Point(190, 182);
            this.trangthai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(87, 13);
            this.trangthai.TabIndex = 41;
            this.trangthai.Text = "Chưa Hoạt Động";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(140, 182);
            this.state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(38, 13);
            this.state.TabIndex = 40;
            this.state.Text = "State: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(192, 121);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 26);
            this.progressBar1.TabIndex = 38;
            // 
            // restorebtn
            // 
            this.restorebtn.Enabled = false;
            this.restorebtn.Location = new System.Drawing.Point(385, 121);
            this.restorebtn.Margin = new System.Windows.Forms.Padding(2);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(73, 26);
            this.restorebtn.TabIndex = 37;
            this.restorebtn.Text = "ResTore";
            this.restorebtn.UseVisualStyleBackColor = true;
            this.restorebtn.Click += new System.EventHandler(this.restorebtn_Click);
            // 
            // browsebtn2
            // 
            this.browsebtn2.Location = new System.Drawing.Point(385, 83);
            this.browsebtn2.Margin = new System.Windows.Forms.Padding(2);
            this.browsebtn2.Name = "browsebtn2";
            this.browsebtn2.Size = new System.Drawing.Size(73, 26);
            this.browsebtn2.TabIndex = 36;
            this.browsebtn2.Text = "Browse";
            this.browsebtn2.UseVisualStyleBackColor = true;
            this.browsebtn2.Click += new System.EventHandler(this.browsebtn2_Click);
            // 
            // pathtxt
            // 
            this.pathtxt.Location = new System.Drawing.Point(192, 93);
            this.pathtxt.Margin = new System.Windows.Forms.Padding(2);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(177, 20);
            this.pathtxt.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phục Hồi Dữ Liệu";
            // 
            // MH_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.restorebtn);
            this.Controls.Add(this.browsebtn2);
            this.Controls.Add(this.pathtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "MH_Restore";
            this.Size = new System.Drawing.Size(549, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trangthai;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button restorebtn;
        private System.Windows.Forms.Button browsebtn2;
        private System.Windows.Forms.TextBox pathtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
