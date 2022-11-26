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
    public class GioHangCTService : IGioHangCTService
    {
        public IGioHangCTRepository _ighct;
        public IChiTietSPRepository _ictsp;
        public IGioHangRepository _igh;
        public GioHangCTService()
        {
            _ighct = new GioHangCTRepository();
            _ictsp = new ChiTietSPRepository();
            _igh = new GioHangRepository();
        }
        public string AddGioHangChiTiet(GioHangCT ghct)
        {
            if (ghct == null) return "Them that bai";
            if (_ighct.AddGHCT(ghct)) return "Them thanh cong.";
            return "Them that bai";
        }

        public string DeletGioHangChiTiet(Guid id)
        {
            if (id == null) return "Xoa that bai.";
            if (_ighct.DeleteGHCT(_ighct.GetByID(id))) return "Xoa Thanh cong .";
            return "Xoa that bai.";
        }

        public List<GioHangCTView> GetAllghct()
        {
            List<GioHangCTView> _lstghct = new List<GioHangCTView>();
            _lstghct = (from a in _ighct.GetAll()
                        join b in _ictsp.GetChiTietSP() on a.IDSP equals b.Id
                        join c in _igh.GetAllHang() on a.IDGH equals c.ID
                        select new GioHangCTView
                        {
                            IdSP = b.Id,
                            IDgh = c.ID,
                            Dongia = a.DonGia,
                            SoLuong = a.SoLuong,
                        }).ToList();
            return _lstghct;
        }

        public string UpdateGioHangChiTiet(Guid id, GioHangCT ghct)
        {
            if (ghct == null) return "Cap nhat that bai.";
            if (_ighct.UpdateGHCT(ghct)) return "Cap nhat thanh cong ";
            return "Cap nhat that bai.";
        }
    }
}
