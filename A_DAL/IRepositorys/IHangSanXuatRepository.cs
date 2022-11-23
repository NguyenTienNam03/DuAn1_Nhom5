using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IHangSanXuatRepository
    {
        bool AddHSX(HangSanXuat hsx);
        bool UpdateHSX(Guid id , HangSanXuat hsx);
        bool DeleteHSX(Guid Id);
        List<HangSanXuat> GetAllHSXs();
        HangSanXuat GetALLByID(Guid id);
    }
}
