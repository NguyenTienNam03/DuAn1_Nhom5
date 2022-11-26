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
    public partial class FrmThanhToan : Form
    {
        public double tienthua ;
        public double Tongtien;
        public FrmThanhToan()
        {
            InitializeComponent();
            //txt_tongtien.Enabled= false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double thue = Convert.ToDouble(txt_tongtiensp.Text) * 0.1;
            Tongtien = thue + Convert.ToDouble(txt_tongtiensp.Text);
            txt_tongtien.Text = Tongtien.ToString();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tienkhachdua.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số tiền khách đưa.");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn in hoá đơn không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                    }
                    MessageBox.Show("Thanh toán thành công .");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
            

        }

        private void txt_tientrakhach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tienthua = Convert.ToDouble(txt_tienkhachdua.Text) - Convert.ToDouble(txt_tongtien.Text);

                txt_tientrakhach.Text = tienthua.ToString();
                
                if (Convert.ToDouble(txt_tientrakhach.Text) < 0 )
                {
                    MessageBox.Show($"Khách hàng còn thiếu {txt_tientrakhach.Text} không thể thanh toán được .");
                    txt_tientrakhach.ForeColor= Color.Red;
                    btn_thanhtoan.Enabled = false;
                    return;
                }else
                {
                    txt_tientrakhach.ForeColor = Color.Blue;
                    btn_thanhtoan.Enabled = true;

                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
            
        }

    }
}
