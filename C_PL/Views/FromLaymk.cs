using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class FromLaymk : Form
    {
        private INhanVienService _INSV;
        private Guid ID;
        System.Random rand = new System.Random();
        string body;
        int rdrdint;// random lấy mã
        int thoigian = 0;
        int a=0, b=0;
        public FromLaymk()
        {
            InitializeComponent();
            _INSV = new NhanVienService();
            rdrdint = rand.Next(minValue: 1000, maxValue: 10000);
        }

        private void bt_layma_Click(object sender, EventArgs e)
        {
            var email = _INSV.GetAllNV().FirstOrDefault(p => p.Email == text_email.Text);
            if (IsEmail(text_email.Text) == false)
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng Email");
            }
            else if (email == null)
            {
                MessageBox.Show("Email này không tồn tại. Hãy thử lại !!!");
            }
            else // Lấy Email
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("duc172003a9@gmail.com");
                message.To.Add(new MailAddress(text_email.Text));
                message.Subject = "Lấy Mã Code";
                message.Body = "Code của bạn là : " + rdrdint + "\nThanks";
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                //smtp.Host = "smtp.gamil.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("duc172003a9@gmail.com", "wdvuksvvacvhdxqq");
                smtp.EnableSsl = true;
                smtp.Send(message);
                MessageBox.Show("Hãy kiểm tra Email để lấy mã");
                bt_guilai.Enabled = true;
                timegui.Enabled = true;
                thoigian = 60;
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

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (checkrong(text_maxacnhan.Text))
            {
                MessageBox.Show("Hãy Nhập Mã Xác Nhận Có Trong Email");
            }
            if (rdrdint.ToString() != text_maxacnhan.Text)
            {
                MessageBox.Show("Mã không hợp lệ. Hãy kiểm tra lại");
            }
            else
            {
                MessageBox.Show("Xác nhận thành công. Mời bạn đổi lại mật khẩu");
                FrmDoiMk mk = new FrmDoiMk();
                mk.Message = text_email.Text;
                mk.Show();
                this.Hide();
            }
        }

        private void text_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_email_Click(object sender, EventArgs e)
        {
            if (a % 2 == 0)
            {
                text_email.SelectAll();
                a++;
            }
            else
            {
                text_email.Select();
                a++;
            }
        }

        private void bt_guilai_Click(object sender, EventArgs e)
        {
            if (thoigian < 60)
            {
                MessageBox.Show($" Bạn Hãy Gửi Lại Sau {thoigian} giây nữa !!!");
            }
            else
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("duc172003a9@gmail.com");
                message.To.Add(new MailAddress(text_email.Text));
                message.Subject = "Lấy Mã Code";
                message.Body = "Code của bạn là : " + rdrdint + "\nThanks";
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                //smtp.Host = "smtp.gamil.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("duc172003a9@gmail.com", "wdvuksvvacvhdxqq");
                smtp.EnableSsl = true;
                smtp.Send(message);
                MessageBox.Show("Hãy kiểm tra Email để lấy mã");
                bt_guilai.Enabled = true;
                timegui.Enabled = true;
                thoigian = 60;
            }
        }

        private void bt_trove_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void text_maxacnhan_Click(object sender, EventArgs e)
        {
            if (b % 2 == 0)
            {
                text_maxacnhan.SelectAll();
                b++;
            }
            else
            {
                text_maxacnhan.Select();
                b++;
            }
        }
    }
}
