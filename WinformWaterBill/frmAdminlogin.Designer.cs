namespace WinformWaterBill
{
    partial class frmAdminlogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassloginadmin = new System.Windows.Forms.TextBox();
            this.btLoginadmin = new System.Windows.Forms.Button();
            this.lblogin = new System.Windows.Forms.Label();
            this.btThongke = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 109);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(466, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(211, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "WDC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformWaterBill.Properties.Resources.vòi_nước;
            this.pictureBox1.Location = new System.Drawing.Point(191, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(155, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mật khẩu";
            // 
            // txtPassloginadmin
            // 
            this.txtPassloginadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassloginadmin.Location = new System.Drawing.Point(155, 328);
            this.txtPassloginadmin.Multiline = true;
            this.txtPassloginadmin.Name = "txtPassloginadmin";
            this.txtPassloginadmin.PasswordChar = '*';
            this.txtPassloginadmin.Size = new System.Drawing.Size(223, 35);
            this.txtPassloginadmin.TabIndex = 14;
            // 
            // btLoginadmin
            // 
            this.btLoginadmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btLoginadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoginadmin.ForeColor = System.Drawing.Color.White;
            this.btLoginadmin.Location = new System.Drawing.Point(85, 411);
            this.btLoginadmin.Name = "btLoginadmin";
            this.btLoginadmin.Size = new System.Drawing.Size(136, 45);
            this.btLoginadmin.TabIndex = 15;
            this.btLoginadmin.Text = "Quản lý";
            this.btLoginadmin.UseVisualStyleBackColor = false;
            this.btLoginadmin.Click += new System.EventHandler(this.btLoginadmin_Click);
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblogin.Location = new System.Drawing.Point(233, 475);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(47, 16);
            this.lblogin.TabIndex = 16;
            this.lblogin.Text = "Thoát";
            this.lblogin.Click += new System.EventHandler(this.lblogin_Click);
            // 
            // btThongke
            // 
            this.btThongke.BackColor = System.Drawing.Color.DodgerBlue;
            this.btThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongke.ForeColor = System.Drawing.Color.White;
            this.btThongke.Location = new System.Drawing.Point(281, 411);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(136, 45);
            this.btThongke.TabIndex = 17;
            this.btThongke.Text = "Thống kê";
            this.btThongke.UseVisualStyleBackColor = false;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // Adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 546);
            this.Controls.Add(this.btThongke);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.btLoginadmin);
            this.Controls.Add(this.txtPassloginadmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminlogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassloginadmin;
        private System.Windows.Forms.Button btLoginadmin;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThongke;
    }
}