using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHoaDonCTService
    {
        public string AddHDCT(HoaDonCT hdct);
      
        public string DeleteHDCT(Guid id);
        List<HoaDonCT> GetAllHDCT();
    }
}
