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
    public partial class frmChangePassword : Form
    {
        public INhanVienService _invs;

        public frmChangePassword()
        {
            InitializeComponent();
            _invs= new NhanVienService();
            Layid();
        }
        public void reset()
        {
            txt_mkcu.Text = "";
            txt_mkmoi.Text = "";
            txt_nhaplaimkmoi.Text = "";
        }
        public void Layid()
        {
            var id = _invs.GetAllNV().FirstOrDefault(c => c.Email == Login.layEmail);
            lb_layid.Text = id.ID.ToString();
            lb_layid.Visible = false;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var id = _invs.GetAllNV().FirstOrDefault(c => c.Email == Login.layEmail);
            try
            {
                if(id.MatKhau != txt_mkcu.Text)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác .");
                    txt_mkcu.Text = "";
                    return;
                } else
                {
                    if(txt_mkmoi.Text != txt_nhaplaimkmoi.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp . Mời bạn nhập lại.");
                        txt_nhaplaimkmoi.Text = "";
                        return;
                    }else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn muốn đổi mật khẩu không ? ", "Thông báo", MessageBoxButtons.YesNo);
                        if(dialogResult == DialogResult.Yes)
                        {
                            NhanVien nv = new NhanVien()
                            {
                                ID = id.ID,
                                IDCV = id.IDCV,
                                SDT = id.SDT,
                                Email = id.Email,
                                NgaySinh = id.NgaySinh,
                                MaNV = id.MaNV,
                                DiaChi = id.DiaChi,
                                GioiTinh = id.GioiTinh,
                                TrangThai = id.TrangThai,
                                MatKhau = txt_nhaplaimkmoi.Text,
                            };
                            _invs.UpdateNV(id.ID , nv);
                            MessageBox.Show("Đổi mật khẩu thành công.");
                            reset();
                        } else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại.");
                            reset();
                            return;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                txt_mkcu.UseSystemPasswordChar= false;
                txt_mkmoi.UseSystemPasswordChar = false;
                txt_nhaplaimkmoi.UseSystemPasswordChar = false;
            } else
            {
                txt_mkcu.UseSystemPasswordChar = true;
                txt_mkmoi.UseSystemPasswordChar = true;
                txt_nhaplaimkmoi.UseSystemPasswordChar = true;
            }
        }
    }
}
