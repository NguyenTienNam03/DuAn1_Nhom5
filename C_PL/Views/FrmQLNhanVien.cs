using A_DAL.IRepositorys;
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
    public partial class FrmQLNhanVien : Form
    {
        private IChucVuService _Icvs;
        private INhanVienService _Invs;
        private Guid id;
        public Validate _check;

        public FrmQLNhanVien()
        {
            InitializeComponent();
            _Icvs = new ChucVuService();
            _Invs = new NhanVienService();
            txt_MaNV.Enabled = false;
            LoadChucVu();
            _check= new Validate();
            //txt_MaNV.Enabled= false;
            LoadNV(); 
            check_hd.Checked = true ;
        }
        public void LoadNV()
        {
            dtgrid_nhanvien.Rows.Clear();
            dtgrid_nhanvien.Columns[0].Visible = false;
            foreach(var x in _Invs.GetAllNV().OrderBy(c => c.MaNV))
            {
                var y = _Icvs.GetAllCV().FirstOrDefault(c => c.IDcv == x.IDCV);
                dtgrid_nhanvien.Rows.Add(x.ID , x.MaNV, x.Ten, x.GioiTinh, x.NgaySinh, x.DiaChi, x.SDT, x.Email, x.MatKhau, y.TenCV, x.TrangThai);
            }
            
        }
        public void LoadChucVu()
        {
            cbb_chucvu.Items.Clear();
            foreach(var x in _Icvs.GetAllCV().OrderBy(c => c.TenCV))
            {
                cbb_chucvu.Items.Add(x.TenCV);
            }
        }

        private void ptb_them_Click(object sender, EventArgs e)
        {
            try
            {
                if(_check.checkRong(txt_TenNV.Text) == false )
                {
                    MessageBox.Show("Mời bạn nhập tên nhân viên .");
                    return;

                } else if(_check.checkRong(txt_DiaChi.Text) == false )
                {
                    MessageBox.Show("Mời bạn nhập địa chỉ nhân viên .");
                    return;
                }else if(_check.checkRong(txt_matkhau.Text) == false )
                {
                    MessageBox.Show("Mời bạn nhập mật khẩu cho nhân viên .");
                    return;
                } else if(_check.CheckEmail(txt_Email.Text) == false )
                {
                    MessageBox.Show("Bạn nhập đúng dạng của email của nhân viên .");
                    return; 
                }else if(DateTime.Now.Year - dtp_NgaySinh.Value.Year < 18)
                {
                    MessageBox.Show("Nhân viên chưa 18 tuổi .");
                    return;
                }else if (_check.checkRong(cbb_chucvu.Text) == false)
                {
                    MessageBox.Show("Mời bạn  điền chức vụ cho nhân viên.");
                    return;
                }else if(_Invs.GetAllNV().Any(c => c.SDT == Convert.ToString( txt_sdt.Text) == true))
                {
                    MessageBox.Show("Số điện thoại này đã có .");
                    return;
                } else if(_Invs.GetAllNV().Any(c => c.Email == Convert.ToString(txt_Email.Text) == true)) 
                {
                    MessageBox.Show("Email đã có . Mời bạn nhập email khác .");
                    return;
                }
                else if (_check.CheckSDT(txt_sdt.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng dạng của SĐT.");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm nhân viên này không ? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        MessageBox.Show(_Invs.AddNV(new NhanVien()
                        {
                            ID = Guid.NewGuid(),
                            MaNV = "NV" + Convert.ToString(_Invs.GetAllNV().Count + 1),
                            Ten = txt_TenNV.Text,
                            GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nữ",
                            NgaySinh = dtp_NgaySinh.Value.Date,
                            DiaChi = txt_DiaChi.Text,
                            Email = txt_Email.Text,
                            SDT = txt_sdt.Text,
                            MatKhau = txt_matkhau.Text,
                            IDCV = _Icvs.GetAllCV().Where(c => c.TenCV == Convert.ToString(cbb_chucvu.Text)).Select(c => c.IDcv).FirstOrDefault(),
                            TrangThai = (check_hd.Checked == true ? "Hoat Dong" : "Khong Hoat Dong"),
                        }));
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại.");
                    }
                }
            }catch
            {

            }
           
        }

        private void ptb_capnhat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cap nhat nhân viên này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(_Invs.UpdateNV( id ,new NhanVien()
                {
                    MaNV = txt_MaNV.Text,
                    Ten = txt_TenNV.Text,
                    GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nữ",
                    NgaySinh = dtp_NgaySinh.Value.Date,
                    DiaChi = txt_DiaChi.Text,
                    Email = txt_Email.Text,
                    SDT = txt_sdt.Text,
                    MatKhau = txt_matkhau.Text,
                    IDCV = _Icvs.GetAllCV().Where(c => c.TenCV == Convert.ToString(cbb_chucvu.Text)).Select(c => c.IDcv).FirstOrDefault(),
                    TrangThai = (check_hd.Checked == true ? "Hoạt động" : "Không hoạt động"),
                }));
                LoadNV();
            }
            else
            {
                MessageBox.Show("Cap nhat nhân viên thất bại.");
            }
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xoá nhân viên này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(_Invs.DeleteNV(id));
                LoadNV();
            }
            else
            {
                MessageBox.Show("Xoa nhân viên thất bại.");
            }
        }

        private void ptb_addchucvu_Click(object sender, EventArgs e)
        {
            FrmChucVu frmChucVu = new FrmChucVu();
            frmChucVu.ShowDialog();
        }

        private void ptb_refesh_Click(object sender, EventArgs e)
        {
            cbb_chucvu.Items.Clear();
            LoadChucVu();
        }

        private void dtgrid_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow r = dtgrid_nhanvien.Rows[e.RowIndex];
                id = Guid.Parse(r.Cells[0].Value.ToString());
                txt_MaNV.Text = Convert.ToString(r.Cells[1].Value);
                txt_TenNV.Text = Convert.ToString(r.Cells[2].Value);
                rbtn_Nam.Checked = r.Cells[3].Value.ToString() == "Nam";
                rbtn_Nữ.Checked = r.Cells[3].Value.ToString() == "Nữ";
                dtp_NgaySinh.Text = r.Cells[4].Value.ToString();
                txt_DiaChi.Text = Convert.ToString(r.Cells[5].Value);
                txt_sdt.Text = Convert.ToString(r.Cells[6].Value);
                txt_Email.Text = Convert.ToString(r.Cells[7].Value);
                txt_matkhau.Text = Convert.ToString(r.Cells[8].Value);
                cbb_chucvu.Text = Convert.ToString(r.Cells[9].Value);
                check_hd.Checked = (r.Cells[10].Value.ToString()) == "Hoạt động";
                check_khd.Checked = (r.Cells[10].Value.ToString()) == "Không hoạt động";

        }

        private void check_hd_CheckedChanged(object sender, EventArgs e)
        {
            if(check_hd.Checked == true)
            {
                check_khd.Checked = false;
            }
            if(check_hd.Checked == false)
            {
                check_khd.Checked = true;
            }
           
        }

        private void check_khd_CheckedChanged(object sender, EventArgs e)
        {
            if (check_khd.Checked == true)
            {
                check_hd.Checked = false;
            }
            if (check_khd.Checked == false)
            {
                check_hd.Checked = true;
            }
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
