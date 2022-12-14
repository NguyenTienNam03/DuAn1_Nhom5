namespace C_PL.Views
{
    partial class FrmThongKe
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
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.check_all = new System.Windows.Forms.RadioButton();
            this.lb_tongsp = new System.Windows.Forms.Label();
            this.check_homnay = new System.Windows.Forms.RadioButton();
            this.lb_tonghdcho = new System.Windows.Forms.Label();
            this.lb_tonghoadatt = new System.Windows.Forms.Label();
            this.lb_tongdoanhthu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtgridview_theongay = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_tongdt = new System.Windows.Forms.Label();
            this.lb_tongsanpham = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtn_doanhthumin = new System.Windows.Forms.RadioButton();
            this.rbtn_doanhthumax = new System.Windows.Forms.RadioButton();
            this.rbtn_min = new System.Windows.Forms.RadioButton();
            this.rbtn_max = new System.Windows.Forms.RadioButton();
            this.dtgrid_thongkesp = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_theongay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_thongkesp)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1002, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 727);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.check_all);
            this.tabPage1.Controls.Add(this.lb_tongsp);
            this.tabPage1.Controls.Add(this.check_homnay);
            this.tabPage1.Controls.Add(this.lb_tonghdcho);
            this.tabPage1.Controls.Add(this.lb_tonghoadatt);
            this.tabPage1.Controls.Add(this.lb_tongdoanhthu);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dtgridview_theongay);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông kê doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // check_all
            // 
            this.check_all.AutoSize = true;
            this.check_all.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_all.Location = new System.Drawing.Point(46, 505);
            this.check_all.Name = "check_all";
            this.check_all.Size = new System.Drawing.Size(121, 26);
            this.check_all.TabIndex = 29;
            this.check_all.TabStop = true;
            this.check_all.Text = "Tất cả ngày";
            this.check_all.UseVisualStyleBackColor = true;
            this.check_all.Click += new System.EventHandler(this.check_all_Click);
            // 
            // lb_tongsp
            // 
            this.lb_tongsp.AutoSize = true;
            this.lb_tongsp.Location = new System.Drawing.Point(1036, 570);
            this.lb_tongsp.Name = "lb_tongsp";
            this.lb_tongsp.Size = new System.Drawing.Size(20, 22);
            this.lb_tongsp.TabIndex = 28;
            this.lb_tongsp.Text = "0";
            // 
            // check_homnay
            // 
            this.check_homnay.AutoSize = true;
            this.check_homnay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_homnay.Location = new System.Drawing.Point(194, 505);
            this.check_homnay.Name = "check_homnay";
            this.check_homnay.Size = new System.Drawing.Size(101, 26);
            this.check_homnay.TabIndex = 26;
            this.check_homnay.TabStop = true;
            this.check_homnay.Text = "Hôm nay";
            this.check_homnay.UseVisualStyleBackColor = true;
            this.check_homnay.Click += new System.EventHandler(this.check_homnay_Click);
            // 
            // lb_tonghdcho
            // 
            this.lb_tonghdcho.AutoSize = true;
            this.lb_tonghdcho.Location = new System.Drawing.Point(1052, 511);
            this.lb_tonghdcho.Name = "lb_tonghdcho";
            this.lb_tonghdcho.Size = new System.Drawing.Size(20, 22);
            this.lb_tonghdcho.TabIndex = 25;
            this.lb_tonghdcho.Text = "0";
            // 
            // lb_tonghoadatt
            // 
            this.lb_tonghoadatt.AutoSize = true;
            this.lb_tonghoadatt.Location = new System.Drawing.Point(722, 568);
            this.lb_tonghoadatt.Name = "lb_tonghoadatt";
            this.lb_tonghoadatt.Size = new System.Drawing.Size(20, 22);
            this.lb_tonghoadatt.TabIndex = 24;
            this.lb_tonghoadatt.Text = "0";
            // 
            // lb_tongdoanhthu
            // 
            this.lb_tongdoanhthu.AutoSize = true;
            this.lb_tongdoanhthu.Location = new System.Drawing.Point(616, 511);
            this.lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            this.lb_tongdoanhthu.Size = new System.Drawing.Size(20, 22);
            this.lb_tongdoanhthu.TabIndex = 23;
            this.lb_tongdoanhthu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(790, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số lượng sản phẩm bán được :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(481, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tổng Hoá đơn đã thanh toán :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(790, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tổng Hoá đơn chưa thanh toán  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(481, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tổng doanh thu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mời bạn chọn ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 593);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 30);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtgridview_theongay
            // 
            this.dtgridview_theongay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridview_theongay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column12,
            this.Column5,
            this.Column6});
            this.dtgridview_theongay.Location = new System.Drawing.Point(24, 35);
            this.dtgridview_theongay.Name = "dtgridview_theongay";
            this.dtgridview_theongay.RowHeadersWidth = 51;
            this.dtgridview_theongay.RowTemplate.Height = 29;
            this.dtgridview_theongay.Size = new System.Drawing.Size(1136, 450);
            this.dtgridview_theongay.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tổng số lượng sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tổng hoá đơn thành công";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng hoá đơn chưa thanh toán  ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Hoá đơn bị huỷ";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng hoá đơn ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tổng doanh thu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_tongdt);
            this.tabPage2.Controls.Add(this.lb_tongsanpham);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_timkiem);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.rbtn_doanhthumin);
            this.tabPage2.Controls.Add(this.rbtn_doanhthumax);
            this.tabPage2.Controls.Add(this.rbtn_min);
            this.tabPage2.Controls.Add(this.rbtn_max);
            this.tabPage2.Controls.Add(this.dtgrid_thongkesp);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông kê sản phẩm ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_tongdt
            // 
            this.lb_tongdt.AutoSize = true;
            this.lb_tongdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongdt.Location = new System.Drawing.Point(184, 87);
            this.lb_tongdt.Name = "lb_tongdt";
            this.lb_tongdt.Size = new System.Drawing.Size(20, 22);
            this.lb_tongdt.TabIndex = 11;
            this.lb_tongdt.Text = "0";
            // 
            // lb_tongsanpham
            // 
            this.lb_tongsanpham.AutoSize = true;
            this.lb_tongsanpham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongsanpham.Location = new System.Drawing.Point(283, 41);
            this.lb_tongsanpham.Name = "lb_tongsanpham";
            this.lb_tongsanpham.Size = new System.Drawing.Size(20, 22);
            this.lb_tongsanpham.TabIndex = 10;
            this.lb_tongsanpham.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(37, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(255, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "Số lượng sản phẩm bán được : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(37, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tổng doanh thu :";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem.Location = new System.Drawing.Point(207, 197);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(504, 30);
            this.txt_timkiem.TabIndex = 7;
            this.txt_timkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(24, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tìm kiếm theo mã SP: ";
            // 
            // rbtn_doanhthumin
            // 
            this.rbtn_doanhthumin.AutoSize = true;
            this.rbtn_doanhthumin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_doanhthumin.Location = new System.Drawing.Point(970, 183);
            this.rbtn_doanhthumin.Name = "rbtn_doanhthumin";
            this.rbtn_doanhthumin.Size = new System.Drawing.Size(168, 26);
            this.rbtn_doanhthumin.TabIndex = 4;
            this.rbtn_doanhthumin.TabStop = true;
            this.rbtn_doanhthumin.Text = "Doanh thu ít nhất ";
            this.rbtn_doanhthumin.UseVisualStyleBackColor = true;
            // 
            // rbtn_doanhthumax
            // 
            this.rbtn_doanhthumax.AutoSize = true;
            this.rbtn_doanhthumax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_doanhthumax.Location = new System.Drawing.Point(744, 183);
            this.rbtn_doanhthumax.Name = "rbtn_doanhthumax";
            this.rbtn_doanhthumax.Size = new System.Drawing.Size(199, 26);
            this.rbtn_doanhthumax.TabIndex = 3;
            this.rbtn_doanhthumax.TabStop = true;
            this.rbtn_doanhthumax.Text = "Doanh thu nhiều nhất ";
            this.rbtn_doanhthumax.UseVisualStyleBackColor = true;
            // 
            // rbtn_min
            // 
            this.rbtn_min.AutoSize = true;
            this.rbtn_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_min.Location = new System.Drawing.Point(970, 140);
            this.rbtn_min.Name = "rbtn_min";
            this.rbtn_min.Size = new System.Drawing.Size(120, 26);
            this.rbtn_min.TabIndex = 2;
            this.rbtn_min.TabStop = true;
            this.rbtn_min.Text = "Bán ít nhất ";
            this.rbtn_min.UseVisualStyleBackColor = true;
            // 
            // rbtn_max
            // 
            this.rbtn_max.AutoSize = true;
            this.rbtn_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_max.Location = new System.Drawing.Point(744, 140);
            this.rbtn_max.Name = "rbtn_max";
            this.rbtn_max.Size = new System.Drawing.Size(151, 26);
            this.rbtn_max.TabIndex = 1;
            this.rbtn_max.TabStop = true;
            this.rbtn_max.Text = "Bán nhiều nhất ";
            this.rbtn_max.UseVisualStyleBackColor = true;
            // 
            // dtgrid_thongkesp
            // 
            this.dtgrid_thongkesp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_thongkesp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgrid_thongkesp.Location = new System.Drawing.Point(6, 245);
            this.dtgrid_thongkesp.Name = "dtgrid_thongkesp";
            this.dtgrid_thongkesp.RowHeadersWidth = 51;
            this.dtgrid_thongkesp.RowTemplate.Height = 29;
            this.dtgrid_thongkesp.Size = new System.Drawing.Size(1168, 443);
            this.dtgrid_thongkesp.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STT";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã SP";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên Sản Phẩm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 175;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số lượng bán ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Doanh Thu";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 757);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridview_theongay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_thongkesp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RadioButton check_homnay;
        private Label lb_tonghdcho;
        private Label lb_tonghoadatt;
        private Label lb_tongdoanhthu;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dtgridview_theongay;
        private TabPage tabPage2;
        private Label lb_tongdt;
        private Label lb_tongsanpham;
        private Label label13;
        private Label label12;
        private TextBox txt_timkiem;
        private Label label11;
        private RadioButton rbtn_doanhthumin;
        private RadioButton rbtn_doanhthumax;
        private RadioButton rbtn_min;
        private RadioButton rbtn_max;
        private DataGridView dtgrid_thongkesp;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label lb_tongsp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private RadioButton check_all;
    }
}