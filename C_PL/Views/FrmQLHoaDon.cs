using A_DAL.Models;
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
    public partial class FrmQLHoaDon : Form
    {
        public IHoaDonCTService _Ihoadoncts;
        public IKhachHangService _ikhs;
        public INhanVienService _invs;
        public IHoaDonService _ihds;
        public IChiTietSPService _ictsp;
        public ISanPhamService _isps;
        public IMauSacService _imss;
        public ISizeService _isize;
        public List<HoaDon> _lsthoadon;
        public Guid id;
        public FrmQLHoaDon()
        {
            InitializeComponent();
            _ihds = new HoaDonService();
            _Ihoadoncts = new HoaDonCTService();
            _ikhs = new KhachHangService();
            _isize =  new SizeService();
            _invs = new NhanVienService();
            _imss = new MauSacService();
            _lsthoadon = new List<HoaDon>();
            _isps = new SanPhamService();
            _ictsp= new ChiTietSPService();
            LoadHoadon();
            btn_xoahoadon.Visible = false;
        }
        public void Reset()
        {
            rbtn_huy.Checked = false;
            rbtn_dathanhtoan.Checked = false;
            rbt_chothanhtoan.Checked = false;
            btn_all.Checked = false;
            dtview_hdct.Rows.Clear();
        }
        public void LoadHoadon()
        {
            dtgridview_hoadon.Columns[0].Visible = false;
            dtgridview_hoadon.Rows.Clear();
            foreach(var x in _ihds.GetAllhd().OrderByDescending(c => c.NgayTao))
            {
                var kh = _ikhs.GetAllKH().Find(c => c.ID == x.IDkh);
                var soluong = _Ihoadoncts.GetAllHDCT().Where(c => c.IDHD == x.IDhd).Sum(c => c.SoLuong);
                var thanhtien = _Ihoadoncts.GetAllHDCT().Where(c => c.IDHD == x.IDhd).Sum(c => c.SoLuong * c.DonGia);
                dtgridview_hoadon.Rows.Add(x.IDhd, x.Mahd, kh.TenKH, x.NgayTao , soluong , thanhtien ,x.NgayThanhToan , x.TrangThai);
            }
        }
        public void LoadHDhuy()
        {
            if(rbtn_huy.Checked == true)
            {
                dtgridview_hoadon.Columns[0].Visible = false;
                dtgridview_hoadon.Rows.Clear();
                foreach (var x in _ihds.GetAllhd().OrderByDescending(c => c.NgayTao).Where(c => c.TrangThai == "Huỷ"))
                {
                    var kh = _ikhs.GetAllKH().Find(c => c.ID == x.IDkh);
                    dtgridview_hoadon.Rows.Add(x.IDhd, x.Mahd, kh.TenKH, x.NgayTao, x.SoLuong, x.DonGia, x.NgayThanhToan, x.TrangThai);
                }
            }
            else
            {
                LoadHoadon();
            }
        }
        public void LoadHoadoncho()
        {
            if(rbt_chothanhtoan.Checked == true)
            {
                dtgridview_hoadon.Columns[0].Visible = false;
                dtgridview_hoadon.Rows.Clear();
                foreach (var x in _ihds.GetAllhd().OrderByDescending(c => c.NgayTao).Where(c => c.TrangThai == "Chờ thanh toán"))
                {
                    var kh = _ikhs.GetAllKH().Find(c => c.ID == x.IDkh);
                    dtgridview_hoadon.Rows.Add(x.IDhd, x.Mahd, kh.TenKH, x.NgayTao, x.SoLuong, x.DonGia, x.NgayThanhToan, x.TrangThai);
                }
            }else
            {
                LoadHoadon();
            }
        }
        public void LoadHoadondathanhtoan()
        {
            if (rbtn_dathanhtoan.Checked == true)
            {
                dtgridview_hoadon.Columns[0].Visible = false;
                dtgridview_hoadon.Rows.Clear();
                foreach (var x in _ihds.GetAllhd().OrderByDescending(c => c.NgayTao).Where(c => c.TrangThai == "Đã thanh toán"))
                {
                    var kh = _ikhs.GetAllKH().Find(c => c.ID == x.IDkh);
                    dtgridview_hoadon.Rows.Add(x.IDhd, x.Mahd, kh.TenKH, x.NgayTao, x.SoLuong, x.DonGia, x.NgayThanhToan, x.TrangThai);
                }
            }
            else
            {
                LoadHoadon();
            }
        }

        private void dtgridview_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgridview_hoadon.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    return;
                } else
                {
                    DataGridViewRow r = dtgridview_hoadon.Rows[e.RowIndex];
                    var idhd1 = _ihds.GetAllhd().Where(c => c.IDhd == Guid.Parse(r.Cells[0].Value.ToString())).Select(c => c.IDhd).FirstOrDefault();
                    lb_mahoadon.Text = r.Cells[1].Value.ToString();
                    dtview_hdct.Columns[0].Visible = false;
                    // xem hoá đơn chi tiết của một hoá đơn 
                    dtview_hdct.Rows.Clear();
                    foreach (var x in _Ihoadoncts.GetAllHDCT().Where(c => c.IDHD == (idhd1)))
                    {
                        var idctsp = _ictsp.GetAll().FirstOrDefault(c => c.ID == x.IDSP);
                        var tensp = _isps.GetAllsp().FirstOrDefault(c => c.IDsp == idctsp.IDSP);
                        var mausac = _imss.GetAllMS().FirstOrDefault(c => c.IDms == idctsp.IDms);
                        var size = _isize.GetSizes().FirstOrDefault(c => c.id == idctsp.IDSize);

                        dtview_hdct.Rows.Add(idctsp.ID, tensp.TenSp, mausac.Mau, size.SoSize, x.SoLuong, idctsp.GiaBan, x.SoLuong * idctsp.GiaBan);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
        }
        //public void tudonghuy()
        //{
        //    var ngaytao = _ihds.GetAllhd().Where(c => c.IDhd == id).Select(c => c.NgayTao).FirstOrDefault();
        //   ;
        //    if (DateTime.Now.Day - ngaytao.Value.Day == 7)
        //    {
                
        //    }
        //}
        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if(_ihds.GetAllhd().Any(c => c.TrangThai != "Huỷ" ) == true)
                {
                    MessageBox.Show("Sử dụng cho xoá đơn bị huỷ.");
                    return;
                } else 
                if(_ihds.GetAllhd().Any(c => c.TrangThai == "Huỷ") == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá hoá đơn này không ? .", "Thông báo", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_ihds.DeleteHoaDon(id));
                        LoadHoadon();
                        Reset();
                    }
                }else
                {
                    MessageBox.Show("Xoá hoá đơn thất bại.");
                    Reset();
                    return;
                }
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                Reset();
            }
        }

        private void rbtn_thanhtoancho_Click(object sender, EventArgs e)
        {
            LoadHoadoncho();
        }

        private void rbtn_dathanhtoan_Click(object sender, EventArgs e)
        {
            LoadHoadondathanhtoan();
        }

        private void rbtn_huy_Click(object sender, EventArgs e)
        {
            LoadHDhuy();
        }

        private void dtgridview_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgridview_hoadon.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    return;
                }else
                {
                    id = Guid.Parse(dtgridview_hoadon.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
               
            }catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            LoadHoadon();
        }
    }
}
