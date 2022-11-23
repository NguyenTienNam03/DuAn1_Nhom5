using A_DAL.IRepositorys;
using A_DAL.Models;
using A_DAL.Repositorys;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class MauSacService : IMauSacService
    {
        public IMauSacRepository _Imss;
        public MauSacService()
        {
            _Imss = new MauSacRepository();
        }
        public string AddMauSac(MauSac mauSac)
        {
            if(mauSac == null) { return "Them That bai."; }
            if (_Imss.AddMauSac(mauSac)) return "Them thanh cong.";
            return "Them That bai.";
        }

        public string DeleteMauSac(Guid id)
        {
            if (id == null) return "Xoa that bai.";
            if (_Imss.DeleteMauSac(id)) return "Xoa thanh cong.";
            return "Xoa that bai."; ;
        }

        public List<MauSacView> GetAllMS()
        {
            List<MauSacView> _lstms = new List<MauSacView>();
            _lstms = (from a in _Imss.GetAll()
                      select new MauSacView
                      {
                          IDms = a.ID ,
                          MaMau = a.MaMau ,
                          Mau = a.Mau
                      }).ToList();
            return _lstms;
        }

        public string UpdateMauSac(Guid id, MauSac mauSac)
        {
            if (id == null) return "Cap nhat that bai.";
            if (_Imss.UpdateMauSac(id, mauSac)) return "Cap nhat thanh cong.";
            return "Cap nhat that bai."; ;
        }
    }
}
