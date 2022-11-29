using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class GiaoDien : Form
    {
        int x;
        int y = 0;
        private INhanVienService _IDNhanVien;
        private IChucVuService _ICVSV;
        public GiaoDien()
        {
            InitializeComponent();
            _IDNhanVien = new NhanVienService();
            _ICVSV = new ChucVuService();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            text_gio.Text = DateTime.Now.ToLongTimeString(); // Lấy giờ
            label11.Text = DateTime.Now.Date.ToShortDateString();// Lấy Ngày
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // Chữ Động
            try
            {
                x = text_tieude.Location.X;
                x--;
                y++;
                text_tieude.Location = new Point(x, text_tieude.Location.Y);
                if (x <= 165)
                {
                    GiaoDien giao = new GiaoDien();
                    x = 850;
                    text_tieude.Location = new Point(x, text_tieude.Location.Y);
                }
                if (y % 2 == 0)
                {
                    text_tieude.ForeColor = Color.BlueViolet;
                }
                if (y % 2 != 0)
                {
                    text_tieude.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {


            }

        }
        private void GoFullscreen(bool fullscreen)// Full Màn Hình
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        private Form currenform;
        public void Openchildform(Form childform) // Child From
        {
            if (currenform != null)
            {
                currenform.Close();
            }
            currenform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pain_main.Controls.Add(childform);
            pain_main.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void bt_Sanpham_Click(object sender, EventArgs e)
        {
            Openchildform(new FrmSanPham());
        }

        private void bt_ThongKe_Click(object sender, EventArgs e)
        {
            var a = _IDNhanVien.GetAllNV().FirstOrDefault(p => p.Email == Login.layEmail);// Lấy ID Chức Vụ
            var b = _ICVSV.GetAllCV().FirstOrDefault(p => p.IDcv == a.IDCV); // Lấy Tên Chức vụ
            if (b.TenCV == "Quản Lý")
            {
                Openchildform(new FrmThongKe());
            }
            else
            {
                MessageBox.Show("Bạn Không Được Phép Sử Dụng Chức Năng Này");
            }
        
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            var a = _IDNhanVien.GetAllNV().FirstOrDefault(p => p.Email == Login.layEmail);// Lấy ID Chức Vụ
            var b = _ICVSV.GetAllCV().FirstOrDefault(p => p.IDcv == a.IDCV); // Lấy Tên Chức vụ
            if (b.TenCV == "Quản Lý")
            {
                Openchildform(new FrmQLNhanVien());
            }
            else
            {
                Openchildform(new FrmNhanVien());
            }
        }

        private void bt_Dangxuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void bt_DoiMK_Click(object sender, EventArgs e)
        {

        }
    }
}
