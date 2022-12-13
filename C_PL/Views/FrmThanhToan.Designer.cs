namespace C_PL.Views
{
    partial class FrmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThanhToan));
            this.dt_hdct = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_tienkhachdua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.lb_tientrakhach = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.lb_tongtiensp = new System.Windows.Forms.Label();
            this.lb_thue = new System.Windows.Forms.Label();
            this.PrintHoaDon = new System.Drawing.Printing.PrintDocument();
            this.printhd = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hdct)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_hdct
            // 
            this.dt_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_hdct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dt_hdct.Location = new System.Drawing.Point(11, 87);
            this.dt_hdct.Name = "dt_hdct";
            this.dt_hdct.RowHeadersWidth = 51;
            this.dt_hdct.RowTemplate.Height = 29;
            this.dt_hdct.Size = new System.Drawing.Size(728, 314);
            this.dt_hdct.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Màu sắc ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Size";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Tiền : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thuế :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(96, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiền khách đưa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(93, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiền trả khách :";
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.Location = new System.Drawing.Point(93, 683);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(150, 66);
            this.btn_huy.TabIndex = 5;
            this.btn_huy.Text = "Huỷ ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thanhtoan.Location = new System.Drawing.Point(399, 683);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(180, 66);
            this.btn_thanhtoan.TabIndex = 6;
            this.btn_thanhtoan.Text = "Thanh toán ";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_tienkhachdua
            // 
            this.txt_tienkhachdua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tienkhachdua.Location = new System.Drawing.Point(269, 572);
            this.txt_tienkhachdua.Name = "txt_tienkhachdua";
            this.txt_tienkhachdua.Size = new System.Drawing.Size(291, 30);
            this.txt_tienkhachdua.TabIndex = 10;
            this.txt_tienkhachdua.TextChanged += new System.EventHandler(this.txt_tienkhachdua_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thành Tiền : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã HĐ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(206, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên KH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(509, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(509, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã NV:";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_manv.Location = new System.Drawing.Point(598, 44);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(22, 26);
            this.lb_manv.TabIndex = 16;
            this.lb_manv.Text = "a";
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mahd.Location = new System.Drawing.Point(97, 44);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(24, 26);
            this.lb_mahd.TabIndex = 17;
            this.lb_mahd.Text = "b";
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tenkh.Location = new System.Drawing.Point(303, 44);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(22, 26);
            this.lb_tenkh.TabIndex = 18;
            this.lb_tenkh.Text = "c";
            // 
            // lb_tientrakhach
            // 
            this.lb_tientrakhach.AutoSize = true;
            this.lb_tientrakhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tientrakhach.Location = new System.Drawing.Point(269, 622);
            this.lb_tientrakhach.Name = "lb_tientrakhach";
            this.lb_tientrakhach.Size = new System.Drawing.Size(23, 26);
            this.lb_tientrakhach.TabIndex = 19;
            this.lb_tientrakhach.Text = "0";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongtien.Location = new System.Drawing.Point(269, 524);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(23, 26);
            this.lb_tongtien.TabIndex = 20;
            this.lb_tongtien.Text = "0";
            // 
            // lb_tongtiensp
            // 
            this.lb_tongtiensp.AutoSize = true;
            this.lb_tongtiensp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongtiensp.Location = new System.Drawing.Point(269, 430);
            this.lb_tongtiensp.Name = "lb_tongtiensp";
            this.lb_tongtiensp.Size = new System.Drawing.Size(23, 26);
            this.lb_tongtiensp.TabIndex = 21;
            this.lb_tongtiensp.Text = "0";
            // 
            // lb_thue
            // 
            this.lb_thue.AutoSize = true;
            this.lb_thue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_thue.Location = new System.Drawing.Point(269, 475);
            this.lb_thue.Name = "lb_thue";
            this.lb_thue.Size = new System.Drawing.Size(53, 26);
            this.lb_thue.TabIndex = 22;
            this.lb_thue.Text = "10%";
            // 
            // PrintHoaDon
            // 
            this.PrintHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintHoaDon_PrintPage);
            // 
            // printhd
            // 
            this.printhd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printhd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printhd.ClientSize = new System.Drawing.Size(400, 300);
            this.printhd.Enabled = true;
            this.printhd.Icon = ((System.Drawing.Icon)(resources.GetObject("printhd.Icon")));
            this.printhd.Name = "printPreviewDialog1";
            this.printhd.Visible = false;
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 779);
            this.Controls.Add(this.lb_thue);
            this.Controls.Add(this.lb_tongtiensp);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.lb_tientrakhach);
            this.Controls.Add(this.lb_tenkh);
            this.Controls.Add(this.lb_mahd);
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tienkhachdua);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_hdct);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dt_hdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dt_hdct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_huy;
        private Button btn_thanhtoan;
        private TextBox txt_tienkhachdua;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lb_manv;
        private Label lb_mahd;
        private Label lb_tenkh;
        private Label lb_tientrakhach;
        private Label lb_tongtien;
        private Label lb_tongtiensp;
        private Label lb_thue;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private System.Drawing.Printing.PrintDocument PrintHoaDon;
        private PrintPreviewDialog printhd;
    }
}