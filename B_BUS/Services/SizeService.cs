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
    public class SizeService : ISizeService
    {
        public ISizeRepository _Isize;
        public SizeService()
        {
            _Isize = new SizeRepository();
        }
        public string AddSize(Size size)
        {
            if (size == null) { return "Them that bai."; }
            if (_Isize.AddSize(size)) return "Them Size thanh cong.";
            return "Them that bai.";
        }

        public string DeleteSize(Guid id)
        {
            if (id == null) return "Xoa size that bai.";
            if (_Isize.DeleteSize(_Isize.GetSizeById(id))) return "Xoa Size thanh cong.";
            return "Xoa size that bai.";
        }

        public List<SizeView> GetSizes()
        {
            List<SizeView> _lstsize = new List<SizeView>();
            _lstsize = (from a in _Isize.GetAllSizes()
                        select new SizeView()
                        {
                            id = a.ID,
                            MaSize = a.MaSize,
                            SoSize = a.SoSize,
                        }).ToList();
            return _lstsize;
        }

        public string UpdateSize(Guid id, Size size)
        {
            if (size == null) return "Cap nhat that bai.";

            if (_Isize.UpdateSize(size)) return "Cap nhat thanh cong.";
            return "Cap nhat that bai.";
        }
    }
}
