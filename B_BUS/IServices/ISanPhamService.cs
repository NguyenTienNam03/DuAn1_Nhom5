using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ISanPhamService
    {
        public string AddSP(SanPham sanPham);
        public string UpdateSp(Guid id, SanPham sanPham);
        public string DeleteSP(Guid id);
        List<SanPhamView> GetAllsp();
    }
}
