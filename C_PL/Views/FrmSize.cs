using B_BUS.IServices;
using B_BUS.Services;
using A_DAL.Models;
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
    public partial class FrmSize : Form
    {
        public ISizeService _isize;
        private Guid id;
        public FrmSize()
        {
            InitializeComponent();
            _isize = new SizeService();
            LoadSize();
        }
        public void LoadSize()
        {
            int stt = 1;
            dtgrid_size.Columns[1].Visible = false;
            dtgrid_size.Rows.Clear();
            foreach(var x in _isize.GetSizes())
            {
                dtgrid_size.Rows.Add(stt++,x.id , x.MaSize, x.SoSize);
            }
        }
        private void ptb_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon themu size nay khong ?", "Thong bao", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_isize.AddSize(new A_DAL.Models.Size()
                {
                    ID = Guid.NewGuid(),
                    MaSize = txt_masize.Text ,
                    //MaSize = "S" + Convert.ToString(_isize.GetSizes().Max(c => Convert.ToInt32(c.MaSize.Substring( 1,c.MaSize.Length - 1 )) + 1)),
                    SoSize = Convert.ToInt32(txt_ssize.Text),
                }));
                LoadSize();
            } else
            {
                MessageBox.Show("Them that bai.");
            }
        }

        private void ptb_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon cap nhat size nay khong ?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_isize.UpdateSize(id  ,new A_DAL.Models.Size()
                {
                    //ID = Guid.NewGuid(),
                    MaSize = txt_masize.Text ,
                    SoSize = Convert.ToInt32(txt_ssize.Text),
                }));
                LoadSize();
            }
            else
            {
                MessageBox.Show("Cap Nhat that bai.");
            }
        }

        private void ptb_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon Xoa size nay khong ?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_isize.DeleteSize(id));
                LoadSize();
            }
            else
            {
                MessageBox.Show("Xoa that bai.");
            }
        }

        private void dtgrid_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r == -1) return;
            id = Guid.Parse(Convert.ToString(dtgrid_size.Rows[r].Cells[1].Value));
            txt_masize.Text = Convert.ToString(dtgrid_size.Rows[r].Cells[2].Value);
            txt_ssize.Text = Convert.ToString(dtgrid_size.Rows[r].Cells[3].Value );
        }
    }
}
