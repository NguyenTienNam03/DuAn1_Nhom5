using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IGioHangRepository
    {
        public bool AddGioHang(GioHang gh);
        public bool UpdateGioHang(GioHang gh);
        public bool DeleteGioHang(GioHang gh);
        List<GioHang> GetAllHang();
        GioHang GetghByID(Guid id);
    }
}
