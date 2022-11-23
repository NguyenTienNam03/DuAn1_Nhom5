using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IChiTietSPRepository
    {
        public bool AddChiTietSP(ChiTietSanPham chiTietSanPham);
        public bool UpdateChiTietSP(Guid id , ChiTietSanPham chiTietSanPham);
        public bool DeleteChiTietSP(Guid id);
        List<ChiTietSanPham> GetChiTietSP();
        ChiTietSanPham GetByID(Guid id);
    }
}
