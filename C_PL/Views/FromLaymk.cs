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
        public FromLaymk()
        {
            InitializeComponent();
            _INSV = new NhanVienService();
            rdrdint = rand.Next(minValue: 1000, maxValue: 10000);
        }

        private void bt_layma_Click(object sender, EventArgs e)
        {
            var email = _INSV.GetAllNV().FirstOrDefault(p => p.Email == text_email.Text);
            if (email == null)
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
                timegui.Enabled = true;
                thoigian = 0;
            }
        }
    }
}
