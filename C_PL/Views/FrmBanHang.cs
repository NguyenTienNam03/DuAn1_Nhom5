﻿using A_DAL.Models;
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
        public IHoaDonService _ihds;
        public double _tongtien;
        
        public FrmBanHang()
        {
            InitializeComponent();
            _ictsp= new ChiTietSPService();
            _ikhs = new KhachHangService();
            _ihsxs = new HangSanXuatService();
            _isize = new SizeService();
            _isps = new SanPhamService();
            _imss= new MauSacService();
            _lstgiohang = new List<GioHangCT>();
            _ihds = new HoaDonService();
            dtgrid_giohang.Columns[0].Visible = false;
            LoadSpCT();
            LoadMS();
            LoadSize();
            Loadhsx();
            LoadKH();
            lb_tongtien.Text = _tongtien.ToString();
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
            dtgrid_khachhang.Columns[0].Visible=false;
            foreach(var x in _ikhs.GetAllKH())
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
            
            foreach(var x in _ictsp.GetAll())
            {
                var s = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var ms = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var sp = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);
                
                dtgrid_giohang.Rows.Add(x.ID , sp.TenSp , ms.Mau , s.SoSize , x.SoLuong , x.GiaBan , x.SoLuong * x.GiaBan );
                //lb_tongtien.Text = 
            }
            
        }
        public void LoadSpCT()
        {
            dtgrid_sp.Rows.Clear();
            dtgrid_sp.Columns[0].Visible = false;
            foreach(var x in _ictsp.GetAll())
            {
                var y = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);
                var z = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var a = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var b = _ihsxs.GetAllHSX().Find(c => c.ID == x.IDHSX);
                dtgrid_sp.Rows.Add(x.ID, x.MaCTSP, y.TenSp,b.TenHSX , z.Mau, a.SoSize, x.SoLuong, x.GiaBan);
            }
        }
        private void dtgrid_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sll = 1;
            DataGridViewRow r = dtgrid_sp.Rows[e.RowIndex];
            //if (dtgrid_sp.Rows[e.RowIndex].Cells[e.ColumnIndex].)
            dtgrid_giohang.Rows.Add(r.Cells[0].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString(), sll, r.Cells[7].Value.ToString(), Convert.ToDouble(sll) * Convert.ToDouble(r.Cells[7].Value.ToString()));
        }
        

        private void ptb_themgiohang_Click(object sender, EventArgs e)
        {

            
        }

        private void dtgrid_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtgrid_giohang.Rows[e.RowIndex];
            _id = Guid.Parse(r.Cells[0].Value.ToString());

        }

        private void dtgrid_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var x = _lstgiohang.FirstOrDefault(c => c.IDSP == Guid.Parse(dtgrid_giohang.Rows[e.RowIndex].Cells[0].Value.ToString()));
            var x = _lstgiohang.FirstOrDefault(c => c.IDSP == _id);
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Ban co muon xoa san pham nay khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _lstgiohang.Remove(x);
                    LoadGioHang();
                    foreach (DataGridViewCell onecell in dtgrid_giohang.SelectedCells)
                    {
                        if (onecell.Selected)
                        {
                            dtgrid_giohang.Rows.RemoveAt(onecell.RowIndex);
                        }
                    }
                }
            }
            
        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            if (_lstgiohang.Any())
            {
                HoaDon Hoadon = new HoaDon()
                {
                    ID = Guid.NewGuid(),
                    MaHD = "HD" + Convert.ToString(_ihds.GetAllhd().Max(c => Convert.ToInt32(c.Mahd.Substring(2 ,c.Mahd.Length)) + 1)),
                    TrangThai = "",
                };
                _ihds.AddHoaDon(Hoadon);
                foreach(var x in _lstgiohang)
                {
                    HoaDonCT hdct = new HoaDonCT()
                    {
                        //IDHD = hdct.IDHD,
                        //IDSP = hdct.IDSP,
                        //SoLuong = x.SoLuong,
                        //DonGia = x.DonGia,
                    };
                    
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
    }
}
