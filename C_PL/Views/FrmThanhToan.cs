using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class FrmThanhToan : Form
    {
        public INhanVienService _invs;
        public IHoaDonService _ihoadon;
        public IHoaDonCTService _ihdcts;
        public IKhachHangService _ikhs;
        public IChiTietSPService _ictsp;
        public IMauSacService _imss;
        public ISanPhamService _isps;
        public ISizeService _isize;

        public double tienthua = 0;
        public double Tongtien = 0;
        public double Thue = 0;
        public double tinhtien = 0;
        public FrmThanhToan()
        {
            InitializeComponent();
            _invs= new NhanVienService();
            _ikhs = new KhachHangService();
            _ihdcts = new HoaDonCTService();
            _ihoadon = new HoaDonService();
            _ictsp = new ChiTietSPService();
            _imss = new MauSacService();
            _isize = new SizeService();
            _isps = new SanPhamService();
            laymanv();
            laymahd();
            loadhdct();
            //txt_tongtien.Enabled= false;
        }
        public void loadhdct()
        {
            dt_hdct.Columns[0].Visible = false;
            var idhd1 = _ihoadon.GetAllhd().Where(c => c.Mahd == lb_mahd.Text).Select(c => c.IDhd).FirstOrDefault();
            foreach (var x in _ihdcts.GetAllHDCT().Where(c => c.IDHD == (idhd1)))
            {
                var idctsp = _ictsp.GetAll().FirstOrDefault(c => c.ID == x.IDSP);
                var tensp = _isps.GetAllsp().FirstOrDefault(c => c.IDsp == idctsp.IDSP);
                var mausac = _imss.GetAllMS().FirstOrDefault(c => c.IDms == idctsp.IDms);
                var size = _isize.GetSizes().FirstOrDefault(c => c.id == idctsp.IDSize);

                dt_hdct.Rows.Add(idctsp.ID, tensp.TenSp, mausac.Mau, size.SoSize, x.SoLuong, idctsp.GiaBan, x.SoLuong * idctsp.GiaBan); // truyền số lượng từ form số lượng qua 
            }


            tinhtien = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(idhd1.ToString())).Sum(c => Convert.ToDouble(c.SoLuong * c.DonGia));
           
            Thue = tinhtien * 0.1;
            lb_tongtiensp.Text = tinhtien.ToString();
            Tongtien = (Convert.ToDouble(lb_tongtiensp.Text) + Convert.ToDouble(Thue));
            lb_tongtien.Text = Tongtien.ToString();
            
        }
        public void laymahd()
        {
            var a = _ihoadon.GetAllhd().Where(c => c.IDhd == FrmBanHang.laymahd).Select(c => c.Mahd).FirstOrDefault();
            lb_mahd.Text = a.ToString();
            var b = _ikhs.GetAllKH().Where(c => c.ID == FrmBanHang.layidkh).Select(c => c.TenKH).FirstOrDefault();
            lb_tenkh.Text = b.ToString();
        }
        public void laymanv()
        {
            var a = _invs.GetAllNV().Where(c => c.Email == Login.layEmail).Select(c => c.MaNV).FirstOrDefault();
            lb_manv.Text = a.ToString();
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
                else if (Convert.ToDouble(lb_tientrakhach.Text) < 0 )
                {
                    MessageBox.Show($"Khách hàng còn thiếu {lb_tientrakhach.Text} tiền .");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn in hoá đơn không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("In hoá đơn thành công .");
                    }
                    else
                    {

                    }
                    var idhd = _ihoadon.GetAllhd().Where(c => c.Mahd == Convert.ToString(lb_mahd.Text)).Select(c => c.IDhd).FirstOrDefault();
                    HoaDon hd = new HoaDon()
                    {
                        IDNV = _invs.GetAllNV().Where(c => c.MaNV == lb_manv.Text).Select(c => c.ID).FirstOrDefault(),
                        SoLuong = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(idhd.ToString())).Sum(c => c.SoLuong),
                        DonGia = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(idhd.ToString())).Sum(c => c.SoLuong * c.DonGia),
                        TrangThai = "Đã thanh toán",
                        NgayThanhToan = DateTime.Now,
                    };
                    _ihoadon.UpdateHoaDon(idhd, hd);
                    MessageBox.Show("Thanh toán thành công .");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
            

        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            lb_tientrakhach.Text = Convert.ToString(Convert.ToDouble(txt_tienkhachdua.Text) - Convert.ToDouble(lb_tongtien.Text));
            if (Convert.ToDouble(lb_tientrakhach.Text) < 0)
            {
                lb_tientrakhach.ForeColor = Color.Red;

            }
            else
            {
                lb_tientrakhach.ForeColor = Color.Blue;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
