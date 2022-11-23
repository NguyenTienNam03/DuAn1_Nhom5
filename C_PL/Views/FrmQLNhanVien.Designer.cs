namespace C_PL.Views
{
    partial class FrmQLNhanVien
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
            this.dtgrid_nhanvien = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.check_hd = new System.Windows.Forms.CheckBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.rbtn_Nữ = new System.Windows.Forms.RadioButton();
            this.check_khd = new System.Windows.Forms.CheckBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ptb_capnhat = new System.Windows.Forms.PictureBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_them = new System.Windows.Forms.PictureBox();
            this.ptb_addchucvu = new System.Windows.Forms.PictureBox();
            this.ptb_refesh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capnhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_addchucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_refesh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_nhanvien
            // 
            this.dtgrid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dtgrid_nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_nhanvien.Location = new System.Drawing.Point(0, 420);
            this.dtgrid_nhanvien.Name = "dtgrid_nhanvien";
            this.dtgrid_nhanvien.RowHeadersWidth = 51;
            this.dtgrid_nhanvien.RowTemplate.Height = 29;
            this.dtgrid_nhanvien.Size = new System.Drawing.Size(1268, 362);
            this.dtgrid_nhanvien.TabIndex = 0;
            this.dtgrid_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_nhanvien_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Sinh ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa Chỉ ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SĐT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mật Khẩu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Chức vụ ";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Trạng Thái ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 120;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(159, 42);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(327, 27);
            this.txt_MaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên NV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa Chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(582, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chức vụ  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(582, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng thái :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(582, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mật Khẩu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(585, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Email  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(582, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Số ĐT :";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(157, 201);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(329, 27);
            this.dtp_NgaySinh.TabIndex = 12;
            this.dtp_NgaySinh.Value = new System.DateTime(2022, 11, 16, 22, 59, 58, 0);
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(748, 199);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(329, 28);
            this.cbb_chucvu.TabIndex = 13;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Nam.Location = new System.Drawing.Point(159, 142);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(68, 26);
            this.rbtn_Nam.TabIndex = 14;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // check_hd
            // 
            this.check_hd.AutoSize = true;
            this.check_hd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_hd.Location = new System.Drawing.Point(748, 263);
            this.check_hd.Name = "check_hd";
            this.check_hd.Size = new System.Drawing.Size(113, 26);
            this.check_hd.TabIndex = 15;
            this.check_hd.Text = "Hoạt động";
            this.check_hd.UseVisualStyleBackColor = true;
            this.check_hd.CheckedChanged += new System.EventHandler(this.check_hd_CheckedChanged);
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(159, 92);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(327, 27);
            this.txt_TenNV.TabIndex = 16;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(159, 262);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(327, 27);
            this.txt_DiaChi.TabIndex = 17;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(750, 45);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(327, 27);
            this.txt_sdt.TabIndex = 18;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(750, 86);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(327, 27);
            this.txt_Email.TabIndex = 19;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(750, 138);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(327, 27);
            this.txt_matkhau.TabIndex = 20;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // rbtn_Nữ
            // 
            this.rbtn_Nữ.AutoSize = true;
            this.rbtn_Nữ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Nữ.Location = new System.Drawing.Point(387, 142);
            this.rbtn_Nữ.Name = "rbtn_Nữ";
            this.rbtn_Nữ.Size = new System.Drawing.Size(56, 26);
            this.rbtn_Nữ.TabIndex = 21;
            this.rbtn_Nữ.TabStop = true;
            this.rbtn_Nữ.Text = "Nữ";
            this.rbtn_Nữ.UseVisualStyleBackColor = true;
            // 
            // check_khd
            // 
            this.check_khd.AutoSize = true;
            this.check_khd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_khd.Location = new System.Drawing.Point(913, 265);
            this.check_khd.Name = "check_khd";
            this.check_khd.Size = new System.Drawing.Size(164, 26);
            this.check_khd.TabIndex = 22;
            this.check_khd.Text = "Không hoạt động";
            this.check_khd.UseVisualStyleBackColor = true;
            this.check_khd.CheckedChanged += new System.EventHandler(this.check_khd_CheckedChanged);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_timkiem.Location = new System.Drawing.Point(852, 348);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(381, 27);
            this.txt_timkiem.TabIndex = 24;
            this.txt_timkiem.Text = "Tìm kiếm theo mã nv hoặc tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(719, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 26);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tìm kiếm :";
            // 
            // ptb_capnhat
            // 
            this.ptb_capnhat.Image = global::C_PL.Properties.Resources.update;
            this.ptb_capnhat.Location = new System.Drawing.Point(168, 334);
            this.ptb_capnhat.Name = "ptb_capnhat";
            this.ptb_capnhat.Size = new System.Drawing.Size(59, 57);
            this.ptb_capnhat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_capnhat.TabIndex = 26;
            this.ptb_capnhat.TabStop = false;
            this.ptb_capnhat.Click += new System.EventHandler(this.ptb_capnhat_Click);
            // 
            // ptb_xoa
            // 
            this.ptb_xoa.Image = global::C_PL.Properties.Resources.Delete1;
            this.ptb_xoa.Location = new System.Drawing.Point(256, 334);
            this.ptb_xoa.Name = "ptb_xoa";
            this.ptb_xoa.Size = new System.Drawing.Size(59, 57);
            this.ptb_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoa.TabIndex = 27;
            this.ptb_xoa.TabStop = false;
            this.ptb_xoa.Click += new System.EventHandler(this.ptb_xoa_Click);
            // 
            // ptb_them
            // 
            this.ptb_them.Image = global::C_PL.Properties.Resources.plus;
            this.ptb_them.Location = new System.Drawing.Point(73, 334);
            this.ptb_them.Name = "ptb_them";
            this.ptb_them.Size = new System.Drawing.Size(63, 57);
            this.ptb_them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_them.TabIndex = 25;
            this.ptb_them.TabStop = false;
            this.ptb_them.Click += new System.EventHandler(this.ptb_them_Click);
            // 
            // ptb_addchucvu
            // 
            this.ptb_addchucvu.Image = global::C_PL.Properties.Resources.plus1;
            this.ptb_addchucvu.Location = new System.Drawing.Point(1083, 197);
            this.ptb_addchucvu.Name = "ptb_addchucvu";
            this.ptb_addchucvu.Size = new System.Drawing.Size(33, 29);
            this.ptb_addchucvu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_addchucvu.TabIndex = 28;
            this.ptb_addchucvu.TabStop = false;
            this.ptb_addchucvu.Click += new System.EventHandler(this.ptb_addchucvu_Click);
            // 
            // ptb_refesh
            // 
            this.ptb_refesh.Image = global::C_PL.Properties.Resources.Refresh_icon;
            this.ptb_refesh.Location = new System.Drawing.Point(1120, 198);
            this.ptb_refesh.Name = "ptb_refesh";
            this.ptb_refesh.Size = new System.Drawing.Size(33, 29);
            this.ptb_refesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_refesh.TabIndex = 29;
            this.ptb_refesh.TabStop = false;
            this.ptb_refesh.Click += new System.EventHandler(this.ptb_refesh_Click);
            // 
            // FrmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 782);
            this.Controls.Add(this.ptb_refesh);
            this.Controls.Add(this.ptb_addchucvu);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_capnhat);
            this.Controls.Add(this.ptb_them);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.check_khd);
            this.Controls.Add(this.rbtn_Nữ);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.check_hd);
            this.Controls.Add(this.rbtn_Nam);
            this.Controls.Add(this.cbb_chucvu);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.dtgrid_nhanvien);
            this.Name = "FrmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_capnhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_addchucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_refesh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgrid_nhanvien;
        private TextBox txt_MaNV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtp_NgaySinh;
        private ComboBox cbb_chucvu;
        private RadioButton rbtn_Nam;
        private CheckBox check_hd;
        private TextBox txt_TenNV;
        private TextBox txt_DiaChi;
        private TextBox txt_sdt;
        private TextBox txt_Email;
        private TextBox txt_matkhau;
        private RadioButton rbtn_Nữ;
        private CheckBox check_khd;
        private TextBox txt_timkiem;
        private Label label11;
        private PictureBox ptb_capnhat;
        private PictureBox ptb_xoa;
        private PictureBox ptb_them;
        private PictureBox ptb_addchucvu;
        private PictureBox ptb_refesh;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}