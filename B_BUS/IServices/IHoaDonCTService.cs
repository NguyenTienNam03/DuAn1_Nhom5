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
        public string UpdateHDCT( Guid id , HoaDonCT hdct );
        public string DeleteHDCT(Guid id);
        public string DeleteSP(Guid id);
        List<HoaDonCT> GetAllHDCT();
    }
}
