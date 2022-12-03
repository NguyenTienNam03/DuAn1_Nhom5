using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class GioHangView
    {
        public Guid ID { get; set; }
        public Guid IDNV { get; set; }
        public Guid IDKH { get; set; }
        public string? MaGH { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgayTao { get; set; }  
        public decimal? DonGia { get; set; }
    }
}
