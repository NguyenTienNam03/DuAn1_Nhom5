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
    public class ChucVuService : IChucVuService
    {
        private IChucVuRepository _ICV;
        private Guid id;
        public ChucVuService()
        {
            _ICV = new ChucVuRepository();
        }
        public string AddChucVu(ChucVu chucVu)
        {
            if(chucVu == null)
            {
                return "Them chuc vu that bai.";
            }
            if(_ICV.AddChucVu(chucVu))
            {
                return "Them chuc vu thanh cong.";
            }
            return "Them chuc vu that bai.";
        }

        public List<ChucVuView> GetAllCV()
        {
            List<ChucVuView> cvv = new List<ChucVuView>();
            cvv = (from a in _ICV.GetAllChucVu()
                   select new ChucVuView()
                   {
                       IDcv = a.ID,
                       MaCV = a.MaCV,
                       TenCV = a.TenCV,
                   }).ToList();
            return cvv;
        }

        public string DeleteChucVu(Guid id)
        {
            if (id == null) return "Xoa chuc vu that bai.";
            if(_ICV.DeleteChucVu(id)) 
            {
                return "Xoa chuc vu thanh cong.";
            }

            return "Xoa chuc vu that bai.";
        }

        public string UpdateChucVu(Guid id, ChucVu chucVu)
        {
            if (id == null) return "Cap nhat that bai.";
            if (_ICV.UpdateChucVu( id ,chucVu)) return "Cap nhat thanh cong. ";
            return "Cap nhat that bai.";
        }
    }
}
