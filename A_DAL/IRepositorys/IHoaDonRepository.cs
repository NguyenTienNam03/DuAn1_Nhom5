using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IHoaDonRepository
    {
        public bool AddHoaDon(HoaDon hd);
        public bool DeleteHoaDon(HoaDon hd);
        List<HoaDon> GetAll();
        HoaDon GetById(Guid id);
    }
}
