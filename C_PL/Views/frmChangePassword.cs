using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.Utilities;
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
        public IChucVuService _icvs;
        public Validate _check;
        public frmChangePassword()
        {
            InitializeComponent();
            _invs= new NhanVienService();
            Layid();
            _check = new Validate();
            _icvs = new ChucVuService();
            loaddulieu();
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
        public void loaddulieu()
        {
            var thongtin = _invs.GetAllNV().FirstOrDefault(c => c.ID == Guid.Parse(lb_layid.Text));
            var chucvu = _icvs.GetAllCV().Where(c =>c.IDcv == thongtin.IDCV).Select(c => c.TenCV).FirstOrDefault();
            lb_chucvu.Text = chucvu.ToString();
            lb_ten.Text = thongtin.Ten.ToString();
            lb_manv.Text = thongtin.MaNV.ToString();
            lb_gioitinh.Text = thongtin.GioiTinh.ToString();
            dtp_ngaysinh.Value = thongtin.NgaySinh.Value;
            txt_sdt.Text = thongtin.SDT.ToString();
            txt_diachi.Text = thongtin.DiaChi.ToString();
            txt_email.Text = thongtin.Email.ToString();
            lb_trangthai.Text = thongtin.TrangThai.ToString();
            dtp_ngaysinh.Enabled = false;
            txt_diachi.Enabled = false;
            txt_email.Enabled = false;
            txt_sdt.Enabled = false;
            txt_mkcu.Visible = false;
            txt_mkmoi.Visible = false;
            txt_nhaplaimkmoi.Visible = false;
            btn_xacnhanthaydoitt.Visible = false;
            bnt_xacnhathaydoimk.Visible = false;
            check_pass.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var id = _invs.GetAllNV().FirstOrDefault(c => c.Email == Login.layEmail);
            try
            {
                if(DateTime.Now.Year - dtp_ngaysinh.Value.Year < 18)
                {
                    MessageBox.Show("Bạn dưới 18 tuổi.");
                    return;
                }else if(_check.CheckSDT(txt_sdt.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng dạng sdt.");
                    return;
                }else if(_check.CheckEmail(txt_email.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng dạng email.");
                    return;
                }
                else if (_check.checkRong(txt_diachi.Text) == false)
                {
                    MessageBox.Show("Bạn không được bỏ trống địa chỉ .");
                    return;
                }else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhât thông tin lại không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        NhanVien nv = new NhanVien()
                        {

                            ID = id.ID,
                            IDCV = id.IDCV,
                            SDT = txt_sdt.Text,
                            Email = txt_email.Text,
                            NgaySinh = dtp_ngaysinh.Value,
                            MaNV = id.MaNV,
                            DiaChi = txt_diachi.Text,
                            GioiTinh = id.GioiTinh,
                            TrangThai = id.TrangThai,
                            MatKhau = txt_nhaplaimkmoi.Text,
                        };
                        _invs.UpdateNV(id.ID, nv);
                        MessageBox.Show("Cập nhật thông tin thành công .");
                        loaddulieu();
                    }else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại.");
                        loaddulieu();
                        return;
                    }
                }
            }catch
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

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                bnt_xacnhathaydoimk.Visible = true;
                txt_mkcu.Visible = true;
                txt_mkmoi.Visible = true;
                txt_nhaplaimkmoi.Visible = true;
                btn_xacnhanthaydoitt.Visible = false;
                //btn_capnhatthongtin.Visible = false;
                dtp_ngaysinh.Enabled = false;
                txt_diachi.Enabled = false;
                txt_email.Enabled = false;
                txt_sdt.Enabled = false;
                check_pass.Visible = true;
        }

        private void btn_capnhatthongtin_Click(object sender, EventArgs e)
        {
            btn_xacnhanthaydoitt.Visible = true;
            dtp_ngaysinh.Enabled = true;
            txt_diachi.Enabled = true;
            txt_email.Enabled = true;
            txt_sdt.Enabled = true;
            check_pass.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            bnt_xacnhathaydoimk.Visible = false;
            txt_mkcu.Visible = false;
            txt_mkmoi.Visible = false;
            txt_nhaplaimkmoi.Visible = false;
        }

        private void bnt_xacnhathaydoimk_Click(object sender, EventArgs e)
        {
            var id = _invs.GetAllNV().FirstOrDefault(c => c.Email == Login.layEmail);
            try
            {
                if (id.MatKhau != txt_mkcu.Text)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác .");
                    txt_mkcu.Text = "";
                    return;
                }
                else
                {
                    if (txt_mkmoi.Text != txt_nhaplaimkmoi.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp . Mời bạn nhập lại.");
                        txt_nhaplaimkmoi.Text = "";
                        return;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn muốn đổi mật khẩu không ? ", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            NhanVien nv = new NhanVien()
                            {
                                ID = id.ID,
                                IDCV = id.IDCV,
                                SDT = txt_sdt.Text,
                                Email = txt_email.Text,
                                NgaySinh = dtp_ngaysinh.Value,
                                MaNV = id.MaNV,
                                DiaChi = txt_diachi.Text,
                                GioiTinh = id.GioiTinh,
                                TrangThai = id.TrangThai,
                                MatKhau = txt_nhaplaimkmoi.Text,
                            };
                            _invs.UpdateNV(id.ID, nv);
                            MessageBox.Show("Đổi mật khẩu thành công.");
                            loaddulieu();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại.");
                            loaddulieu();
                            return;
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
