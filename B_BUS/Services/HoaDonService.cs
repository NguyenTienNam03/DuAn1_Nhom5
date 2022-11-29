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
    public class HoaDonService : IHoaDonService
    {
        public IHoaDonRepository _ihds;
        public INhanVienRepository _invs;
        public IKhachHangRepository _ikhs;
        public HoaDonService()
        {
            _ihds = new HoaDonRepository();
            _invs = new NhanVienRepository();
            _ikhs = new KhachHangRepository();
        }
        public string AddHoaDon(HoaDon hd)
        {
            if(hd == null) { return "Them hoa don that bai."; }
            if (_ihds.AddHoaDon(hd)) return "Them hoa don thanh cong.";
            return "Them hoa don that bai.";
        }

        public string DeleteHoaDon(Guid id)
        {
            if (id == null) return "Xoa hoa don that bai.";
            if (_ihds.DeleteHoaDon(_ihds.GetById(id))) return "Xoa hoa don thanh cong.";
            return "Xoa hoa don that bai.";
        }

        public List<HoaDonView> GetAllhd()
        {
            List<HoaDonView> _lsthd = new List<HoaDonView>();
            _lsthd = (from a in _ihds.GetAll()
                      join b in _ikhs.GetAllHangs() on a.IDKH equals b.ID
                      join c in _invs.GetNhanVien() on a.IDNV equals c.ID
                      select new HoaDonView
                      {
                          IDhd = a.ID ,
                          IDkh= b.ID,
                          IDnv= c.ID,
                          Mahd = a.MaHD ,
                          NgayTao = a.NgayTao,
                          SoLuong = a.SoLuong,
                          DonGia = a.DonGia,
                          TrangThai = a.TrangThai
                      }).ToList();
            return _lsthd;
        }

        public string UpdateHoaDon(Guid id, HoaDon hd)
        {
            if (hd == null) return "Cập nhật thất bại.";
            if (_ihds.UpdateHoaDon(id, hd)) return "Cập nhật thành công.";
            return "Cập nhật thất bại.";
        }
    }
}
