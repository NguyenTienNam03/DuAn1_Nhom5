using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface INhanVienRepository
    {
        bool AddNV(NhanVien nv);
        bool UpdateNV(Guid id , NhanVien nv);
        bool DeleteNV(Guid id);
        List<NhanVien> GetNhanVien();
        NhanVien GetByID(Guid id);
    }
}
