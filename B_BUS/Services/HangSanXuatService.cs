using A_DAL.IRepositorys;
using A_DAL.Models;
using A_DAL.Repositorys;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class HangSanXuatService : IHangSanXuatService
    {
        public IHangSanXuatRepository _Ihsx;
        public HangSanXuatService()
        {
            _Ihsx = new HangSanXuatRepository();
        }
        public string AddHSX(HangSanXuat hsx)
        {
            if (hsx == null) return "Them Hang san xuat that bai.";
            if (_Ihsx.AddHSX(hsx)) return "Them Hang san xuat thanh cong.";
            return "Them Hang san xuat that bai.";
        }

        public List<HangSanXuatView> GetAllHSX()
        {
            List<HangSanXuatView> _lsthsx = new List<HangSanXuatView>();
            _lsthsx = (from a in _Ihsx.GetAllHSXs()
                      select new HangSanXuatView
                      {
                          ID = a.ID ,
                          Mahsx = a.MaHangSX ,
                          TenHSX = a.TenHSX ,
                      }).ToList();
            return _lsthsx;
        }

        public string RemoveHSX(Guid id)
        {
            if (id == null) return "Xoa that bai.";
            if (_Ihsx.DeleteHSX(id)) return "Xoa thanh cong .";
            return "Xoa that bai.";
        }

        public string UpdateHsx(Guid id, HangSanXuat hsx)
        {
            if (id == null) return "Cap nhat that bai.";
            if (_Ihsx.UpdateHSX(id, hsx)) return "Cap nhat thanh cong .";
            return "Cap nhat that bai.";
        }
    }
}
