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
    public partial class FrmHangSX : Form
    {
        public IHangSanXuatService _ihsx;
        public Guid id;
        public Validate _check;
        public FrmHangSX()
        {
            InitializeComponent();
            _check= new Validate();
            _ihsx = new HangSanXuatService();
            txt_ma.Enabled= false;
            LoadHSX();

        }
        public void Reset()
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
        }
        public void LoadHSX()
        {
            int stt = 1;
            dt_nhsx.Rows.Clear();
            foreach(var x in _ihsx.GetAllHSX())
            {
                dt_nhsx.Rows.Add(stt++, x.ID, x.Mahsx, x.TenHSX);
            }
        }
        private void ptb_them_Click(object sender, EventArgs e)
        {
            try
            {
                if(_check.checkRong(txt_ten.Text) == false)
                {
                    MessageBox.Show("Bạn bỏ trống tên HSX.");
                    return;
                }else if (_ihsx.GetAllHSX().Any(c => c.TenHSX == Convert.ToString(txt_ten.Text)) == true)
                {
                    MessageBox.Show("HSX này đã có trong danh sách.");
                    return;
                }else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm HSX này không ?","Thông báo", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_ihsx.AddHSX(new A_DAL.Models.HangSanXuat()
                        {
                            ID = Guid.NewGuid(),
                            MaHangSX = "HSX" + Convert.ToString(_ihsx.GetAllHSX().Count + 1),
                            TenHSX = Convert.ToString(txt_ten.Text),
                        }));
                        LoadHSX();
                        Reset();
                    } else
                    {
                        MessageBox.Show("Thêm HSX thất bại.");
                        return;
                    }
                }
            }catch 
            {
                MessageBox.Show("Bạn thao tác lại.");
                return;
            }
        }

        private void ptb_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (_check.checkRong(txt_ten.Text) == false)
                {
                    MessageBox.Show("Bạn bỏ trống tên HSX.");
                    return;
                }

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa HSX này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_ihsx.UpdateHsx(id, new A_DAL.Models.HangSanXuat()
                        {
                            //ID = Guid.NewGuid(),
                            MaHangSX = txt_ma.Text,
                            TenHSX = Convert.ToString(txt_ten.Text),
                        }));
                        LoadHSX();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa HSX thất bại.");
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
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá HSX này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_ihsx.RemoveHSX(id));
                    LoadHSX();
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }

        private void dt_nhsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dt_nhsx.Rows[e.RowIndex];
                id = Guid.Parse(r.Cells[1].Value.ToString());
                txt_ma.Text = Convert.ToString(r.Cells[2].Value);
                txt_ten.Text = Convert.ToString(r.Cells[3].Value);
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }
    }
}
