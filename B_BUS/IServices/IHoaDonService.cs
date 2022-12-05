using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHoaDonService
    {
        public string AddHoaDon(HoaDon hd);
        public string UpdateHoaDon(Guid id , HoaDon hd);
        public string DeleteHoaDon(Guid id);
        
        List<HoaDonView> GetAllhd();
    }
}
