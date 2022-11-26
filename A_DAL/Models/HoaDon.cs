using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class HoaDon
    {
       public Guid ID { get; set; }
        public Guid IDKH { get; set; }
        public Guid IDNV { get ; set; }
        public string? MaHD { get; set; }
        public decimal? DonGia { get; set; }
        public int SoLuong { get ; set; }
        public  DateTime? NgayTao { get; set; }
        public string? TrangThai { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
    }
}
