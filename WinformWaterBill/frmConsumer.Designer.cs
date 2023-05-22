namespace WinformWaterBill
{
    partial class frmConsumer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbConsumer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtJdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btCSave = new System.Windows.Forms.Button();
            this.btCEdit = new System.Windows.Forms.Button();
            this.btCDelete = new System.Windows.Forms.Button();
            this.dgvConsumer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCSearch = new System.Windows.Forms.TextBox();
            this.btExcelkh = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptSearchidConsumer = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchidConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConsumer
            // 
            this.lbConsumer.AutoSize = true;
            this.lbConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbConsumer.Location = new System.Drawing.Point(1063, 68);
            this.lbConsumer.Name = "lbConsumer";
            this.lbConsumer.Size = new System.Drawing.Size(176, 32);
            this.lbConsumer.TabIndex = 40;
            this.lbConsumer.Text = "Khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(1294, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 41;
            this.label9.Text = "Nhân viên";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBill.Location = new System.Drawing.Point(1493, 68);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(128, 32);
            this.lbBill.TabIndex = 42;
            this.lbBill.Text = "Hóa đơn";
            this.lbBill.Click += new System.EventHandler(this.lbBill_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(1659, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 32);
            this.label11.TabIndex = 43;
            this.label11.Text = "Thống kê";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(56, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 46;
            this.label5.Text = "WDC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(79, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Họ và tên";
            // 
            // txtCName
            // 
            this.txtCName.BackColor = System.Drawing.Color.White;
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.ForeColor = System.Drawing.Color.Black;
            this.txtCName.Location = new System.Drawing.Point(84, 293);
            this.txtCName.Multiline = true;
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(341, 35);
            this.txtCName.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(79, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Địa chỉ";
            // 
            // txtCAdd
            // 
            this.txtCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCAdd.ForeColor = System.Drawing.Color.Black;
            this.txtCAdd.Location = new System.Drawing.Point(84, 392);
            this.txtCAdd.Multiline = true;
            this.txtCAdd.Name = "txtCAdd";
            this.txtCAdd.Size = new System.Drawing.Size(341, 106);
            this.txtCAdd.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(79, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Số điện thoại";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCPhone.Location = new System.Drawing.Point(84, 564);
            this.txtCPhone.Multiline = true;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(341, 35);
            this.txtCPhone.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(79, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mục đích sử dụng";
            // 
            // cbCCategory
            // 
            this.cbCCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCCategory.FormattingEnabled = true;
            this.cbCCategory.Items.AddRange(new object[] {
            "Gia đình",
            "Thương mại",
            "Kinh doanh"});
            this.cbCCategory.Location = new System.Drawing.Point(84, 669);
            this.cbCCategory.Name = "cbCCategory";
            this.cbCCategory.Size = new System.Drawing.Size(341, 37);
            this.cbCCategory.TabIndex = 54;
            this.cbCCategory.SelectionChangeCommitted += new System.EventHandler(this.cbCCategory_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(79, 737);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ngày sử dụng";
            // 
            // dtJdate
            // 
            this.dtJdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtJdate.Location = new System.Drawing.Point(84, 769);
            this.dtJdate.Name = "dtJdate";
            this.dtJdate.Size = new System.Drawing.Size(341, 34);
            this.dtJdate.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(79, 839);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Giá tiền";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.Black;
            this.txtRate.Location = new System.Drawing.Point(84, 871);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(341, 35);
            this.txtRate.TabIndex = 58;
            // 
            // btCSave
            // 
            this.btCSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCSave.ForeColor = System.Drawing.Color.White;
            this.btCSave.Location = new System.Drawing.Point(494, 360);
            this.btCSave.Name = "btCSave";
            this.btCSave.Size = new System.Drawing.Size(160, 55);
            this.btCSave.TabIndex = 59;
            this.btCSave.Text = "Thêm";
            this.btCSave.UseVisualStyleBackColor = false;
            this.btCSave.Click += new System.EventHandler(this.btCSave_Click);
            // 
            // btCEdit
            // 
            this.btCEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCEdit.ForeColor = System.Drawing.Color.White;
            this.btCEdit.Location = new System.Drawing.Point(494, 460);
            this.btCEdit.Name = "btCEdit";
            this.btCEdit.Size = new System.Drawing.Size(160, 55);
            this.btCEdit.TabIndex = 60;
            this.btCEdit.Text = "Sửa";
            this.btCEdit.UseVisualStyleBackColor = false;
            this.btCEdit.Click += new System.EventHandler(this.btCEdit_Click);
            // 
            // btCDelete
            // 
            this.btCDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCDelete.ForeColor = System.Drawing.Color.White;
            this.btCDelete.Location = new System.Drawing.Point(494, 564);
            this.btCDelete.Name = "btCDelete";
            this.btCDelete.Size = new System.Drawing.Size(160, 55);
            this.btCDelete.TabIndex = 61;
            this.btCDelete.Text = "Xóa";
            this.btCDelete.UseVisualStyleBackColor = false;
            this.btCDelete.Click += new System.EventHandler(this.btCDelete_Click);
            // 
            // dgvConsumer
            // 
            this.dgvConsumer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsumer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsumer.Location = new System.Drawing.Point(725, 218);
            this.dgvConsumer.Name = "dgvConsumer";
            this.dgvConsumer.RowHeadersWidth = 51;
            this.dgvConsumer.RowTemplate.Height = 24;
            this.dgvConsumer.Size = new System.Drawing.Size(1137, 707);
            this.dgvConsumer.TabIndex = 62;
            this.dgvConsumer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumer_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CId";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 99;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CName";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 199;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CAddress";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 199;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CPhone";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CCategory";
            this.Column5.HeaderText = "Mục đích sd";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CJDate";
            this.Column6.HeaderText = "Ngày sử dụng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CRate";
            this.Column7.HeaderText = "Giá tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // txtCSearch
            // 
            this.txtCSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSearch.ForeColor = System.Drawing.Color.Black;
            this.txtCSearch.Location = new System.Drawing.Point(951, 170);
            this.txtCSearch.Multiline = true;
            this.txtCSearch.Name = "txtCSearch";
            this.txtCSearch.Size = new System.Drawing.Size(257, 35);
            this.txtCSearch.TabIndex = 64;
            // 
            // btExcelkh
            // 
            this.btExcelkh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btExcelkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcelkh.ForeColor = System.Drawing.Color.White;
            this.btExcelkh.Location = new System.Drawing.Point(1596, 157);
            this.btExcelkh.Name = "btExcelkh";
            this.btExcelkh.Size = new System.Drawing.Size(224, 55);
            this.btExcelkh.TabIndex = 67;
            this.btExcelkh.Text = "Kết xuất Excel";
            this.btExcelkh.UseVisualStyleBackColor = false;
            this.btExcelkh.Click += new System.EventHandler(this.btExcelkh_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.Location = new System.Drawing.Point(494, 659);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(160, 55);
            this.btReset.TabIndex = 68;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinformWaterBill.Properties.Resources.x_in_red_circle_fk8QwI8u_thumb;
            this.pictureBox3.Location = new System.Drawing.Point(1890, 1009);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // ptSearchidConsumer
            // 
            this.ptSearchidConsumer.Image = global::WinformWaterBill.Properties.Resources.OIP__4_;
            this.ptSearchidConsumer.Location = new System.Drawing.Point(902, 170);
            this.ptSearchidConsumer.Name = "ptSearchidConsumer";
            this.ptSearchidConsumer.Size = new System.Drawing.Size(43, 35);
            this.ptSearchidConsumer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptSearchidConsumer.TabIndex = 80;
            this.ptSearchidConsumer.TabStop = false;
            this.ptSearchidConsumer.Click += new System.EventHandler(this.ptSearchidConsumer_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WinformWaterBill.Properties.Resources.OIP__2_;
            this.pictureBox6.Location = new System.Drawing.Point(1837, 1003);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 65;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformWaterBill.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-12, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformWaterBill.Properties.Resources.icon_khach_hang;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Consumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ptSearchidConsumer);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btExcelkh);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtCSearch);
            this.Controls.Add(this.dgvConsumer);
            this.Controls.Add(this.btCDelete);
            this.Controls.Add(this.btCEdit);
            this.Controls.Add(this.btCSave);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtJdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbConsumer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consumer";
            this.Text = "Consumer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchidConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsumer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtJdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btCSave;
        private System.Windows.Forms.Button btCEdit;
        private System.Windows.Forms.Button btCDelete;
        private System.Windows.Forms.DataGridView dgvConsumer;
        private System.Windows.Forms.TextBox txtCSearch;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btExcelkh;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox ptSearchidConsumer;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}