using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IKhachHangService
    {
        public string AddKH(KhachHang KH);
        public string UpdateKH(Guid id, KhachHang KH);
        public string DeleteKH(Guid id);
        List<KhachHangView> GetAllKH();
    }

}
