using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
                var idhd = _ihoadon.GetAllhd().Where(c => c.Mahd == Convert.ToString(lb_mahd.Text)).Select(c => c.IDhd).FirstOrDefault();
                var idspinhdct = _ihdcts.GetAllHDCT().FirstOrDefault(c => c.IDHD == idhd);
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

                    IN();
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
            try
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
            catch
            {
                
            }
            
        }
        public void IN()
        {
            printhd.Document = PrintHoaDon;
            printhd.ShowDialog();
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var w = PrintHoaDon.DefaultPageSettings.PaperSize.Width;
            // Lay ten cua hang
            var idhd = _ihoadon.GetAllhd().Where(c => c.Mahd == Convert.ToString(lb_mahd.Text)).Select(c => c.IDhd).FirstOrDefault();
            e.Graphics.DrawString("twinsneaker".ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 20));
            
            // lay ma hd
            e.Graphics.DrawString(String.Format("{0}", _ihoadon.GetAllhd().Where(c => c.IDhd == idhd).Select(c => c.Mahd).FirstOrDefault()), new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new PointF(w / 2 + 200, 20));

            // Ngay gio xuat hoa don 
            e.Graphics.DrawString(String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new PointF(w / 2 + 200, 45));
            Pen blackpen = new Pen(Color.Black, 1);
            var y = 70;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p1, p2);
            y += 30;
            e.Graphics.DrawString("Phieu Thanh Toan".ToUpper(), new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new PointF(190, y));

            y += 80;
            // Xem lai font chu cho to len
            e.Graphics.DrawString("STT", new Font("Varial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, y));

            e.Graphics.DrawString("Ten SP", new Font("Varial", 10, FontStyle.Bold), Brushes.Black, new PointF(100, y));

            e.Graphics.DrawString("So luong", new Font("Varial", 10, FontStyle.Bold), Brushes.Black, new PointF(w / 2, y));

            e.Graphics.DrawString("Don gia", new Font("Varial", 10, FontStyle.Bold), Brushes.Black, new PointF(w / 2 + 100, y));

            e.Graphics.DrawString("Thanh tien", new Font("Varial", 10, FontStyle.Bold), Brushes.Black, new PointF(w - 200, y));
            // truy vấn lỗi 
            var tensp = from a in _ictsp.GetAll()
                        join b in _isps.GetAllsp() on a.IDSP equals b.IDsp 
                        join c in _ihdcts.GetAllHDCT() on a.ID equals c.IDSP
                        where a.ID == c.IDSP && a.IDSP == b.IDsp
                        select new
                        {
                            b.TenSp 
                        };
            int stt = 1;
            y += 30;
            foreach (var n in _ihdcts.GetAllHDCT().Where(c => c.IDHD == idhd))
            {
                // in lỗi 
                foreach (var m in tensp)
                {
                    e.Graphics.DrawString(string.Format("{0}", stt++), new Font("Varial", 8, FontStyle.Regular), Brushes.Black, new PointF(10, y));
                    e.Graphics.DrawString(m.TenSp, new Font("Varial", 8, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                    e.Graphics.DrawString(string.Format("{0:N0}", n.SoLuong), new Font("Varial", 8, FontStyle.Regular), Brushes.Black, new PointF(w / 2, y));
                    e.Graphics.DrawString(string.Format("{0:N0}", n.DonGia), new Font("Varial", 8, FontStyle.Regular), Brushes.Black, new PointF(w / 2 + 100, y));
                    e.Graphics.DrawString(string.Format("{0:N0}", n.SoLuong * n.DonGia), new Font("Varial", 8, FontStyle.Regular), Brushes.Black, new PointF(w - 200, y));
                }
            }
            y += 40;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p1, p2);

            y += 30;
            e.Graphics.DrawString(string.Format("Thanh tien : "), new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w / 2, y));
            e.Graphics.DrawString(lb_tongtiensp.Text + " VND", new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w - 150, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Thue : "), new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w / 2, y));
            e.Graphics.DrawString(lb_thue.Text , new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w - 150, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Tong tien : "), new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w / 2, y));
            e.Graphics.DrawString(lb_tongtien.Text + " VND", new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w - 150, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Tien khach dua : "), new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w / 2, y));
            e.Graphics.DrawString(txt_tienkhachdua.Text + " VND", new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w - 150, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Tien tra khach : "), new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w / 2, y));
            e.Graphics.DrawString((Convert.ToDouble(lb_tientrakhach.Text) * 0.2) + " VND", new Font("Varial", 13, FontStyle.Bold), Brushes.Black, new PointF(w - 150, y));


        }


    }
}
