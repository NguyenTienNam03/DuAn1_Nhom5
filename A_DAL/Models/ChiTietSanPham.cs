using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class ChiTietSanPham
    {
        public Guid Id { get; set; }
        public Guid IDSP { get; set; }
        public Guid IDHSX { get; set; }
        public Guid IDSize { get; set; }
        public Guid IDMauSac { get; set; }
        public string? MaSPCT { get; set; }
        public int SoLuong { get; set; }
        public string? Anh { get; set; }

        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string? TrangThai { get; set; }
        public virtual SanPham? SanPham { get; set; }
        public virtual HangSanXuat? HangSanXuat { get; set; }
        public virtual Size? size { get; set; }
        public virtual MauSac? mausac {get ; set ; }
    }
}
