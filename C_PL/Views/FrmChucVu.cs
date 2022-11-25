using B_BUS.IServices;
using A_DAL.Models;
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
    public partial class FrmChucVu : Form
    {
        private IChucVuService _ICVs;
        private Guid ID;
        public FrmChucVu()
        {
            InitializeComponent();
            _ICVs = new ChucVuService();
            LoadCV();
            //txt_macv.Enabled = false;
        }

        public void LoadCV()
        {
            int stt = 1;
            dtgrid_chucvu.ColumnCount = 4;
            dtgrid_chucvu.Columns[0].Name = "STT";
            dtgrid_chucvu.Columns[1].Name = "ID";
            dtgrid_chucvu.Columns[1].Visible = false;
            dtgrid_chucvu.Columns[2].Name = "Ma CV";
            dtgrid_chucvu.Columns[3].Name = "CV";
            dtgrid_chucvu.Rows.Clear();
            foreach(var x in _ICVs.GetAllCV().OrderBy(c => c.MaCV))
            {
                dtgrid_chucvu.Rows.Add(stt++ , x.IDcv , x.MaCV , x.TenCV);
            }
        }
        //public string CatChuoi(string chuoi)
        //{
        //    string chuoigoc = txt_tencv.Text;
        //    string[] tu = chuoi.Split(' ');
        //    int len = tu.Length;
        //    for(int i = 0; i < len -1 ; i++)
        //    {
        //        chuoigoc += tu[i].Substring(0, 1).ToLower();
        //    }
        //    chuoigoc += tu[len - 1];
        //    return chuoigoc;
        //}
        private void ptb_add_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon add cv nay khong ?", "Thong Bao", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_ICVs.AddChucVu(new ChucVu()
                {
                    ID = Guid.NewGuid(),
                    MaCV  = /*CatChuoi*/(txt_macv.Text) ,
                    TenCV = txt_tencv.Text,
                }));
                LoadCV();
                
            }
            else
            {
                MessageBox.Show("Add that bai.");
            }
        }

        private void ptb_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon update chuc vu nay khong ?", "Thong bao",MessageBoxButtons.YesNo) ;
            if(dialogResult == DialogResult.Yes)
            { 
                //var layID = _ICVs.chucVuViews().FirstOrDefault(p=>p.ID)
                MessageBox.Show(_ICVs.UpdateChucVu(ID, new ChucVu()
                {
                    MaCV= txt_macv.Text ,
                    TenCV= txt_tencv.Text,
                }));
                LoadCV();
            }
            else
            {
                MessageBox.Show("Update that bai.");
            }
        }

        private void ptb_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban muon delete chuc vu nay khong ?", "Thong Bao",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_ICVs.DeleteChucVu(ID));
                LoadCV();
            }
            else
            {
                MessageBox.Show("Delete That bai.");
            }

        }

        private void dtgrid_chucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row == -1) return;
                ID = Guid.Parse(Convert.ToString(dtgrid_chucvu.Rows[row].Cells[1].Value));
                txt_macv.Text = Convert.ToString(dtgrid_chucvu.Rows[row].Cells[2].Value);
                txt_tencv.Text = Convert.ToString(dtgrid_chucvu.Rows[row].Cells[3].Value);
            }
            catch
            {
                MessageBox.Show("Ban phai click vao o chua du lieu.");
            }
           
        }
    }
}
