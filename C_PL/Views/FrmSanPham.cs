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
    public partial class FrmSanPham : Form
    {
        public ISanPhamService _isps;
        public Guid id;
        public Validate _check;
        public FrmSanPham()
        {
            InitializeComponent();
            _isps= new SanPhamService();
            _check = new Validate();
            txt_masp.Enabled= false;
            LoadSP();
        }
        public void Reset()
        {
            txt_masp.Text = "";
            txt_tensp.Text = "";
        }
        public void LoadSP()
        {
            int stt = 1;
            dtgrid_sp.Rows.Clear();
            dtgrid_sp.Columns[1].Visible = false;
            foreach(var x in _isps.GetAllsp())
            {
                dtgrid_sp.Rows.Add(stt++, x.IDsp, x.Masp, x.TenSp);
            }
        }
        private void dtgrid_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dtgrid_sp.Rows[e.RowIndex];
                id = Guid.Parse(r.Cells[1].Value.ToString());
                txt_masp.Text = Convert.ToString(r.Cells[2].Value);
                txt_tensp.Text = Convert.ToString(r.Cells[3].Value);
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }

        private void ptb_them_Click(object sender, EventArgs e)
        {
            try
            {
                if(_check.checkRong(txt_tensp.Text) == false) 
                {
                    MessageBox.Show("Bạn bỏ trống tên sản phẩm .");
                    return;
                }else if (_isps.GetAllsp().Any(c => c.TenSp == txt_tensp.Text) == true)
                {
                    MessageBox.Show("Sản phẩm đã có trong danh sách.");
                    return;
                }else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_isps.AddSP(new A_DAL.Models.SanPham()
                        {
                            ID = Guid.NewGuid(),
                            MaSP = "SP" + Convert.ToString(_isps.GetAllsp().Count +1 ),
                            TenSP = txt_tensp.Text ,
                        }));
                        LoadSP();
                        Reset();
                    }else
                    {
                        MessageBox.Show("Thêm thất bại.");
                        return;
                    }
                }
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }

        private void ptb_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (_check.checkRong(txt_tensp.Text) == false)
                {
                    MessageBox.Show("Bạn bỏ trống tên sản phẩm .");
                    return;
                }

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_isps.UpdateSp(id, new A_DAL.Models.SanPham()
                        {
                            //ID = Guid.NewGuid(),
                            MaSP = txt_masp.Text,
                            TenSP = txt_tensp.Text,
                        }));
                        LoadSP();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin thất bại.");
                        return;
                    }
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
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_isps.DeleteSP(id));
                    LoadSP();
                    Reset();
                }else
                {
                    MessageBox.Show("Xoá sản phẩm thất bại.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }
    }
}
