namespace C_PL.Views
{
    partial class FrmQLHoaDon
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
            this.dtgridview_hoadon = new System.Windows.Forms.DataGridView();
            this.rbtn_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.rbt_chothanhtoan = new System.Windows.Forms.RadioButton();
            this.rbtn_huy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_mahoadon = new System.Windows.Forms.Label();
            this.dtview_hdct = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoahoadon = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_hoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtview_hdct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridview_hoadon
            // 
            this.dtgridview_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgridview_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgridview_hoadon.Location = new System.Drawing.Point(0, 0);
            this.dtgridview_hoadon.Name = "dtgridview_hoadon";
            this.dtgridview_hoadon.RowHeadersWidth = 51;
            this.dtgridview_hoadon.RowTemplate.Height = 29;
            this.dtgridview_hoadon.Size = new System.Drawing.Size(1269, 376);
            this.dtgridview_hoadon.TabIndex = 0;
            this.dtgridview_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridview_hoadon_CellClick);
            this.dtgridview_hoadon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridview_hoadon_CellDoubleClick);
            // 
            // rbtn_dathanhtoan
            // 
            this.rbtn_dathanhtoan.AutoSize = true;
            this.rbtn_dathanhtoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_dathanhtoan.Location = new System.Drawing.Point(1033, 515);
            this.rbtn_dathanhtoan.Name = "rbtn_dathanhtoan";
            this.rbtn_dathanhtoan.Size = new System.Drawing.Size(164, 30);
            this.rbtn_dathanhtoan.TabIndex = 1;
            this.rbtn_dathanhtoan.TabStop = true;
            this.rbtn_dathanhtoan.Text = "Đã thanh toán";
            this.rbtn_dathanhtoan.UseVisualStyleBackColor = true;
            this.rbtn_dathanhtoan.Click += new System.EventHandler(this.rbtn_dathanhtoan_Click);
            // 
            // rbt_chothanhtoan
            // 
            this.rbt_chothanhtoan.AutoSize = true;
            this.rbt_chothanhtoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_chothanhtoan.Location = new System.Drawing.Point(1033, 465);
            this.rbt_chothanhtoan.Name = "rbt_chothanhtoan";
            this.rbt_chothanhtoan.Size = new System.Drawing.Size(176, 30);
            this.rbt_chothanhtoan.TabIndex = 2;
            this.rbt_chothanhtoan.TabStop = true;
            this.rbt_chothanhtoan.Text = "Chờ thanh toán";
            this.rbt_chothanhtoan.UseVisualStyleBackColor = true;
            this.rbt_chothanhtoan.Click += new System.EventHandler(this.rbtn_thanhtoancho_Click);
            // 
            // rbtn_huy
            // 
            this.rbtn_huy.AutoSize = true;
            this.rbtn_huy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_huy.Location = new System.Drawing.Point(1033, 564);
            this.rbtn_huy.Name = "rbtn_huy";
            this.rbtn_huy.Size = new System.Drawing.Size(71, 30);
            this.rbtn_huy.TabIndex = 3;
            this.rbtn_huy.TabStop = true;
            this.rbtn_huy.Text = "Huỷ";
            this.rbtn_huy.UseVisualStyleBackColor = true;
            this.rbtn_huy.Click += new System.EventHandler(this.rbtn_huy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_mahoadon);
            this.groupBox1.Controls.Add(this.dtview_hdct);
            this.groupBox1.Location = new System.Drawing.Point(12, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoá đơn chi tiết ";
            // 
            // lb_mahoadon
            // 
            this.lb_mahoadon.AutoSize = true;
            this.lb_mahoadon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mahoadon.Location = new System.Drawing.Point(16, 34);
            this.lb_mahoadon.Name = "lb_mahoadon";
            this.lb_mahoadon.Size = new System.Drawing.Size(123, 26);
            this.lb_mahoadon.TabIndex = 6;
            this.lb_mahoadon.Text = "Mã hoá đơn";
            // 
            // dtview_hdct
            // 
            this.dtview_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtview_hdct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dtview_hdct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtview_hdct.Location = new System.Drawing.Point(3, 71);
            this.dtview_hdct.Name = "dtview_hdct";
            this.dtview_hdct.RowHeadersWidth = 51;
            this.dtview_hdct.RowTemplate.Height = 29;
            this.dtview_hdct.Size = new System.Drawing.Size(935, 249);
            this.dtview_hdct.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "IDSP";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tên SP";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Màu sắc ";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Size";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Số lượng";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Đơn giá";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Thành tiền";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // btn_xoahoadon
            // 
            this.btn_xoahoadon.BackColor = System.Drawing.Color.Red;
            this.btn_xoahoadon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoahoadon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoahoadon.Location = new System.Drawing.Point(1056, 620);
            this.btn_xoahoadon.Name = "btn_xoahoadon";
            this.btn_xoahoadon.Size = new System.Drawing.Size(153, 55);
            this.btn_xoahoadon.TabIndex = 5;
            this.btn_xoahoadon.Text = "Xoá ";
            this.btn_xoahoadon.UseVisualStyleBackColor = false;
            this.btn_xoahoadon.Click += new System.EventHandler(this.btn_xoahoadon_Click);
            // 
            // btn_all
            // 
            this.btn_all.AutoSize = true;
            this.btn_all.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_all.Location = new System.Drawing.Point(1033, 412);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(89, 30);
            this.btn_all.TabIndex = 6;
            this.btn_all.TabStop = true;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Hoá Đơn ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày tạo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày thanh toán";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Trạng thái";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // FrmQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 731);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_xoahoadon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtn_huy);
            this.Controls.Add(this.rbt_chothanhtoan);
            this.Controls.Add(this.rbtn_dathanhtoan);
            this.Controls.Add(this.dtgridview_hoadon);
            this.Name = "FrmQLHoaDon";
            this.Text = "FrmQLHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_hoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtview_hdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgridview_hoadon;
        private RadioButton rbtn_dathanhtoan;
        private RadioButton rbt_chothanhtoan;
        private RadioButton rbtn_huy;
        private GroupBox groupBox1;
        private DataGridView dtview_hdct;
        private Button btn_xoahoadon;
        private Label lb_mahoadon;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private RadioButton btn_all;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}