using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class GioHangCT
    {
        public Guid IDSP { get; set; }
        public Guid IDGH { get; set; }
        public decimal? DonGia { get; set; }
        public int SoLuong { get; set; }
        public virtual ChiTietSanPham? ChiTietSanPham { get; set; }
        public virtual GioHang? GioHang { get; set; }
    }
}
