namespace C_PL.Views
{
    partial class FrmQLKhachHang
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
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_capnhat = new System.Windows.Forms.PictureBox();
            this.ptb_them = new System.Windows.Forms.PictureBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.dtgrid_khachhang = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capnhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_xoa
            // 
            this.ptb_xoa.Image = global::C_PL.Properties.Resources.Delete1;
            this.ptb_xoa.Location = new System.Drawing.Point(274, 174);
            this.ptb_xoa.Name = "ptb_xoa";
            this.ptb_xoa.Size = new System.Drawing.Size(59, 57);
            this.ptb_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoa.TabIndex = 57;
            this.ptb_xoa.TabStop = false;
            this.ptb_xoa.Click += new System.EventHandler(this.ptb_xoa_Click);
            // 
            // ptb_capnhat
            // 
            this.ptb_capnhat.Image = global::C_PL.Properties.Resources.update;
            this.ptb_capnhat.Location = new System.Drawing.Point(173, 174);
            this.ptb_capnhat.Name = "ptb_capnhat";
            this.ptb_capnhat.Size = new System.Drawing.Size(59, 57);
            this.ptb_capnhat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_capnhat.TabIndex = 56;
            this.ptb_capnhat.TabStop = false;
            this.ptb_capnhat.Click += new System.EventHandler(this.ptb_capnhat_Click);
            // 
            // ptb_them
            // 
            this.ptb_them.Image = global::C_PL.Properties.Resources.plus;
            this.ptb_them.Location = new System.Drawing.Point(55, 174);
            this.ptb_them.Name = "ptb_them";
            this.ptb_them.Size = new System.Drawing.Size(63, 57);
            this.ptb_them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_them.TabIndex = 55;
            this.ptb_them.TabStop = false;
            this.ptb_them.Click += new System.EventHandler(this.ptb_them_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem.Location = new System.Drawing.Point(831, 207);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(381, 27);
            this.txt_timkiem.TabIndex = 54;
            this.txt_timkiem.Text = "Tìm kiếm theo mã kh hoặc tên";
            this.txt_timkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(658, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 26);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tìm kiếm :";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(748, 25);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(327, 27);
            this.txt_sdt.TabIndex = 48;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(750, 79);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(327, 27);
            this.txt_DiaChi.TabIndex = 47;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(159, 79);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(327, 27);
            this.txt_tenkh.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(632, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Số ĐT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(626, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Địa Chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên NV :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã NV :";
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(159, 22);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(327, 27);
            this.txt_makh.TabIndex = 31;
            // 
            // dtgrid_khachhang
            // 
            this.dtgrid_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column11,
            this.Column1,
            this.Column5,
            this.Column6});
            this.dtgrid_khachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_khachhang.Location = new System.Drawing.Point(0, 286);
            this.dtgrid_khachhang.Name = "dtgrid_khachhang";
            this.dtgrid_khachhang.RowHeadersWidth = 51;
            this.dtgrid_khachhang.RowTemplate.Height = 29;
            this.dtgrid_khachhang.Size = new System.Drawing.Size(1241, 385);
            this.dtgrid_khachhang.TabIndex = 30;
            this.dtgrid_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_khachhang_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Mã KH";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa Chỉ ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SĐT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // FrmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 671);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_capnhat);
            this.Controls.Add(this.ptb_them);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.dtgrid_khachhang);
            this.Name = "FrmQLKhachHang";
            this.Text = "FrmQLKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capnhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptb_xoa;
        private PictureBox ptb_capnhat;
        private PictureBox ptb_them;
        private TextBox txt_timkiem;
        private Label label11;
        private TextBox txt_sdt;
        private TextBox txt_DiaChi;
        private TextBox txt_tenkh;
        private Label label10;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txt_makh;
        private DataGridView dtgrid_khachhang;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}