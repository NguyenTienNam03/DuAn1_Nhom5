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
    public partial class FrmThongKe : Form
    {
        public IHoaDonCTService _ihdcts;
        public IHoaDonService _ihdds;
        public IChiTietSPService _ictsp;
        public int soluong = 0;
        public int hoadoncho = 0;
        public int hoadonthanhcong = 0;
        public int hoadonhuy = 0;
        public double doanhthu = 0;
        public int tong = 0;
        public FrmThongKe()
        {
            InitializeComponent();
            _ictsp = new ChiTietSPService();
            _ihdcts= new HoaDonCTService();
            _ihdds = new HoaDonService();
            LoadHoaDonTheoNgay();
        }
        public void LoadHoaDonTheoNgay()
        {
            dtgridview_theongay.Rows.Clear();
            foreach(var x in _ihdds.GetAllhd().Select(c => c.NgayTao.Value.Date).Distinct())
            {
                var sp = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x.Date).Sum(c => c.SoLuong);
                var hdc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x.Date && c.TrangThai == "Chờ thanh toán").Count();
                var hdtc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x.Date && c.TrangThai == "Đã thanh toán").Count();
                var huy = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x.Date && c.TrangThai == "Huỷ").Count();
                var dt = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x.Date).Sum(c => c.DonGia);
                var t = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x.Date).Count();
                tong = t;
                doanhthu = Convert.ToDouble(dt);
                hoadoncho = hdc;
                hoadonthanhcong = hdtc;
                soluong = Convert.ToInt32(sp);
                dtgridview_theongay.Rows.Add(x.ToString("dd/MM/yyyy"), soluong ,hoadonthanhcong , hoadoncho ,huy ,tong ,doanhthu);
            }
            lb_tongsp.Text = _ihdds.GetAllhd().Sum(c => c.SoLuong).ToString();
            lb_tongdoanhthu.Text = _ihdds.GetAllhd().Sum(c => c.DonGia).ToString();
            lb_tonghoadatt.Text = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Count().ToString();
            lb_tonghdcho.Text = _ihdds.GetAllhd().Where(c => c.TrangThai == "Chờ thanh toán").Count().ToString();
        }

        private void check_homnay_Click(object sender, EventArgs e)
        {
            dtgridview_theongay.Rows.Clear();
            foreach (var x in _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date).Distinct())
            {
                var sp = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date).Sum(c => c.SoLuong);
                var hdc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date && c.TrangThai == "Chờ thanh toán").Count();
                var hdtc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date && c.TrangThai == "Đã thanh toán").Count();
                var huy = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date && c.TrangThai == "Huỷ").Count();
                var dt = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date).Sum(c => c.DonGia);
                var t = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == DateTime.Now.Date).Count();
                tong = t;
                doanhthu = Convert.ToDouble(dt);
                hoadoncho = hdc;
                hoadonthanhcong = hdtc;
                soluong = Convert.ToInt32(sp);
                dtgridview_theongay.Rows.Add(x.NgayTao.Value.Date.ToString("dd/MM/yyyy"), soluong, hoadonthanhcong, hoadoncho, huy, tong, doanhthu);
            }
        }

        private void check_all_Click(object sender, EventArgs e)
        {
            LoadHoaDonTheoNgay();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtgridview_theongay.Rows.Clear();
            var ngay = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date.ToString("dd//MM/yyyy") == dateTimePicker1.Value.Date.ToString("dd//MM/yyyy"));
            foreach (var x in ngay.Distinct())
            {
                var sp = _ihdds.GetAllhd().Sum(c => c.SoLuong);
                var hdc = _ihdds.GetAllhd().Where(c =>  c.TrangThai == "Chờ thanh toán").Count();
                var hdtc = _ihdds.GetAllhd().Where(c =>  c.TrangThai == "Đã thanh toán").Count();
                var huy = _ihdds.GetAllhd().Where(c =>  c.TrangThai == "Huỷ").Count();
                var dt = _ihdds.GetAllhd().Sum(c => c.DonGia);
                var t = _ihdds.GetAllhd().Count();
                tong = t;
                doanhthu = Convert.ToDouble(dt);
                hoadoncho = hdc;
                hoadonthanhcong = hdtc;
                soluong = Convert.ToInt32(sp);
                dtgridview_theongay.Rows.Add(x.NgayTao.Value.Date.ToString("dd/MM/yyyy"), soluong, hoadonthanhcong, hoadoncho, huy, tong, doanhthu);
            }
        }
    }
}
