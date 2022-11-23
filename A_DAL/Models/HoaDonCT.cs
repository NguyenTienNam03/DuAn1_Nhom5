using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class HoaDonCT
    {
        public Guid IDSP { get; set; }
        public Guid IDHD { get; set;}
        public decimal? DonGia { get; set;}
        public int? SoLuong { get; set;}
        public virtual ChiTietSanPham? ChiTietSanPham { get; set;}
        public virtual HoaDon? HoaDon { get; set;}
    }
}
