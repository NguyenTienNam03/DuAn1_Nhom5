using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class KhachHang
    {
        public Guid ID { get; set; }
        public string? MaKH { get; set; }
        public string? Ten { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
     
    }
}
