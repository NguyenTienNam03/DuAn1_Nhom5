using A_DAL.IRepositorys;
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
    public partial class FrmQLNhanVien : Form
    {
        private IChucVuService _Icvs;
        private INhanVienService _Invs;
        private Guid id;

        public FrmQLNhanVien()
        {
            InitializeComponent();
            _Icvs = new ChucVuService();
            _Invs = new NhanVienService();
            LoadChucVu();
            //txt_MaNV.Enabled= false;
            LoadNV(); 
            check_hd.Checked = true ;
        }
        public void LoadNV()
        {
            dtgrid_nhanvien.Rows.Clear();
            foreach(var x in _Invs.GetAllNV())
            {
                var y = _Icvs.GetAllCV().FirstOrDefault(c => c.IDcv == x.IDCV);
                dtgrid_nhanvien.Rows.Add(x.MaNV, x.Ten, x.GioiTinh, x.NgaySinh, x.DiaChi, x.SDT, x.Email, x.MatKhau, y.TenCV, x.TrangThai);
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
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm nhân viên này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(_Invs.AddNV(new NhanVien()
                {
                    ID = Guid.NewGuid(),
                    MaNV = txt_MaNV.Text ,
                    //MaNV = "NV" + Convert.ToString(_Invs.GetAllNV().Max(c => Convert.ToInt32(c.MaNV.Substring( 2 ,c.MaNV.Length - 2)) + 1)), //Loi phan tu dong sinh
                    Ten = txt_TenNV.Text,
                    GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nữ",
                    NgaySinh =dtp_NgaySinh.Value.Date,
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

        private void ptb_capnhat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn cap nhat nhân viên này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(_Invs.UpdateNV( id ,new NhanVien()
                {
                    //ID = Guid.NewGuid(),
                    MaNV = txt_MaNV.Text,
                    //MaNV = "NV" + Convert.ToString(_Invs.GetAllNV().Max(c => Convert.ToInt32(c.MaNV.Substring( 2 ,c.MaNV.Length - 2)) + 1)), //Loi phan tu dong sinh
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
                MessageBox.Show("Cap nhat nhân viên thất bại.");
            }
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xoa nhân viên này không ? ", "Thông báo", MessageBoxButtons.YesNo);
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
            int r = e.RowIndex;
            if (r == -1) return;
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_TenNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[1].Value);
            rbtn_Nam.Checked = dtgrid_nhanvien.Rows[r].Cells[2].Value ==  "Nam" ;
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);
            txt_MaNV.Text = Convert.ToString(dtgrid_nhanvien.Rows[r].Cells[0].Value);


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
    }
}
