using A_DAL.Models;
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
    public partial class FrmDoiMk : Form
    {
        private string _message;
        private string _Layemail;
        private INhanVienService _INV;
        private Guid ID;
        private int a = 0, b = 0;
        public FrmDoiMk()
        {
            InitializeComponent();
            _INV = new NhanVienService();
        }
        public string Message // truyền from
        {
            get { return _message; }
            set { _message = value; }
        }

        private void gui_Click(object sender, EventArgs e) // bt đổi mk
        {
            if (checkrong(text_doimk.Text))
            {
                MessageBox.Show("Không được để trống mật khẩu");

            }
            else if (text_doimk.Text != text_xacnhanmk.Text)
            {
                MessageBox.Show("Hãy Nhập Đúng Mật Khẩu");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Đổi Mật Khẩu Không ?", "Thong bao", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_INV.UpdateMatKhau(_Layemail, new NhanVien()
                    {
                        MatKhau = text_xacnhanmk.Text,
                    }));
                    DialogResult dialogResult1 = MessageBox.Show("Bạn Có Muốn Trở Về Đăng Nhập Không ?", "Thong bao", MessageBoxButtons.YesNo);
                    if (dialogResult1==DialogResult.Yes)
                    {
                        Login lg = new Login();
                        lg.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Update that bai.");
                }

            }
        }
        private bool checkrong(string a) // Check nhập
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

        private void text_doimk_Click(object sender, EventArgs e)
        {
            if (a % 2 == 0)
            {
                text_doimk.SelectAll();
                a++;
            }
            else
            {
                text_doimk.SelectAll();
                a++;
            }
        }

        private void text_xacnhanmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Trở về đăng Nhập
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void text_xacnhanmk_Click(object sender, EventArgs e)
        {
            if (b % 2 == 0)
            {
                text_xacnhanmk.SelectAll();
                b++;
            }
            else
            {
                text_xacnhanmk.SelectAll();
                b++;
            }
        }
    }
}
