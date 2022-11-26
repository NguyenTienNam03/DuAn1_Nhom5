using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IGioHangCTService
    {
        public string AddGioHangChiTiet(GioHangCT ghct);
        public string UpdateGioHangChiTiet(Guid id, GioHangCT ghct);
        public string DeletGioHangChiTiet(Guid id);
        List<GioHangCTView> GetAllghct();
    }
}
