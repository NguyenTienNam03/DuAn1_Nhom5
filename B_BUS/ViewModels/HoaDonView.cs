using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class HoaDonView
    {
        public Guid IDhd { get; set; }
        public Guid IDkh { get; set; }
        public Guid IDnv { get; set; }
        public string Mahd { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThai { get; set; }
    }
}
