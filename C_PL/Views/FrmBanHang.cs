using A_DAL.Models;
using Accessibility;
using B_BUS.IServices;
using B_BUS.Services;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class FrmBanHang : Form
    {
        public IKhachHangService _ikhs;
        public IChiTietSPService _ictsp;
        public ISanPhamService _isps;
        public IMauSacService _imss;
        public IHangSanXuatService _ihsxs;
        public ISizeService _isize;
        public List<GioHangCT> _lstgiohang;
        public GioHang _giohang;
        public Guid _id;
        public IHoaDonCTService _ihdcts;
        public IHoaDonService _ihds;
        public INhanVienService _invs;
        public IGioHangCTService _ighcts;
        public double thanhtien = 0;
        public double trutien = 0;

        public FrmBanHang()
        {
            InitializeComponent();
            _ictsp = new ChiTietSPService();
            _ighcts = new GioHangCTService();
            _ikhs = new KhachHangService();
            _ihsxs = new HangSanXuatService();
            _isize = new SizeService();
            _ihdcts = new HoaDonCTService();
            _isps = new SanPhamService();
            _invs = new NhanVienService();
            _imss = new MauSacService();
            _lstgiohang = new List<GioHangCT>();
            _ihds = new HoaDonService();
            dtgrid_giohang.Columns[0].Visible = false;
            LoadSpCT();
            LoadMS();
            LoadSize();
            Loadhsx();
            LoadKH();

            //LoadGioHang();
            _giohang = new GioHang()
            {
                ID = Guid.NewGuid(),
            };

            label1.Text = Login.layEmail; //add thử Email vào label
        }

        public void LoadKH()
        {
            dtgrid_khachhang.Rows.Clear();
            dtgrid_khachhang.Columns[0].Visible = false;
            foreach (var x in _ikhs.GetAllKH())
            {
                dtgrid_khachhang.Rows.Add(x.ID, x.TenKH, x.SDT, x.DiaChi);
            }
        }
        public void Loadhsx()
        {
            foreach (var x in _ihsxs.GetAllHSX())
            {
                cbb_nhasx.Items.Add(x.TenHSX);
            }
        }
        public void LoadSize()
        {
            foreach (var x in _isize.GetSizes())
            {
                cbb_size.Items.Add(x.SoSize);
            }
        }
        public void LoadMS()
        {
            foreach (var x in _imss.GetAllMS())
            {
                cbb_mausac.Items.Add(x.Mau);
            }
        }
        public void LoadGioHang()
        {
            dtgrid_giohang.Rows.Clear();

            foreach (var x in _ictsp.GetAll())
            {
                var s = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var ms = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var sp = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);

                dtgrid_giohang.Rows.Add(x.ID, sp.TenSp, ms.Mau, s.SoSize, x.SoLuong, x.GiaBan, x.SoLuong * x.GiaBan);
            }

        }
        public void LoadSpCT()
        {
            dtgrid_sp.Rows.Clear();
            dtgrid_sp.Columns[0].Visible = false;
            foreach (var x in _ictsp.GetAll())
            {
                var y = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);
                var z = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var a = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var b = _ihsxs.GetAllHSX().Find(c => c.ID == x.IDHSX);
                dtgrid_sp.Rows.Add(x.ID, x.MaCTSP, y.TenSp, b.TenHSX, z.Mau, a.SoSize, x.SoLuong, x.GiaBan);
            }
        }
        private void dtgrid_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrid_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dtgrid_giohang.Rows[e.RowIndex];
                _id = Guid.Parse(r.Cells[0].Value.ToString());
                if (e.RowIndex > 0)
                {
                    trutien = Convert.ToDouble(dtgrid_giohang.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Giỏ hàng chưa có sản phẩm .");
            }


        }

        private void dtgrid_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //var x = _lstgiohang.FirstOrDefault(c => c.IDSP == Guid.Parse(dtgrid_giohang.Rows[e.RowIndex].Cells[0].Value.ToString()));
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Ban co muon xoa san pham nay khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //_lstgiohang.Remove(x);
                        foreach (DataGridViewCell onecell in dtgrid_giohang.SelectedCells)
                        {
                            if (onecell.Selected)
                            {
                                dtgrid_giohang.Rows.RemoveAt(onecell.RowIndex);
                                LoadGioHang();
                            }
                        }
                    }
                }
                thanhtien = thanhtien - trutien;
                lb_tongtien.Text = thanhtien.ToString();
            }
            catch
            {
                MessageBox.Show("Giỏ hàng chưa có sản phẩm .");
            }

        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon tao hoa don khong ? ", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lb_tenkh.Text == "")
                {
                    MessageBox.Show("Moi ban chon khach hang de tao hoa don.");
                    return;
                }
                else
                {
                    HoaDon hd = new HoaDon()
                    {
                        ID = Guid.NewGuid(),
                        //MaHD = "HD" + Convert.ToString(_ihds.GetAllhd().Max(c => Convert.ToInt32(c.Mahd.Substring(2, c.Mahd.Length - 2)) + 1)),
                        MaHD = "HD" + Convert.ToString(_ihds.GetAllhd().Count + 1),
                        NgayTao = DateTime.Now.Date,
                        //IDNV = _invs.GetAllNV().Where(c => c.MaNV == Convert.ToString(lb_mahd.Text)).Select(c => c.ID).FirstOrDefault(),
                        IDNV = Guid.NewGuid(),
                        IDKH = _ikhs.GetAllKH().Where(c => c.TenKH == Convert.ToString(lb_tenkh.Text)).Select(c => c.ID).FirstOrDefault(),
                        TrangThai = "",
                    };
                    _ihds.AddHoaDon(hd);
                    lb_mahd.Text = hd.MaHD;
                    //var tenkh = _ikhs.GetAllKH().Where(c => c.ID == hd.IDKH).Select(c => c.TenKH).FirstOrDefault().ToString();
                    //lb_tenkh.Text = tenkh;
                }
            }

}

            private void dtgrid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r == -1) return;
            _id = Guid.Parse(Convert.ToString(dtgrid_khachhang.Rows[r].Cells[0].Value));
            txt_tenkh.Text = Convert.ToString(dtgrid_khachhang.Rows[r].Cells[1].Value);
            txt_sdtkh.Text = Convert.ToString(dtgrid_khachhang.Rows[r].Cells[2].Value);
            txt_diachi.Text = Convert.ToString(dtgrid_khachhang.Rows[r].Cells[3].Value);
        }

        private void dtgrid_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            FrmThanhToan thanhtoan = new FrmThanhToan();
            thanhtoan.ShowDialog();
        }

        private void dtgrid_sp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sll = 1;
            int row = dtgrid_giohang.Rows.Count;
            DataGridViewRow r = dtgrid_sp.Rows[e.RowIndex];
            DialogResult dialogResult = MessageBox.Show("Ban co muon them san pham nay khong ?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var idsp = _ictsp.GetAll().FirstOrDefault(c => c.IDSP == Guid.Parse(r.Cells[0].Value.ToString()));

                //GioHangCT ghct = new GioHangCT()
                //{
                //    IDSP = idsp.ID,
                //    IDGH = Guid.NewGuid(),
                //    SoLuong = 1,
                //    DonGia = idsp.GiaBan,
                //};
                //_ighcts.AddGHCT(ghct);

                for (int i = 0; i < row - 1; i++)
                {
                    thanhtien += double.Parse(dtgrid_giohang.Rows[i].Cells[6].Value.ToString());

                }
                lb_tongtien.Text = thanhtien.ToString();


                dtgrid_giohang.Rows.Add(r.Cells[0].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString(), sll, r.Cells[7].Value.ToString(), Convert.ToDouble(sll) * Convert.ToDouble(r.Cells[7].Value.ToString()));

            }
        }
    }
}
