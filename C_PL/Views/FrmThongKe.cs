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
                dtgridview_theongay.Rows.Add(x.ToString(), soluong, hoadonthanhcong, hoadoncho, huy, tong, doanhthu);
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
                dtgridview_theongay.Rows.Add(x, soluong, hoadonthanhcong, hoadoncho, huy, tong, doanhthu);
            }
        }
        public void Loadthongkesp()
        {
            // load lên thông kê sản phẩm
            int stt = 1;
            dtgrid_thongkesp.Rows.Clear();

            var layidhd = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Select(c => c.IDhd).FirstOrDefault();
            var layidhdct = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(layidhd.ToString())).Select(c => c.IDSP).FirstOrDefault();
            var layidsp = _ictsp.GetAll().Select(c => c.ID == layidhdct);


            var soluong1 = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Sum(c => c.SoLuong);
            lb_tongsanpham.Text = soluong1.ToString();
            var doanhso = _ihdds.GetAllhd().Where(c => c.TrangThai == "Đã thanh toán").Sum(c => c.DonGia);
            lb_tongdt.Text = doanhso.ToString();


            var soluong = (from n in _ihdcts.GetAllHDCT()
                           join m in _ihdds.GetAllhd() on n.IDHD equals m.IDhd
                           join h in _ictsp.GetAll() on n.IDSP equals h.ID
                           where m.TrangThai == "Đã thanh toán" 
                           select new
                           {
                               n,
                               m,
                               h,
                           }).ToList();
            var a = (from y in _isps.GetAllsp()
                     join z in _ictsp.GetAll() on y.IDsp equals z.IDSP
                     select new
                     {
                         y,
                         z,
                     }).ToList();
            foreach (var x in a)
            {
                foreach (var l in soluong)
                {
                    dtgrid_thongkesp.Rows.Add(stt++, x.z.MaCTSP , x.y.TenSp, l.m.SoLuong, l.m.DonGia);
                }
            }
        }
        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
