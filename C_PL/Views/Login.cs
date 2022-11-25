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

            var x = _IDNhanVien.GetAllNV().FirstOrDefault(p => p.Email == text_pass.Text && p.MatKhau == text_user.Text);
            if (x == null)
            {
                MessageBox.Show(" Tài Khoản Này Không Tồn Tại. Mời Bạn Thử Lại");
            }
            else
            {
                layEmail = text_pass.Text; //gán giá trị
                MessageBox.Show(" Đăng Nhập Thành Công");
                FrmBanHang gd = new FrmBanHang();
                gd.ShowDialog();
                
// jjejej

            }
            
        }
    }
}
