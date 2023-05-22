namespace WinformWaterBill
{
    partial class frmDashBoad
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbConsumer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNAgent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNCons = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMToatal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDashBoad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.btExcel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMoneymonth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbsokhoinuoc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ptExit = new System.Windows.Forms.PictureBox();
            this.ptSearchdate = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashBoad)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(51, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "WDC";
            // 
            // lbConsumer
            // 
            this.lbConsumer.AutoSize = true;
            this.lbConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbConsumer.Location = new System.Drawing.Point(998, 81);
            this.lbConsumer.Name = "lbConsumer";
            this.lbConsumer.Size = new System.Drawing.Size(176, 32);
            this.lbConsumer.TabIndex = 48;
            this.lbConsumer.Text = "Khách hàng";
            this.lbConsumer.Click += new System.EventHandler(this.lbConsumer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(1220, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "Nhân viên";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBill.Location = new System.Drawing.Point(1435, 81);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(128, 32);
            this.lbBill.TabIndex = 50;
            this.lbBill.Text = "Hóa đơn";
            this.lbBill.Click += new System.EventHandler(this.lbBill_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(1668, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 32);
            this.label11.TabIndex = 51;
            this.label11.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.lbNAgent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 155);
            this.panel1.TabIndex = 53;
            // 
            // lbNAgent
            // 
            this.lbNAgent.AutoSize = true;
            this.lbNAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNAgent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbNAgent.Location = new System.Drawing.Point(124, 75);
            this.lbNAgent.Name = "lbNAgent";
            this.lbNAgent.Size = new System.Drawing.Size(31, 32);
            this.lbNAgent.TabIndex = 37;
            this.lbNAgent.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.lbNCons);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(448, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 155);
            this.panel3.TabIndex = 38;
            // 
            // lbNCons
            // 
            this.lbNCons.AutoSize = true;
            this.lbNCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCons.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbNCons.Location = new System.Drawing.Point(124, 75);
            this.lbNCons.Name = "lbNCons";
            this.lbNCons.Size = new System.Drawing.Size(31, 32);
            this.lbNCons.TabIndex = 36;
            this.lbNCons.Text = "0";
            this.lbNCons.Click += new System.EventHandler(this.lbNCons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(80, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.lbMToatal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1627, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 155);
            this.panel2.TabIndex = 37;
            // 
            // lbMToatal
            // 
            this.lbMToatal.AutoSize = true;
            this.lbMToatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMToatal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbMToatal.Location = new System.Drawing.Point(88, 75);
            this.lbMToatal.Name = "lbMToatal";
            this.lbMToatal.Size = new System.Drawing.Size(48, 32);
            this.lbMToatal.TabIndex = 37;
            this.lbMToatal.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(77, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tổng tiền";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvDashBoad
            // 
            this.dgvDashBoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashBoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDashBoad.Location = new System.Drawing.Point(349, 533);
            this.dgvDashBoad.Name = "dgvDashBoad";
            this.dgvDashBoad.RowHeadersWidth = 51;
            this.dgvDashBoad.RowTemplate.Height = 24;
            this.dgvDashBoad.Size = new System.Drawing.Size(1285, 479);
            this.dgvDashBoad.TabIndex = 54;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BNum";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CId";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CName";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AgName";
            this.Column4.HeaderText = "Nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BPeriod";
            this.Column5.HeaderText = "Ngày thanh toán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Comsuption";
            this.Column6.HeaderText = "Số khối (dm^3)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Rate";
            this.Column7.HeaderText = "Giá tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Tax";
            this.Column8.HeaderText = "Thuế";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Total";
            this.Column9.HeaderText = "Tổng tiền";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // dtSearchDate
            // 
            this.dtSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearchDate.Location = new System.Drawing.Point(398, 489);
            this.dtSearchDate.Name = "dtSearchDate";
            this.dtSearchDate.Size = new System.Drawing.Size(261, 30);
            this.dtSearchDate.TabIndex = 58;
            // 
            // btExcel
            // 
            this.btExcel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcel.ForeColor = System.Drawing.Color.White;
            this.btExcel.Location = new System.Drawing.Point(1415, 477);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(219, 52);
            this.btExcel.TabIndex = 59;
            this.btExcel.Text = "Xuất  Excel";
            this.btExcel.UseVisualStyleBackColor = false;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Controls.Add(this.lbMoneymonth);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(1211, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 155);
            this.panel4.TabIndex = 38;
            // 
            // lbMoneymonth
            // 
            this.lbMoneymonth.AutoSize = true;
            this.lbMoneymonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneymonth.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbMoneymonth.Location = new System.Drawing.Point(95, 75);
            this.lbMoneymonth.Name = "lbMoneymonth";
            this.lbMoneymonth.Size = new System.Drawing.Size(48, 32);
            this.lbMoneymonth.TabIndex = 37;
            this.lbMoneymonth.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(77, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tiền ngày";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.lbsokhoinuoc);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(831, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 155);
            this.panel5.TabIndex = 39;
            // 
            // lbsokhoinuoc
            // 
            this.lbsokhoinuoc.AutoSize = true;
            this.lbsokhoinuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsokhoinuoc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbsokhoinuoc.Location = new System.Drawing.Point(128, 75);
            this.lbsokhoinuoc.Name = "lbsokhoinuoc";
            this.lbsokhoinuoc.Size = new System.Drawing.Size(31, 32);
            this.lbsokhoinuoc.TabIndex = 37;
            this.lbsokhoinuoc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(27, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 32);
            this.label7.TabIndex = 35;
            this.label7.Text = "Số nước sd(dm^3)";
            // 
            // ptExit
            // 
            this.ptExit.Image = global::WinformWaterBill.Properties.Resources.x_in_red_circle_fk8QwI8u_thumb;
            this.ptExit.Location = new System.Drawing.Point(1886, 981);
            this.ptExit.Name = "ptExit";
            this.ptExit.Size = new System.Drawing.Size(44, 62);
            this.ptExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptExit.TabIndex = 72;
            this.ptExit.TabStop = false;
            this.ptExit.Click += new System.EventHandler(this.ptExit_Click);
            // 
            // ptSearchdate
            // 
            this.ptSearchdate.Image = global::WinformWaterBill.Properties.Resources.OIP__4_2;
            this.ptSearchdate.Location = new System.Drawing.Point(349, 489);
            this.ptSearchdate.Name = "ptSearchdate";
            this.ptSearchdate.Size = new System.Drawing.Size(43, 30);
            this.ptSearchdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptSearchdate.TabIndex = 71;
            this.ptSearchdate.TabStop = false;
            this.ptSearchdate.Click += new System.EventHandler(this.ptSearchdate_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WinformWaterBill.Properties.Resources.OIP__2_;
            this.pictureBox6.Location = new System.Drawing.Point(1836, 981);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 60;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformWaterBill.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(1627, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformWaterBill.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-18, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(1135, 479);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(219, 52);
            this.btXoa.TabIndex = 73;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(864, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 52);
            this.button1.TabIndex = 74;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashBoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1040);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.ptExit);
            this.Controls.Add(this.ptSearchdate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.dtSearchDate);
            this.Controls.Add(this.dgvDashBoad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbConsumer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoad";
            this.Text = "DashBoad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashBoad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbConsumer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNCons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMToatal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDashBoad;
        private System.Windows.Forms.DateTimePicker dtSearchDate;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMoneymonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbsokhoinuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptSearchdate;
        private System.Windows.Forms.PictureBox ptExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button button1;
    }
}