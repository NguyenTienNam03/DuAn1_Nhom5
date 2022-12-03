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
    public partial class frmMauSac : Form
    {
        public IMauSacService _imausac;
        public Validate _check;
        public Guid id;
        public frmMauSac()
        {
            InitializeComponent();
            _imausac= new MauSacService();
            loadms();
            _check=new Validate();
            txt_mamau.Enabled= false;
        }
        public void reset()
        {
            txt_mamau.Text = "";
            txt_mau.Text = "";
        }
        public void loadms()
        {
            int stt = 1;

            dt_mausac.Rows.Clear();
            dt_mausac.Columns[1].Visible = false;
            foreach(var x in _imausac.GetAllMS())
            {
                dt_mausac.Rows.Add(stt++ , x.IDms , x.MaMau ,x.Mau);
            }
        }
        private void ptb_them_Click(object sender, EventArgs e)
        {
            try
            {
                if(_check.checkRong(txt_mau.Text) == false)
                {
                    MessageBox.Show("Mời bạn điền màu sắc.");
                    return;
                } else if(_imausac.GetAllMS().Any(c => c.Mau == Convert.ToString(txt_mau.Text) == true))
                {
                    MessageBox.Show("Màu sắc đã có .");
                    return;
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm màu này không ? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_imausac.AddMauSac(new A_DAL.Models.MauSac()
                        {
                            ID = Guid.NewGuid(),
                            MaMau = "MS" + Convert.ToString(_imausac.GetAllMS().Count + 1),
                            Mau = txt_mau.Text,
                        }));
                        loadms();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm màu thất bại.");
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

        private void ptb_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (_check.checkRong(txt_mau.Text) == false)
                {
                    MessageBox.Show("Mời bạn điền màu sắc .");
                    return;
                }
                else
                { 
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin màu này không ? ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_imausac.UpdateMauSac(id , new A_DAL.Models.MauSac()
                        {
                            //ID = Guid.NewGuid(),
                            MaMau = txt_mamau.Text,
                            Mau = txt_mau.Text,
                        }));
                        loadms();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin màu thất bại.");
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
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá màu này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_imausac.DeleteMauSac(id));
                    loadms();
                    reset();
                }
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }

        private void dt_mausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dt_mausac.Rows[e.RowIndex];
                id = Guid.Parse(r.Cells[1].Value.ToString());
                txt_mamau.Text = Convert.ToString(r.Cells[2].Value);
                txt_mau.Text = Convert.ToString(r.Cells[3].Value);
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
        }
    }
}
