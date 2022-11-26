using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IGioHangService
    {
        public string AddGioHang(GioHang gh);
        public string UpdateGioHang(Guid id , GioHang gh);
        public string DeleteGioHang(Guid id);
        List<GioHangView> GettAllGH();
    }
}
