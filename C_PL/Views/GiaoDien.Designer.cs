namespace C_PL.Views
{
    partial class GiaoDien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            this.pain_main = new System.Windows.Forms.Panel();
            this.text_gio = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_tieude = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Dangxuat = new System.Windows.Forms.Button();
            this.bt_DoiMK = new System.Windows.Forms.Button();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            this.bt_BanHang = new System.Windows.Forms.Button();
            this.bt_Sanpham = new System.Windows.Forms.Button();
            this.bt_KhachHang = new System.Windows.Forms.Button();
            this.bt_NhanVien = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pain_main
            // 
            this.pain_main.Location = new System.Drawing.Point(212, 132);
            this.pain_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pain_main.Name = "pain_main";
            this.pain_main.Size = new System.Drawing.Size(1683, 894);
            this.pain_main.TabIndex = 109;
            // 
            // text_gio
            // 
            this.text_gio.AutoSize = true;
            this.text_gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_gio.ForeColor = System.Drawing.Color.DarkRed;
            this.text_gio.Location = new System.Drawing.Point(1633, 94);
            this.text_gio.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.text_gio.Name = "text_gio";
            this.text_gio.Size = new System.Drawing.Size(88, 26);
            this.text_gio.TabIndex = 99;
            this.text_gio.Text = "text_gio";
            this.text_gio.Click += new System.EventHandler(this.label15_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, -1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // text_tieude
            // 
            this.text_tieude.AutoSize = true;
            this.text_tieude.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_tieude.Location = new System.Drawing.Point(422, 33);
            this.text_tieude.Name = "text_tieude";
            this.text_tieude.Size = new System.Drawing.Size(630, 41);
            this.text_tieude.TabIndex = 0;
            this.text_tieude.Text = "T.WIN STORE XIN KÍNH CHÀO QUÝ KHÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_Dangxuat);
            this.groupBox1.Controls.Add(this.bt_DoiMK);
            this.groupBox1.Controls.Add(this.bt_ThongKe);
            this.groupBox1.Controls.Add(this.bt_BanHang);
            this.groupBox1.Controls.Add(this.bt_Sanpham);
            this.groupBox1.Controls.Add(this.bt_KhachHang);
            this.groupBox1.Controls.Add(this.bt_NhanVien);
            this.groupBox1.Location = new System.Drawing.Point(3, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(209, 890);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 61);
            this.button1.TabIndex = 27;
            this.button1.Text = "Hoá Đơn ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Dangxuat
            // 
            this.bt_Dangxuat.BackColor = System.Drawing.Color.White;
            this.bt_Dangxuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("bt_Dangxuat.Image")));
            this.bt_Dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Dangxuat.Location = new System.Drawing.Point(6, 708);
            this.bt_Dangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Dangxuat.Name = "bt_Dangxuat";
            this.bt_Dangxuat.Size = new System.Drawing.Size(179, 61);
            this.bt_Dangxuat.TabIndex = 26;
            this.bt_Dangxuat.Text = "        Đăng Xuất";
            this.bt_Dangxuat.UseVisualStyleBackColor = false;
            this.bt_Dangxuat.Click += new System.EventHandler(this.bt_Dangxuat_Click);
            // 
            // bt_DoiMK
            // 
            this.bt_DoiMK.BackColor = System.Drawing.Color.White;
            this.bt_DoiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_DoiMK.Image = ((System.Drawing.Image)(resources.GetObject("bt_DoiMK.Image")));
            this.bt_DoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DoiMK.Location = new System.Drawing.Point(10, 611);
            this.bt_DoiMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_DoiMK.Name = "bt_DoiMK";
            this.bt_DoiMK.Size = new System.Drawing.Size(178, 61);
            this.bt_DoiMK.TabIndex = 25;
            this.bt_DoiMK.Text = "Đổi Mật Khẩu";
            this.bt_DoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_DoiMK.UseVisualStyleBackColor = false;
            this.bt_DoiMK.Click += new System.EventHandler(this.bt_DoiMK_Click);
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.BackColor = System.Drawing.Color.White;
            this.bt_ThongKe.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("bt_ThongKe.Image")));
            this.bt_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ThongKe.Location = new System.Drawing.Point(9, 247);
            this.bt_ThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.Size = new System.Drawing.Size(179, 61);
            this.bt_ThongKe.TabIndex = 24;
            this.bt_ThongKe.Text = "Thống Kê   ";
            this.bt_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ThongKe.UseVisualStyleBackColor = false;
            this.bt_ThongKe.Click += new System.EventHandler(this.bt_ThongKe_Click);
            // 
            // bt_BanHang
            // 
            this.bt_BanHang.BackColor = System.Drawing.Color.White;
            this.bt_BanHang.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_BanHang.Image = ((System.Drawing.Image)(resources.GetObject("bt_BanHang.Image")));
            this.bt_BanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_BanHang.Location = new System.Drawing.Point(9, 150);
            this.bt_BanHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_BanHang.Name = "bt_BanHang";
            this.bt_BanHang.Size = new System.Drawing.Size(179, 61);
            this.bt_BanHang.TabIndex = 23;
            this.bt_BanHang.Text = "Bán Hàng   ";
            this.bt_BanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_BanHang.UseVisualStyleBackColor = false;
            this.bt_BanHang.Click += new System.EventHandler(this.bt_BanHang_Click);
            // 
            // bt_Sanpham
            // 
            this.bt_Sanpham.BackColor = System.Drawing.Color.White;
            this.bt_Sanpham.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Sanpham.ForeColor = System.Drawing.Color.Black;
            this.bt_Sanpham.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sanpham.Image")));
            this.bt_Sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sanpham.Location = new System.Drawing.Point(9, 49);
            this.bt_Sanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Sanpham.Name = "bt_Sanpham";
            this.bt_Sanpham.Size = new System.Drawing.Size(178, 69);
            this.bt_Sanpham.TabIndex = 19;
            this.bt_Sanpham.Text = "Sản Phẩm  ";
            this.bt_Sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Sanpham.UseVisualStyleBackColor = false;
            this.bt_Sanpham.Click += new System.EventHandler(this.bt_Sanpham_Click);
            // 
            // bt_KhachHang
            // 
            this.bt_KhachHang.BackColor = System.Drawing.Color.White;
            this.bt_KhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("bt_KhachHang.Image")));
            this.bt_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_KhachHang.Location = new System.Drawing.Point(9, 522);
            this.bt_KhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_KhachHang.Name = "bt_KhachHang";
            this.bt_KhachHang.Size = new System.Drawing.Size(179, 61);
            this.bt_KhachHang.TabIndex = 21;
            this.bt_KhachHang.Text = "Khách Hàng  ";
            this.bt_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_KhachHang.UseVisualStyleBackColor = false;
            this.bt_KhachHang.Click += new System.EventHandler(this.bt_KhachHang_Click);
            // 
            // bt_NhanVien
            // 
            this.bt_NhanVien.BackColor = System.Drawing.Color.White;
            this.bt_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("bt_NhanVien.Image")));
            this.bt_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_NhanVien.Location = new System.Drawing.Point(8, 421);
            this.bt_NhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_NhanVien.Name = "bt_NhanVien";
            this.bt_NhanVien.Size = new System.Drawing.Size(179, 61);
            this.bt_NhanVien.TabIndex = 22;
            this.bt_NhanVien.Text = "Nhân Viên   ";
            this.bt_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_NhanVien.UseVisualStyleBackColor = false;
            this.bt_NhanVien.Click += new System.EventHandler(this.bt_NhanVien_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.text_gio);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.text_tieude);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1851, 124);
            this.panel3.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(1749, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 26);
            this.label11.TabIndex = 108;
            this.label11.Text = "label11";
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 1040);
            this.Controls.Add(this.pain_main);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pain_main;
        private Label text_gio;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label text_tieude;
        private GroupBox groupBox1;
        private Button bt_Dangxuat;
        private Button bt_DoiMK;
        private Button bt_ThongKe;
        private Button bt_BanHang;
        private Button bt_Sanpham;
        private Button bt_KhachHang;
        private Button bt_NhanVien;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel3;
        private Label label11;
        private Button button1;
    }
}