using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IHangSanXuatService
    {
        public string AddHSX(HangSanXuat hsx);
        public string RemoveHSX(Guid id);
        public string UpdateHsx(Guid id, HangSanXuat hsx);
        List<HangSanXuatView> GetAllHSX();
    }
}
