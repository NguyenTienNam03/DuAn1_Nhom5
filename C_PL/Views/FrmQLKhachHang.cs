using A_DAL.Repositorys;
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
    public partial class FrmQLKhachHang : Form
    {
        public IKhachHangService _ikhs;
        public Validate _check;
        public Guid id;
        public FrmQLKhachHang()
        {
            InitializeComponent();
            _ikhs = new KhachHangService();
            _check = new Validate();
            txt_makh.Enabled = false;
            LoadKH();
        }
        public void LoadKH()
        {
            dtgrid_khachhang.Rows.Clear();
            dtgrid_khachhang.Columns[0].Visible = false;
            foreach(var x in _ikhs.GetAllKH().OrderBy(c => c.MaKH))
            {
                dtgrid_khachhang.Rows.Add(x.ID, x.MaKH, x.TenKH, x.DiaChi, x.SDT);
            }
        }
        public void Timkiem(string name)
        {
            dtgrid_khachhang.Rows.Clear();
            dtgrid_khachhang.Columns[0].Visible = false;
            foreach (var x in _ikhs.GetAllKH().OrderBy(c => c.MaKH).Where(c => c.TenKH.Contains(name) ||c.SDT.Contains(name)))
            {
                dtgrid_khachhang.Rows.Add(x.ID, x.MaKH, x.TenKH, x.DiaChi, x.SDT);
            }
        }
        private void ptb_them_Click(object sender, EventArgs e)
        {
            try
            {
                if(_check.CheckSDT(txt_sdt.Text) == false)
                {
                    MessageBox.Show("Bạn nhập đúng số điện thoại.");
                    return;
                } else if(_check.checkRong(txt_tenkh.Text) == false)
                {
                    MessageBox.Show("Bạn nhập tên khách hàng .");
                    return;
                } else if (_check.checkRong(txt_DiaChi.Text) == false)
                {
                    MessageBox.Show("Bạn nhập địa chỉ khách hàng.");
                    return;
                } else if(_ikhs.GetAllKH().Any(c => c.SDT == txt_sdt.Text) == true)
                {
                    MessageBox.Show("Số điện thoại đã có trong danh sách , Mời bạn nhập lại số điện thoại.");
                    return;
                }else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm khách hàng này không ?", "Thông báo.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_ikhs.AddKH(new A_DAL.Models.KhachHang()
                        {
                            ID = Guid.NewGuid(),
                            MaKH = "KH" + Convert.ToString(_ikhs.GetAllKH().Count + 1),
                            Ten = txt_tenkh.Text,
                            SDT = txt_sdt.Text,
                            DiaChi = txt_DiaChi.Text,
                        }));
                        LoadKH();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại .");
                    }
                }
               
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }

        }

        private void ptb_capnhat_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin khách hàng này không ?", "Thông báo.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_ikhs.UpdateKH(id , new A_DAL.Models.KhachHang()
                    {
                        //ID = Guid.NewGuid(),
                        MaKH = txt_makh.Text,
                        Ten = txt_tenkh.Text,
                        SDT = txt_sdt.Text,
                        DiaChi = txt_DiaChi.Text,
                    }));
                    LoadKH();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin khách hàng thất bại .");
                }
            }
            catch 
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá khách hàng này không ?", "Thông báo.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_ikhs.DeleteKH(id));
                    LoadKH();
                }
                else
                {
                    MessageBox.Show("Xoá khách hàng thất bại .");
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            Timkiem(txt_timkiem.Text);
        }

        private void dtgrid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dtgrid_khachhang.Rows[e.RowIndex];
                if (r.Cells[0].Value == null)
                {
                    return;
                }else
                {
                    id = Guid.Parse(r.Cells[0].Value.ToString());
                    txt_makh.Text = Convert.ToString(r.Cells[1].Value);
                    txt_tenkh.Text = Convert.ToString(r.Cells[2].Value);
                    txt_DiaChi.Text = Convert.ToString(r.Cells[3].Value);
                    txt_sdt.Text = Convert.ToString(r.Cells[4].Value);
                }
              
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
        }
    }
}
