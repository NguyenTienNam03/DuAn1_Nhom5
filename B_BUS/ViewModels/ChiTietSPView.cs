using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class ChiTietSPView 
    {
        public Guid ID { get; set; }
        public Guid IDSP { get; set; }
        public Guid IDSize { get; set; }
        public Guid IDHSX { get; set; }
        public Guid IDms { get; set; }
        public string MaCTSP { get; set; }
        public string anh { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string Trangthai { get; set; }
    }
}
