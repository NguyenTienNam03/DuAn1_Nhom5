using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class GioHang
    {
        public Guid ID { get; set; }
        public Guid IDNV { get; set; }
        public Guid IDKH { get; set; }
        public string? MaGH { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public virtual  KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
}
