using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class Login : Form
    {
        public static string layEmail = ""; //tạo biến cục bộ
        private INhanVienService _IDNhanVien;
        private Guid ID;
        public Login()
        {
            InitializeComponent();
            _IDNhanVien = new NhanVienService();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                var trangthai = _IDNhanVien.GetAllNV().Where(c => c.Email == text_user.Text).Select(c => c.TrangThai).FirstOrDefault();
                var x = _IDNhanVien.GetAllNV().FirstOrDefault(p => p.Email == text_user.Text && p.MatKhau == text_pass.Text);
                if (IsEmail(text_user.Text) == false)
                {
                    MessageBox.Show("Hãy Nhập Đúng định dạng email");
                }
                else if (checkrong(text_user.Text))
                {
                    MessageBox.Show("Hãy Nhập Tài Khoản Đi");
                }
                else if (checkrong(text_pass.Text))
                {
                    MessageBox.Show("Hãy Nhập Mật Khẩu Đi");
                }
                else if (x == null)
                {
                    MessageBox.Show(" Tài Khoản Này Không Tồn Tại. Mời Bạn Thử Lại");
                }
                else if (trangthai == "Không hoạt động")
                {
                    MessageBox.Show("Tài khoản này dừng hoạt động .");
                    return;
                }
                else
                {
                    layEmail = text_user.Text; //gán giá trị
                    MessageBox.Show(" Đăng Nhập Thành Công");
                    GiaoDien gd = new GiaoDien();
                    gd.Show();
                    this.Hide();
                }

            }
            catch
            {

            }

        }
        private bool checkrong(string a)// Check null
        {
            if (a.Trim().Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEmail(string email) // Check nhập Mail
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }
        private void label2_Click(object sender, EventArgs e) // click quên mật khẩu
        {
            FromLaymk laymk = new FromLaymk();
            laymk.Show();
            this.Hide();
        }

        private void check_show_CheckedChanged(object sender, EventArgs e)
        {
            if(check_show.Checked)
            {
                text_pass.UseSystemPasswordChar = true;
            }else
            {
                text_pass.UseSystemPasswordChar = false;
            }
        }
    }
}
