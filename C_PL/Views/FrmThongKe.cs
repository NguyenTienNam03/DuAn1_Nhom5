using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
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
        public ISanPhamService _isps;
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
            _isps = new SanPhamService();
            _ihdcts= new HoaDonCTService();
            _ihdds = new HoaDonService();
            LoadHoaDonTheoNgay();
            Loadthongkesp();
        }
        public void LoadHoaDonTheoNgay()
        {
            dtgridview_theongay.Rows.Clear();
            foreach(var x in _ihdds.GetAllhd().Select(c => c.NgayTao.Value.Date).Distinct().OrderByDescending(c => c.Date))
            {
                var sp = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x).Sum(c => c.SoLuong);
                var hdc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x && c.TrangThai == "Chờ thanh toán").Count();
                var hdtc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x && c.TrangThai == "Đã thanh toán").Count();
                var huy = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x && c.TrangThai == "Huỷ").Count();
                var dt = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x).Sum(c => c.DonGia);
                var t = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == x).Count();
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
            foreach (var x in _ihdds.GetAllhd().Select(c => c.NgayTao.Value.Date == DateTime.Now.Date).Distinct())
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
                dtgridview_theongay.Rows.Add(DateTime.Now.Date, soluong, hoadonthanhcong, hoadoncho, huy, tong, doanhthu);
            }
        }
        private void check_all_Click(object sender, EventArgs e)
        {
            LoadHoaDonTheoNgay();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtgridview_theongay.Rows.Clear();
            foreach (var x in _ihdds.GetAllhd().Select(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date).Distinct())
            {
                var sp = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date).Sum(c => c.SoLuong);
                var hdc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date && c.TrangThai == "Chờ thanh toán").Count();
                var hdtc = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date && c.TrangThai == "Đã thanh toán").Count();
                var huy = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date && c.TrangThai == "Huỷ").Count();
                var dt = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date).Sum(c => c.DonGia);
                var t = _ihdds.GetAllhd().Where(c => c.NgayTao.Value.Date == dateTimePicker1.Value.Date).Count();
                tong = t;
                doanhthu = Convert.ToDouble(dt);
                hoadoncho = hdc;
                hoadonthanhcong = hdtc;
                soluong = Convert.ToInt32(sp);
                dtgridview_theongay.Rows.Add(dateTimePicker1.Value.Date, soluong, hoadonthanhcong, hoadoncho, huy, tong, doanhthu);
            }
        }
        public void Loadthongkesp()
        {
            int stt = 1;
            // load lên thông kê sản phẩm
            dtgrid_thongkesp.Rows.Clear();
            foreach(var x in _ictsp.GetAll())
            {
                var tensp = _isps.GetAllsp().Where(c => c.IDsp == x.IDSP).Select(c => c.TenSp).Distinct().FirstOrDefault();
                var idhd = _ihdds.GetAllhd().FirstOrDefault(c => c.TrangThai == "Đã thanh toán");
                //var idhd = _ihdds.GetAllhd().Where(c => c.IDhd == )
                
                    var soluongsp = _ihdcts.GetAllHDCT().Where(c => c.IDSP == x.ID).Sum(c => c.SoLuong);
                    var doanhthu = _ihdcts.GetAllHDCT().Where(c => c.IDSP == x.ID).Sum(c => c.SoLuong * c.DonGia);
                    dtgrid_thongkesp.Rows.Add(stt++, x.MaCTSP, tensp, soluongsp, doanhthu);
                
            }
            var tongsoluong = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Sum(c => c.SoLuong);
            var tongdt = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Sum(c => c.DonGia);
            lb_tongsanpham.Text = tongsoluong.ToString();
            lb_tongdt.Text = tongdt.ToString();
        }
        public void Timkiem(string name)
        {
            int stt = 1;
            // load lên thông kê sản phẩm
            dtgrid_thongkesp.Rows.Clear();
            foreach (var x in _ictsp.GetAll().Where(c => c.MaCTSP.Contains(name)))
            {
                var tensp = _isps.GetAllsp().Where(c => c.IDsp == x.IDSP).Select(c => c.TenSp).Distinct().FirstOrDefault();
                var idhd = _ihdds.GetAllhd().FirstOrDefault(c => c.TrangThai == "Đã thanh toán");
                //var idhd = _ihdds.GetAllhd().Where(c => c.IDhd == )

                var soluongsp = _ihdcts.GetAllHDCT().Where(c => c.IDSP == x.ID).Sum(c => c.SoLuong);
                var doanhthu = _ihdcts.GetAllHDCT().Where(c => c.IDSP == x.ID).Sum(c => c.SoLuong * c.DonGia);
                dtgrid_thongkesp.Rows.Add(stt++, x.MaCTSP, tensp, soluongsp, doanhthu);

            }
            var tongsoluong = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Sum(c => c.SoLuong);
            var tongdt = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Sum(c => c.DonGia);
            lb_tongsanpham.Text = tongsoluong.ToString();
            lb_tongdt.Text = tongdt.ToString();
        }
        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            Timkiem(txt_timkiem.Text);
        }
    }
}
