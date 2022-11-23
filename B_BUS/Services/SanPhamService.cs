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
    public class SanPhamService : ISanPhamService
    {
        public ISanPhamRepository _isps;
        public SanPhamService()
        {
            _isps = new SanPhamRepository();
        }
        public string AddSP(SanPham sanPham)
        {
            if (sanPham == null) return "Them san pham that bai.";
            if (_isps.AddSP(sanPham)) return "Them san pham thanh cong.";
            return "Them san pham that bai.";
        }

        public string DeleteSP(Guid id)
        {
            if (id == null) return "Xoa That bai.";
            if (_isps.DeleteSP(id)) return "Xoa thanh cong.";
            return "Xoa That bai.";
        }

        public List<SanPhamView> GetAllsp()
        {
            List<SanPhamView> _lstsp = new List<SanPhamView>();
            _lstsp = (from a in _isps.GetAllSP()
                      select new SanPhamView
                      {
                          IDsp = a.ID ,
                          Masp = a.MaSP ,
                          TenSp = a.TenSP ,
                      }).ToList();
            return _lstsp;
        }

        public string UpdateSp(Guid id, SanPham sanPham)
        {
            if (id == null) return "Cap nhat that bai.";
            if (_isps.UpdateSP(id, sanPham)) return "Cap nhat thanh cong.";
            return "Cap nhat that bai."; ;
        }
    }
}
