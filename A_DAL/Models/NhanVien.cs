using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class NhanVien
    {
        public Guid ID { get; set; }
        public Guid IDCV { get; set; }
        public string MaNV  { get; set; }
        public string? Ten { get ; set; }
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? MatKhau { get; set; }
        public string? TrangThai { get; set; }
        public virtual ChucVu? ChucVu { get; set; } 
        //public virtual NhanVien? Nv { get; set; }
    }
}
