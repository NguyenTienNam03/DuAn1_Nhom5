using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface ISanPhamRepository
    {
        bool AddSP(SanPham sp);
        bool UpdateSP(Guid id , SanPham sp);
        bool DeleteSP(Guid id);
        List<SanPham> GetAllSP();
        SanPham GetById(Guid id);
    }
}
