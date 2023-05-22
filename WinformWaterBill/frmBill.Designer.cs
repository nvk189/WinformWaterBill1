namespace WinformWaterBill
{
    partial class frmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.label5 = new System.Windows.Forms.Label();
            this.lbConsumer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCID = new System.Windows.Forms.Label();
            this.txtBCName = new System.Windows.Forms.TextBox();
            this.cbBCID = new System.Windows.Forms.ComboBox();
            this.lbCName = new System.Windows.Forms.Label();
            this.lbAgentName = new System.Windows.Forms.Label();
            this.lbBPeriod = new System.Windows.Forms.Label();
            this.lbConsuption = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtBConsupion = new System.Windows.Forms.TextBox();
            this.txtBRate = new System.Windows.Forms.TextBox();
            this.txtBTax = new System.Windows.Forms.TextBox();
            this.txtBTotal = new System.Windows.Forms.TextBox();
            this.dtBPeriod = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.BNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSave = new System.Windows.Forms.Button();
            this.rtpReceipt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btReceipt = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.txtBSearch = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cbBAgName = new System.Windows.Forms.ComboBox();
            this.btReset = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptSearchidbill = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchidbill)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(54, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "WDC";
            // 
            // lbConsumer
            // 
            this.lbConsumer.AutoSize = true;
            this.lbConsumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbConsumer.Location = new System.Drawing.Point(750, 65);
            this.lbConsumer.Name = "lbConsumer";
            this.lbConsumer.Size = new System.Drawing.Size(176, 32);
            this.lbConsumer.TabIndex = 39;
            this.lbConsumer.Text = "Khách hàng";
            this.lbConsumer.Click += new System.EventHandler(this.lbConsumer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(957, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nhân viên";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBill.Location = new System.Drawing.Point(1198, 65);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(128, 32);
            this.lbBill.TabIndex = 41;
            this.lbBill.Text = "Hóa đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(1355, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 32);
            this.label11.TabIndex = 42;
            this.label11.Text = "Thống kê";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCID.Location = new System.Drawing.Point(36, 131);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(174, 29);
            this.lbCID.TabIndex = 44;
            this.lbCID.Text = "Mã khách hàng";
            // 
            // txtBCName
            // 
            this.txtBCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCName.ForeColor = System.Drawing.Color.Black;
            this.txtBCName.Location = new System.Drawing.Point(41, 243);
            this.txtBCName.Multiline = true;
            this.txtBCName.Name = "txtBCName";
            this.txtBCName.ReadOnly = true;
            this.txtBCName.Size = new System.Drawing.Size(296, 41);
            this.txtBCName.TabIndex = 45;
            // 
            // cbBCID
            // 
            this.cbBCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBCID.ForeColor = System.Drawing.Color.Black;
            this.cbBCID.FormattingEnabled = true;
            this.cbBCID.Location = new System.Drawing.Point(38, 163);
            this.cbBCID.Name = "cbBCID";
            this.cbBCID.Size = new System.Drawing.Size(296, 37);
            this.cbBCID.TabIndex = 46;
            this.cbBCID.SelectionChangeCommitted += new System.EventHandler(this.cbBCID_SelectionChangeCommitted);
            // 
            // lbCName
            // 
            this.lbCName.AutoSize = true;
            this.lbCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCName.Location = new System.Drawing.Point(36, 211);
            this.lbCName.Name = "lbCName";
            this.lbCName.Size = new System.Drawing.Size(184, 29);
            this.lbCName.TabIndex = 47;
            this.lbCName.Text = "Tên khách hàng";
            // 
            // lbAgentName
            // 
            this.lbAgentName.AutoSize = true;
            this.lbAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgentName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbAgentName.Location = new System.Drawing.Point(36, 301);
            this.lbAgentName.Name = "lbAgentName";
            this.lbAgentName.Size = new System.Drawing.Size(164, 29);
            this.lbAgentName.TabIndex = 49;
            this.lbAgentName.Text = "Tên nhân viên";
            // 
            // lbBPeriod
            // 
            this.lbBPeriod.AutoSize = true;
            this.lbBPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBPeriod.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBPeriod.Location = new System.Drawing.Point(36, 405);
            this.lbBPeriod.Name = "lbBPeriod";
            this.lbBPeriod.Size = new System.Drawing.Size(185, 29);
            this.lbBPeriod.TabIndex = 50;
            this.lbBPeriod.Text = "Ngày thanh toán";
            // 
            // lbConsuption
            // 
            this.lbConsuption.AutoSize = true;
            this.lbConsuption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsuption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbConsuption.Location = new System.Drawing.Point(36, 478);
            this.lbConsuption.Name = "lbConsuption";
            this.lbConsuption.Size = new System.Drawing.Size(226, 29);
            this.lbConsuption.TabIndex = 51;
            this.lbConsuption.Text = "Số khối nước(dm^3)";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbRate.Location = new System.Drawing.Point(36, 554);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(95, 29);
            this.lbRate.TabIndex = 52;
            this.lbRate.Text = "Giá tiền";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTax.Location = new System.Drawing.Point(40, 636);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(69, 29);
            this.lbTax.TabIndex = 53;
            this.lbTax.Text = "Thuế";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTotal.Location = new System.Drawing.Point(40, 729);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(115, 29);
            this.lbTotal.TabIndex = 54;
            this.lbTotal.Text = "Tổng tiền";
            // 
            // txtBConsupion
            // 
            this.txtBConsupion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBConsupion.ForeColor = System.Drawing.Color.Black;
            this.txtBConsupion.Location = new System.Drawing.Point(41, 510);
            this.txtBConsupion.Multiline = true;
            this.txtBConsupion.Name = "txtBConsupion";
            this.txtBConsupion.Size = new System.Drawing.Size(296, 41);
            this.txtBConsupion.TabIndex = 59;
            // 
            // txtBRate
            // 
            this.txtBRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBRate.ForeColor = System.Drawing.Color.Black;
            this.txtBRate.Location = new System.Drawing.Point(41, 586);
            this.txtBRate.Multiline = true;
            this.txtBRate.Name = "txtBRate";
            this.txtBRate.ReadOnly = true;
            this.txtBRate.Size = new System.Drawing.Size(296, 41);
            this.txtBRate.TabIndex = 60;
            // 
            // txtBTax
            // 
            this.txtBTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTax.ForeColor = System.Drawing.Color.Black;
            this.txtBTax.Location = new System.Drawing.Point(45, 668);
            this.txtBTax.Multiline = true;
            this.txtBTax.Name = "txtBTax";
            this.txtBTax.Size = new System.Drawing.Size(296, 41);
            this.txtBTax.TabIndex = 61;
            // 
            // txtBTotal
            // 
            this.txtBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTotal.ForeColor = System.Drawing.Color.Black;
            this.txtBTotal.Location = new System.Drawing.Point(41, 761);
            this.txtBTotal.Multiline = true;
            this.txtBTotal.Name = "txtBTotal";
            this.txtBTotal.ReadOnly = true;
            this.txtBTotal.Size = new System.Drawing.Size(296, 41);
            this.txtBTotal.TabIndex = 62;
            // 
            // dtBPeriod
            // 
            this.dtBPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBPeriod.Location = new System.Drawing.Point(45, 441);
            this.dtBPeriod.Name = "dtBPeriod";
            this.dtBPeriod.Size = new System.Drawing.Size(296, 34);
            this.dtBPeriod.TabIndex = 63;
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BNum,
            this.CId,
            this.CName,
            this.AgName,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.Location = new System.Drawing.Point(554, 227);
            this.dgvBill.Name = "dgvBill";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(633, 557);
            this.dgvBill.TabIndex = 64;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // BNum
            // 
            this.BNum.DataPropertyName = "BNum";
            this.BNum.HeaderText = " ID ";
            this.BNum.MinimumWidth = 6;
            this.BNum.Name = "BNum";
            this.BNum.Width = 125;
            // 
            // CId
            // 
            this.CId.DataPropertyName = "CId";
            this.CId.HeaderText = "Mã khách hàng";
            this.CId.MinimumWidth = 6;
            this.CId.Name = "CId";
            this.CId.Width = 180;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "Tên khách hàng";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.Width = 180;
            // 
            // AgName
            // 
            this.AgName.DataPropertyName = "AgName";
            this.AgName.HeaderText = "Tên nhân viên";
            this.AgName.MinimumWidth = 6;
            this.AgName.Name = "AgName";
            this.AgName.Width = 160;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BPeriod";
            this.Column6.HeaderText = "Ngày thanh toán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Comsuption";
            this.Column7.HeaderText = "Số khối nước";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 160;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Rate";
            this.Column8.HeaderText = "Giá tiền";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Tax";
            this.Column9.HeaderText = "Thuế";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Total";
            this.Column10.HeaderText = "Tổng tiền";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(368, 269);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(169, 47);
            this.btSave.TabIndex = 65;
            this.btSave.Text = "Thêm";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // rtpReceipt
            // 
            this.rtpReceipt.Location = new System.Drawing.Point(1204, 227);
            this.rtpReceipt.Name = "rtpReceipt";
            this.rtpReceipt.Size = new System.Drawing.Size(291, 499);
            this.rtpReceipt.TabIndex = 66;
            this.rtpReceipt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(1270, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Biên lai";
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(368, 350);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(169, 47);
            this.btEdit.TabIndex = 68;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(368, 437);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(169, 47);
            this.btDelete.TabIndex = 69;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btReceipt
            // 
            this.btReceipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceipt.ForeColor = System.Drawing.Color.White;
            this.btReceipt.Location = new System.Drawing.Point(368, 529);
            this.btReceipt.Name = "btReceipt";
            this.btReceipt.Size = new System.Drawing.Size(169, 47);
            this.btReceipt.TabIndex = 70;
            this.btReceipt.Text = "Xuất biên lai";
            this.btReceipt.UseVisualStyleBackColor = false;
            this.btReceipt.Click += new System.EventHandler(this.btReceipt_Click);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Location = new System.Drawing.Point(368, 627);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(169, 47);
            this.btPrint.TabIndex = 71;
            this.btPrint.Text = "In hóa đơn";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // txtBSearch
            // 
            this.txtBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBSearch.Location = new System.Drawing.Point(674, 184);
            this.txtBSearch.Multiline = true;
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(296, 37);
            this.txtBSearch.TabIndex = 73;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cbBAgName
            // 
            this.cbBAgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBAgName.FormattingEnabled = true;
            this.cbBAgName.Location = new System.Drawing.Point(45, 350);
            this.cbBAgName.Name = "cbBAgName";
            this.cbBAgName.Size = new System.Drawing.Size(289, 37);
            this.cbBAgName.TabIndex = 75;
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.Location = new System.Drawing.Point(368, 729);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(169, 47);
            this.btReset.TabIndex = 77;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinformWaterBill.Properties.Resources.x_in_red_circle_fk8QwI8u_thumb;
            this.pictureBox3.Location = new System.Drawing.Point(1456, 816);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ptSearchidbill
            // 
            this.ptSearchidbill.Image = global::WinformWaterBill.Properties.Resources.OIP__4_1;
            this.ptSearchidbill.Location = new System.Drawing.Point(634, 184);
            this.ptSearchidbill.Name = "ptSearchidbill";
            this.ptSearchidbill.Size = new System.Drawing.Size(34, 37);
            this.ptSearchidbill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptSearchidbill.TabIndex = 79;
            this.ptSearchidbill.TabStop = false;
            this.ptSearchidbill.Click += new System.EventHandler(this.ptSearchidbill_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WinformWaterBill.Properties.Resources.OIP__2_;
            this.pictureBox6.Location = new System.Drawing.Point(1410, 816);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformWaterBill.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(1154, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinformWaterBill.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ptSearchidbill);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.cbBAgName);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtBSearch);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btReceipt);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtpReceipt);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dtBPeriod);
            this.Controls.Add(this.txtBTotal);
            this.Controls.Add(this.txtBTax);
            this.Controls.Add(this.txtBRate);
            this.Controls.Add(this.txtBConsupion);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbConsuption);
            this.Controls.Add(this.lbBPeriod);
            this.Controls.Add(this.lbAgentName);
            this.Controls.Add(this.lbCName);
            this.Controls.Add(this.cbBCID);
            this.Controls.Add(this.txtBCName);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbConsumer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchidbill)).EndInit();
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
        private System.Windows.Forms.Label lbCID;
        private System.Windows.Forms.TextBox txtBCName;
        private System.Windows.Forms.ComboBox cbBCID;
        private System.Windows.Forms.Label lbCName;
        private System.Windows.Forms.Label lbAgentName;
        private System.Windows.Forms.Label lbBPeriod;
        private System.Windows.Forms.Label lbConsuption;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtBConsupion;
        private System.Windows.Forms.TextBox txtBRate;
        private System.Windows.Forms.TextBox txtBTax;
        private System.Windows.Forms.TextBox txtBTotal;
        private System.Windows.Forms.DateTimePicker dtBPeriod;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.RichTextBox rtpReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btReceipt;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox txtBSearch;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cbBAgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox ptSearchidbill;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}