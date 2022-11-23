using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class ChucVu
    {
        public Guid ID { get; set; }
        public string? MaCV { get; set; }
        public string? TenCV { get ; set; }
    }
}
