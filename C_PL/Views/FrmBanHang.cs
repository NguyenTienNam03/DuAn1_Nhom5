﻿using A_DAL.Models;
using Accessibility;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.Utilities;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_PL.Views
{
    public partial class FrmBanHang : Form
    {
        public static Guid laymahd ;
        public static Guid layidkh ;
        public static Guid IDspct;
        public IKhachHangService _ikhs;
        public IChiTietSPService _ictsp;
        public ISanPhamService _isps;
        public IMauSacService _imss;
        public IHangSanXuatService _ihsxs;
        public ISizeService _isize;
        public GioHang _giohang;
        public Guid _id;
        public IHoaDonCTService _ihdcts;
        public IHoaDonService _ihds;
        public INhanVienService _invs;
        public List<HoaDonCT> _lsthoadonchitiet;
        public Validate _check;
        public IGioHangService _ighs;
        public IGioHangCTService _ighcts;
        public double thanhtien = 0;
        public double trutien = 0;
        
     
        DateTime now = DateTime.Now;

        


        public FrmBanHang()
        {
            InitializeComponent();
            _ictsp = new ChiTietSPService();
            _check = new Validate();
            _ighs = new GioHangService();
            _ighcts = new GioHangCTService();
            _ikhs = new KhachHangService();
            _ihsxs = new HangSanXuatService();
            _isize = new SizeService();
            _ihdcts = new HoaDonCTService();
            _isps = new SanPhamService();
            _invs = new NhanVienService();
            _imss = new MauSacService();
            _lsthoadonchitiet = new List<HoaDonCT>();
            _ihds = new HoaDonService();
            dtgrid_giohang.Columns[0].Visible = false;
            
            LoadSpCT();
            LoadMS();
            LoadSize();
            Loadhsx();
            LoadKH();
            Loadhdc();
            laymanv();
            lb_mahd.Text = "";
            lb_tenkh.Text = "";
            LoadGioHang();
            _giohang = new GioHang()
            {
                ID = Guid.NewGuid(),
            };

            //label1.Text = Login.layEmail; //add thử Email vào label
        }

   
        public void Loadhdc()
        {
            dtgrid_hdcho.Rows.Clear();
            dtgrid_hdcho.Columns[0].Visible = false;

            //var a = _ihds.GetAllhd().Where(c => c.TrangThai == "Chưa thanh toán" || c.TrangThai == "").ToList();
            foreach (var x in _ihds.GetAllhd().Where(c => c.TrangThai == "Chờ thanh toán" && c.NgayTao.Value.ToShortDateString() == DateTime.Now.Date.ToShortDateString()).OrderByDescending(c => c.NgayTao))
            {
                var a = _ikhs.GetAllKH().Find(c => c.ID == x.IDkh);
                var b = _invs.GetAllNV().Find(c => c.ID == x.IDnv);
                dtgrid_hdcho.Rows.Add(x.IDhd, x.Mahd, a.TenKH, b.MaNV, x.NgayTao);
            }
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
            
            var idhd1 = _ihds.GetAllhd().Where(c => c.Mahd == lb_mahd.Text).Select(c => c.IDhd).FirstOrDefault();
            dtgrid_giohang.Rows.Clear();
            foreach (var x in _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd1))
            {
                var idctsp = _ictsp.GetAll().FirstOrDefault(c => c.ID == x.IDSP);
                var tensp = _isps.GetAllsp().FirstOrDefault(c => c.IDsp == idctsp.IDSP);
                var mausac = _imss.GetAllMS().FirstOrDefault(c => c.IDms == idctsp.IDms);
                var size = _isize.GetSizes().FirstOrDefault(c => c.id == idctsp.IDSize);

                dtgrid_giohang.Rows.Add(idctsp.ID, tensp.TenSp, mausac.Mau, size.SoSize, x.SoLuong, idctsp.GiaBan, x.SoLuong * idctsp.GiaBan); // truyền số lượng từ form số lượng qua 
            }

            var tinhtien = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(idhd1.ToString())).Sum(c => c.DonGia * c.SoLuong);
            lb_tongtien.Text = tinhtien.ToString();

        }
        public void LoadSpCT()
        {
            
            dtgrid_sp.Columns[0].Visible = false;
            dtgrid_sp.Rows.Clear();
            foreach (var x in _ictsp.GetAll().Where(c => c.Trangthai == "Còn hàng"))
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
            try
            {
                int row = e.RowIndex;
                if (dtgrid_sp.Rows[row].Cells[0].Value == null)
                {
                    return;
                } else
                {
                    var layanh = _ictsp.GetAll().FirstOrDefault(p => p.ID == Guid.Parse(dtgrid_sp.Rows[row].Cells[0].Value.ToString()));
                    ptb_anhsp.Image = Image.FromFile(layanh.anh);
                }
                
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
            
        }

       
        private void dtgrid_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dtgrid_giohang.Rows[e.RowIndex];
                if (r.Cells[0].Value == null)
                {
                    return;
                } else
                {
                    //var idsp = _ictsp.GetAll().FirstOrDefault(c => c.ID == Guid.Parse( dtgrid_giohang.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (e.ColumnIndex == 7)
                    {
                        if (MessageBox.Show("Ban co muon xoa san pham nay khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var id = _ihdcts.GetAllHDCT().Where(c => c.IDSP == Guid.Parse(dtgrid_giohang.Rows[e.RowIndex].Cells[0].Value.ToString())).Select(c => c.IDSP).FirstOrDefault();
                            //var soluong = _ihdcts.GetAllHDCT().Where(c => c.IDSP == Guid.Parse(dtgrid_giohang.Rows[e.RowIndex].Cells[0].Value.ToString())).Select(c => c.SoLuong).FirstOrDefault();
                            var soluong = _ighcts.GetAllghct().Where(c => c.IdSP == id).Select(c => c.SoLuong).FirstOrDefault();
                            var idsp1 = _ictsp.GetAll().FirstOrDefault(c => c.ID == id);
                            //cập nhật lại số lượng
                            if (id == idsp1.ID)
                            {
                                ChiTietSanPham ctsp = new ChiTietSanPham()
                                {
                                    Id = id,
                                    IDHSX = idsp1.IDHSX,
                                    IDMauSac = idsp1.IDms,
                                    IDSize = idsp1.IDSize,
                                    MaSPCT = idsp1.MaCTSP,
                                    IDSP = idsp1.IDSP,
                                    Anh = idsp1.anh,
                                    GiaBan = idsp1.GiaBan,
                                    GiaNhap = idsp1.GiaNhap,
                                    TrangThai = idsp1.Trangthai,
                                    SoLuong = soluong + idsp1.SoLuong,
                                };
                                _ictsp.UpdateCRSP(id, ctsp);
                                dtgrid_sp.Rows.Clear();
                                LoadSpCT();
                                MessageBox.Show(_ihdcts.DeleteSP(id));
                                dtgrid_giohang.Rows.Clear();
                                LoadGioHang();
                               
                            }
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại .");
            }

        }
        public void laymanv()
        {
            var a = _invs.GetAllNV().FirstOrDefault(c => c.Email == Login.layEmail);
            lb_manv.Text = a.MaNV;
        }
        private void btn_taohd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn tạo hoá đơn không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                        HoaDon hd = new HoaDon()
                        {
                            ID = Guid.NewGuid(),
                            //MaHD = "HD" + Convert.ToString(_ihds.GetAllhd().Count + 1),
                            MaHD = "HD" + Convert.ToString(_ihds.GetAllhd().Max(c => Convert.ToInt32(c.Mahd.Substring(2 , c.Mahd.Length - 2)) +1)),
                            NgayTao = DateTime.Now,
                            IDNV = _invs.GetAllNV().Where(c => c.MaNV == Convert.ToString(lb_manv.Text)).Select(c => c.ID).FirstOrDefault(),
                            IDKH = _ikhs.GetAllKH().Where(c => c.TenKH == Convert.ToString(lb_tenkh.Text)).Select(c => c.ID).FirstOrDefault(),
                            TrangThai = "Chờ thanh toán",
                        };
                        _ihds.AddHoaDon(hd);
                        MessageBox.Show("Tạo hoá đơn thành công .");
                        lb_mahd.Text = hd.MaHD;
                        var tenkh = _ikhs.GetAllKH().Where(c => c.ID == hd.IDKH).Select(c => c.TenKH).FirstOrDefault().ToString();
                        lb_tenkh.Text = tenkh;
                    
                }
        }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }

}



        private void dtgrid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                if (r == -1) return;
                _id = Guid.Parse(Convert.ToString(dtgrid_khachhang.Rows[r].Cells[0].Value));
                txt_tenkh.Text = Convert.ToString(dtgrid_khachhang.Rows[r].Cells[1].Value);
                txt_sdtkh.Text = Convert.ToString(dtgrid_khachhang.Rows[r].Cells[2].Value);
                txt_diachi.Text = Convert.ToString(dtgrid_khachhang.Rows[r].Cells[3].Value);
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
           
        }

        private void dtgrid_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                List<HoaDonCT> _lsthdct = new List<HoaDonCT>();
                var idhd = _ihds.GetAllhd().Where(c => c.Mahd == lb_mahd.Text).Select(c => c.IDhd).FirstOrDefault();
                var idhdct = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd).Select(c => c.IDSP).Count();
 
                if (lb_mahd.Text == "")
                {
                    MessageBox.Show("Bạn chua co hoa don .");
                    return;
                }else if (idhdct == 0)
                {
                    MessageBox.Show("Giỏ hàng bạn chưa có sp.");
                    return;
                }
                else
                {
                    var a = _ihds.GetAllhd().Where(c => c.Mahd == lb_mahd.Text).Select(c => c.IDhd).FirstOrDefault();
                    laymahd = Guid.Parse(a.ToString());
                    var b = _ihds.GetAllhd().Where(c => c.Mahd == lb_mahd.Text).Select(c => c.IDkh).FirstOrDefault();
                    layidkh = Guid.Parse(b.ToString());
                    LoadSpCT();
                    FrmThanhToan thanhtoan = new FrmThanhToan();
                    thanhtoan.ShowDialog();
                    LoadSpCT();
                }


            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
                return;
            }
           

        }

        private void dtgrid_sp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                int row = dtgrid_giohang.Rows.Count;
                DataGridViewRow r = dtgrid_sp.Rows[e.RowIndex];
                if (r.Cells[0].Value == null)
                {
                    return;
                }else
                {
                    if (lb_mahd.Text == "")
                    {
                        MessageBox.Show("Bạn chưa tạo hoá đơn .");
                        return;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Ban co muon them san pham nay khong ?", "Thong bao", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var a = Guid.Parse(r.Cells[0].Value.ToString());
                            IDspct = a;
                            FrmSoLuong sl = new FrmSoLuong();
                            sl.ShowDialog();

                            var idsp = _ictsp.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));

                            var idhd2 = _ihds.GetAllhd().Where(c => c.Mahd == Convert.ToString(lb_mahd.Text)).Select(c => c.IDhd).FirstOrDefault();
                            
                            var idsp1 = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd2).Select(c => c.IDSP).FirstOrDefault(); 

                            if (idsp1 != idsp.ID)
                            {
                                //Thêm hoá đơn chi tiết
                                HoaDonCT hdct = new HoaDonCT()
                                {
                                    IDSP = idsp.ID,
                                    IDHD = idhd2,
                                    SoLuong = FrmSoLuong.soluong,
                                    DonGia = idsp.GiaBan,
                                };
                                _ihdcts.AddHDCT(hdct);
                                //dtgrid_giohang.Rows.Clear();
                                //LoadGioHang();
                                //dtgrid_sp.Rows.Clear();
                                //LoadSpCT();
                            }
                            else
                            {
                                var soluong = _ihdcts.GetAllHDCT().Where(c => c.IDSP == idsp1).Select(c => c.SoLuong).FirstOrDefault();
                                // Update hoá đơn chi tiết
                                HoaDonCT hoa = new HoaDonCT()
                                {
                                    IDSP = idsp1,
                                    //IDHD = idhd2 ,
                                    SoLuong = soluong + FrmSoLuong.soluong,
                                    DonGia = idsp.GiaBan
                                };
                                _ihdcts.UpdateHDCT(idhd2, hoa);
                                //dtgrid_giohang.Rows.Clear();
                                //LoadGioHang();
                                //dtgrid_sp.Rows.Clear();
                                //LoadSpCT();
                            }
                            // update hoá đơn 
                            HoaDon hd = new HoaDon()
                            {
                                ID = idhd2,
                                IDKH = _ikhs.GetAllKH().Where(c => c.TenKH == Convert.ToString(lb_tenkh.Text)).Select(c => c.ID).FirstOrDefault(),
                                SoLuong = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd2).Sum(c => c.SoLuong),
                                DonGia = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd2).Sum(c => c.SoLuong * c.DonGia),
                                IDNV = _invs.GetAllNV().Where(c => c.MaNV == Convert.ToString(lb_manv.Text)).Select(c => c.ID).FirstOrDefault(),
                                TrangThai = "Chờ thanh toán",
                                NgayThanhToan = null,
                            };
                            _ihds.UpdateHoaDon(idhd2, hd);
                            dtgrid_sp.Rows.Clear();
                            LoadSpCT();
                            dtgrid_giohang.Rows.Clear();
                            LoadGioHang();
                        }
                    }
                    
               
                }

        //}
        //    catch
        //    {
        //        MessageBox.Show("Mời bạn thao tác lại.");
        //    }
}

        private void btn_chonkh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenkh.Text == "")
                {
                lb_tenkh.Text = "Ẩn Danh";
                }     
                else
                {
                    if (lb_tenkh.Text != "" && lb_mahd.Text != "")
                    {
                        MessageBox.Show($"đã tạo hoá đơn cho khách hàng {lb_tenkh.Text}. Mời bạn huỷ hoá đơn hoặc chuyển hoá đơn này vào trong hoá đơn chờ hoặc thanh toán hoá đơn để tạo hoá đơn tiếp.");
                        return;
                    }
                    else if (lb_tenkh.Text != "" && lb_mahd.Text == "")
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi khách hàng không ?", "Thông báo ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var timidkh = _ikhs.GetAllKH().Where(c => c.TenKH == Convert.ToString(txt_tenkh.Text)).Select(c => c.ID).FirstOrDefault();
                            if (_ikhs.GetAllKH().Any(c => c.ID == timidkh) == true)
                            {

                            }
                            else
                            {
                                _ikhs.AddKH(new KhachHang()
                                {
                                    ID = Guid.NewGuid(),
                                    MaKH = "KH" + Convert.ToString(_ikhs.GetAllKH().Count + 1),
                                    SDT = Convert.ToString(txt_sdtkh.Text),
                                    DiaChi = Convert.ToString(txt_diachi.Text),
                                    Ten = Convert.ToString(txt_tenkh.Text),

                                });
                                LoadKH();
                            }
                            lb_tenkh.Text = txt_tenkh.Text;
                        }
                        MessageBox.Show("Thay đổi khách hàng thành công.");
                        txt_sdtkh.Text = "";
                        txt_tenkh.Text = "";
                        txt_diachi.Text = "";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Ban co muon chon khach hang nay khong ?", "Thong bao", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var timidkh = _ikhs.GetAllKH().Where(c => c.TenKH == Convert.ToString(txt_tenkh.Text)).Select(c => c.ID).FirstOrDefault();
                            if (_ikhs.GetAllKH().Any(c => c.ID == timidkh) == true)
                            {

                            }
                            else
                            {
                                _ikhs.AddKH(new KhachHang()
                                {
                                    ID = Guid.NewGuid(),
                                    MaKH = "KH" + Convert.ToString(_ikhs.GetAllKH().Count + 1),
                                    SDT = Convert.ToString(txt_sdtkh.Text),
                                    DiaChi = Convert.ToString(txt_diachi.Text),
                                    Ten = txt_tenkh.Text,

                                });
                                LoadKH();

                            }
                            lb_tenkh.Text = txt_tenkh.Text;
                            MessageBox.Show("Khach hang da duoc chon.");
                            txt_sdtkh.Text = "";
                            txt_tenkh.Text = "";
                            txt_diachi.Text = "";
                        }
                    }
                }


            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }

        }

        private void btn_hdcho_Click(object sender, EventArgs e)
        {
            try
            {
                if(lb_mahd.Text == "")
                {
                    MessageBox.Show("Chưa có hoá đơn .");
                    return;
                }else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn hoá đơn chờ không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var idhd = _ihds.GetAllhd().Where(c => c.Mahd == Convert.ToString(lb_mahd.Text)).Select(c => c.IDhd).FirstOrDefault();
                        HoaDon hd = new HoaDon()
                        {
                            SoLuong = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd).Sum(c => c.SoLuong),
                            IDNV = _invs.GetAllNV().Where(c => c.MaNV == Convert.ToString(lb_manv.Text)).Select(c => c.ID).FirstOrDefault(),
                            DonGia = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd).Sum(c => c.SoLuong * c.DonGia),
                            TrangThai = "Chờ thanh toán",
                            NgayThanhToan = null,
                        };
                        _ihds.UpdateHoaDon(idhd, hd);
                        MessageBox.Show($"Hoá đơn {lb_mahd.Text} được đưa vào hoá đơn chờ.");
                        Reset();

                        LoadSpCT();
                    }
                    else
                    {

                    }
                }
               
            }
            catch
            {
                MessageBox.Show($"Hoá đơn {lb_mahd.Text} được đưa vào hoá đơn chờ thất bại.");
            }
        }

        

        private void btn_huy_Click(object sender, EventArgs e)
        {
            //Huỷ hoá đơn
            try
            {
                if (lb_mahd.Text == "")
                {
                    MessageBox.Show("Chưa có hoá đơn .");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn huỷ hoá đơn không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var idhd = _ihds.GetAllhd().Where(c => c.Mahd == Convert.ToString(lb_mahd.Text)).Select(c => c.IDhd).FirstOrDefault();
                        HoaDon hd = new HoaDon()
                        {
                            SoLuong = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd).Sum(c => c.SoLuong),
                            IDNV = _invs.GetAllNV().Where(c => c.MaNV == Convert.ToString(lb_manv.Text)).Select(c => c.ID).FirstOrDefault(),
                            DonGia = _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd).Sum(c => c.SoLuong * c.DonGia),
                            TrangThai = "Huỷ",
                            NgayThanhToan = null,
                        };
                        _ihds.UpdateHoaDon(idhd, hd);
                        MessageBox.Show($"Huỷ hoá {lb_mahd.Text} đơn thành công.");
                        Reset();
                        LoadSpCT();
                    }
                }
               
            }
            catch
            {
                MessageBox.Show($"Hoá đơn {lb_mahd.Text} huỷ thất bại.");
            }
        }
        private void dtgrid_hdcho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Sử dụng tiếp hoá đơn 
                    if(lb_mahd.Text != "")
                    {
                        MessageBox.Show("Có hoá đơn đang thao tác . Bạn chuyển hoá đơn vào hoá đơn chờ hoặc thanh toán hoặc huỷ hoá đơn để sử tiếp tục thao tác hoá đơn này.");
                        return;
                    }else
                    {
                        DataGridViewRow r = dtgrid_hdcho.Rows[e.RowIndex];
                        if (dtgrid_hdcho.Rows[e.RowIndex].Cells[0].Value == null)
                        {
                            return;
                        } else
                        {
                            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn tiếp tục thực hiện hoá đơn {r.Cells[1].Value.ToString()} không ?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                _id = Guid.Parse(r.Cells[0].Value.ToString());
                                lb_mahd.Text = r.Cells[1].Value.ToString();
                                lb_tenkh.Text = r.Cells[2].Value.ToString();
                                lb_manv.Text = r.Cells[3].Value.ToString();


                            }
                            var idnv = _invs.GetAllNV().Where(c => c.MaNV == lb_manv.Text).Select(c => c.ID).FirstOrDefault();


                            var IDhd = _ihds.GetAllhd().Where(c => c.Mahd == lb_mahd.Text).Select(c => c.IDhd).FirstOrDefault();
                            var idhd1 = _ihds.GetAllhd().Where(c => c.IDhd == Guid.Parse(r.Cells[0].Value.ToString())).Select(c => c.IDhd).FirstOrDefault();
                            dtgrid_giohang.Rows.Clear();
                            foreach (var x in _ihdcts.GetAllHDCT().Where(c => c.IDHD == (idhd1)))
                            {
                                var idctsp = _ictsp.GetAll().FirstOrDefault(c => c.ID == x.IDSP);
                                var tensp = _isps.GetAllsp().FirstOrDefault(c => c.IDsp == idctsp.IDSP);
                                var mausac = _imss.GetAllMS().FirstOrDefault(c => c.IDms == idctsp.IDms);
                                var size = _isize.GetSizes().FirstOrDefault(c => c.id == idctsp.IDSize);

                                dtgrid_giohang.Rows.Add(idctsp.ID, tensp.TenSp, mausac.Mau, size.SoSize, x.SoLuong, idctsp.GiaBan, x.SoLuong * idctsp.GiaBan); // truyền số lượng từ form số lượng qua 
                            }
                            var tinhtien = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(idhd1.ToString())).Sum(c => c.SoLuong * c.DonGia);
                            lb_tongtien.Text = tinhtien.ToString();
                        }
                    }
                }          
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
            
        }
        public void Reset()
        {
            Loadhdc();
            LoadSpCT();
            lb_mahd.Text = "";
            lb_tenkh.Text = "";
            lb_tongtien.Text = "0";
            LoadGioHang();
            cbb_nhasx.Text = "";
            cbb_size.Text = "";
            cbb_mausac.Text = "";
        }
        public void LocSP()
        {
            dtgrid_sp.Rows.Clear();
            dtgrid_sp.Columns[0].Visible = false;
            var x = (from a in _ictsp.GetAll()
                     join b in _imss.GetAllMS() on a.IDms equals b.IDms
                     join c in _isize.GetSizes() on a.IDSize equals c.id
                     join d in _isps.GetAllsp() on a.IDSP equals d.IDsp
                     join e in _ihsxs.GetAllHSX() on a.IDHSX equals e.ID
                     where e.TenHSX.Contains(cbb_nhasx.Text) || b.Mau.Contains(cbb_mausac.Text) || c.SoSize.ToString().Contains(cbb_size.Text)
                     select new
                     {
                         a,
                         b,
                         c,
                         d,
                         e
                     }) ;
            foreach (var y in x)
            {
                dtgrid_sp.Rows.Add(y.a.ID, y.a.MaCTSP, y.d.TenSp, y.e.TenHSX, y.b.Mau, y.c.SoSize, y.a.SoLuong, y.a.GiaBan);
            }
        }
        public void Locgia(int gia)
        {
            dtgrid_sp.Columns[0].Visible = false;
            dtgrid_sp.Rows.Clear();
            foreach (var x in _ictsp.GetAll().Where(c => c.GiaBan <= Convert.ToInt32(gia)))
            {
                var y = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);
                var z = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var a = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var b = _ihsxs.GetAllHSX().Find(c => c.ID == x.IDHSX);
                dtgrid_sp.Rows.Add(x.ID, x.MaCTSP, y.TenSp, b.TenHSX, z.Mau, a.SoSize, x.SoLuong, x.GiaBan);
            }
        }
        private void btn_loc_Click(object sender, EventArgs e)
        {
                LocSP();
        }
        public void Timkiemkh(string sdt)
        {
            dtgrid_khachhang.Rows.Clear();
            dtgrid_khachhang.Columns[0].Visible = false;
            foreach (var x in _ikhs.GetAllKH().Where(c => c.SDT.Contains(sdt)))
            {
                dtgrid_khachhang.Rows.Add(x.ID, x.TenKH, x.SDT, x.DiaChi);
            }
        }
        private void txt_timkiemkh_KeyUp(object sender, KeyEventArgs e)
        {
            Timkiemkh(txt_timkiemkh.Text);
        }
        public void TimKiemSP(string name)
        {
            dtgrid_sp.Rows.Clear();
            dtgrid_sp.Columns[0].Visible = false;
            var x = (from a in _ictsp.GetAll()
                     join b in _imss.GetAllMS() on a.IDms equals b.IDms
                     join c in _isize.GetSizes() on a.IDSize equals c.id
                     join d in _isps.GetAllsp() on a.IDSP equals d.IDsp
                     join e in _ihsxs.GetAllHSX() on a.IDHSX equals e.ID
                     where d.TenSp.Contains(name) || a.MaCTSP.Contains(name)
                     select new
                     {
                         a,
                         b,
                         c,
                         d,
                         e
                     });
           foreach(var y in x)
            {
                dtgrid_sp.Rows.Add(y.a.ID, y.a.MaCTSP, y.d.TenSp, y.e.TenHSX, y.b.Mau, y.c.SoSize, y.a.SoLuong, y.a.GiaBan);
            }
        }
        private void txt_timkiemsp_KeyUp(object sender, KeyEventArgs e)
        {
            TimKiemSP(txt_timkiemsp.Text);
        }

        private void ptb_reset_Click(object sender, EventArgs e)
        {
            dtgrid_sp.Rows.Clear();
            LoadSpCT();
        }

        private void dtgrid_giohang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0) 
            //{
            //    DataGridViewRow r = dtgrid_giohang.Rows[e.RowIndex];
            //    if (dtgrid_giohang.Rows[e.RowIndex].Cells.Count == null)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        if (int.TryParse(dtgrid_giohang.Rows[r.Index].Cells[4].Value.ToString(), out int x))
            //        {
            //            if (dtgrid_giohang.Rows[r.Index].Cells[4].Value != _lsthoadonchitiet[r.Index].SoLuong.ToString())
            //            {
            //                if (Convert.ToInt32(dtgrid_giohang.Rows[r.Index].Cells[4].Value.ToString()) <= 0)
            //                {
            //                    MessageBox.Show("Nhap sai so luong.");
            //                    dtgrid_giohang.Rows[r.Index].Cells[4].Value = _lsthoadonchitiet[r.Index].SoLuong;
            //                }
            //                else
            //                {
            //                    var p = _ictsp.GetAll().FirstOrDefault(c => c.ID == _lsthoadonchitiet[r.Index].IDSP);
            //                    if (p.SoLuong < Convert.ToInt32(dtgrid_giohang.Rows[r.Index].Cells[4].Value))
            //                    {
            //                        MessageBox.Show("So luong san pham trong gio hang vuot qua so luong cho phep.");
            //                        dtgrid_giohang.Rows[r.Index].Cells[4].Value = _lsthoadonchitiet[r.Index].SoLuong;
            //                    }
            //                    else
            //                    {
            //                        _lsthoadonchitiet[r.Index].SoLuong = Convert.ToInt32(dtgrid_giohang.Rows[r.Index].Cells[4].Value);
            //                        //var idhd1 = _i
            //                        //var tinhtien = _ihdcts.GetAllHDCT().Where(c => c.IDHD == Guid.Parse(idhd1.ToString())).Sum(c => c.DonGia * c.SoLuong);
            //                        //lb_tongtien.Text = tinhtien.ToString();
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Nhap sai so luong.");
            //            dtgrid_giohang.Rows[r.Index].Cells[4].Value = _lsthoadonchitiet[r.Index].SoLuong;
            //        }
            //    }

            //}
        }

        private void txt_giamax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_check.CheckSoNguyenduong(txt_giamax.Text) == false)
                {
                    MessageBox.Show("Bạn nhập giá lớn hơn 0.");
                    LoadSpCT();
                }
                else
                {
                    Locgia(Convert.ToInt32(txt_giamax.Text));
                }

            }
            catch
            {

            }

        }
    }
}
