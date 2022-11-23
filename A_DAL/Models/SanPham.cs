using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class SanPham
    {
        public Guid ID { get; set; }
        public string? MaSP { get; set; }
        public string? TenSP { get; set; }
    }
}
