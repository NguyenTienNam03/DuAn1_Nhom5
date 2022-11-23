using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IChiTietSPService
    {
        public string AddCTSP(ChiTietSanPham ctsp);
        public string UpdateCRSP(Guid id, ChiTietSanPham ctsp);
        public string DeleteCTSP(Guid id);
        List<ChiTietSPView> GetAll();
        
    }
}
