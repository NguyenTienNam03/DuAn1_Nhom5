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
    public class GioHangService : IGioHangService
    {
        public IGioHangRepository _Ighs;
        public IKhachHangRepository _ikhs;
        public INhanVienRepository _invs;
        public GioHangService()
        {
            _ikhs = new KhachHangRepository();
            _invs= new NhanVienRepository();
            _Ighs = new GioHangRepository();
        }
        public string AddGioHang(GioHang gh)
        {
            if (gh == null) return "Them that bai.";
            if (_Ighs.AddGioHang(gh)) return "Them thanh cong .";
            return "Them that bai.";
        }

        public string DeleteGioHang(Guid id)
        {
            if (id == null) return "Xoa that bai.";
            if (_Ighs.DeleteGioHang(_Ighs.GetghByID(id))) return "Xoa thanh cong.";
            return "Xoa that bai.";
        }

        public List<GioHangView> GettAllGH()
        {
            List<GioHangView> _lstgh = new List<GioHangView>();
            _lstgh = (from a in _Ighs.GetAllHang()
                      join b in _invs.GetNhanVien() on a.IDNV equals b.ID 
                      join c in _ikhs.GetAllHangs() on a.IDKH equals c.ID 
                      select new GioHangView
                      {
                          ID= a.ID,
                          IDKH = c.ID ,
                          IDNV = b.ID,
                          MaGH = a.MaGH ,
                          SoLuong = a.SoLuong ,
                          DonGia = a.DonGia ,
                      }).ToList();
            return _lstgh;
        }

        public string UpdateGioHang(Guid id, GioHang gh)
        {
            if (gh == null) return "Cap nhat that bai.";
            if (_Ighs.UpdateGioHang( id ,gh)) return "Cap nhat thanh cong.";
            return "Cap nhat that bai.";
        }
    }
}
