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
    public partial class FrmSoLuong : Form
    {
        public static int soluong = 0;
        public static Guid idspct;
        public IChiTietSPService _ictsp;
        public int soluongconlai = 0;
        public Validate _check;

        public FrmSoLuong()
        {
            InitializeComponent();
            loadidsp();
            lb_idsp.Visible = false;
            _check = new Validate();
            _ictsp = new ChiTietSPService();
        }
        public void loadidsp()
        {
            idspct = (FrmBanHang.IDspct);
            lb_idsp.Text = idspct.ToString();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                var a = _ictsp.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(lb_idsp.Text));

                if (_check.CheckSoNguyenduong(txt_nhapsoluong.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng số.");
                    return;
                }
                else
                if (Convert.ToInt32(txt_nhapsoluong.Text) > a.SoLuong)
                {
                    MessageBox.Show($"Số lượng của sản phẩm còn {a.SoLuong} . Mời bạn nhập số lượng lại .");
                    return;

                }
                else
                {
                    soluong = Convert.ToInt32(txt_nhapsoluong.Text);
                    //soluongconlai = Convert.ToInt32(a.SoLuong) - Convert.ToInt32(txt_nhapsoluong.Text);
                    //ChiTietSanPham spct = new ChiTietSanPham()
                    //{
                    //    SoLuong = soluongconlai,
                    //};
                    //_ictsp.UpdateCRSP(Guid.Parse(a.ToString()), spct);

                    this.Close();
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
