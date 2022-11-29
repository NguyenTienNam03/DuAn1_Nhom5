using A_DAL.IRepositorys;
using A_DAL.Models;
using A_DAL.Repositorys;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class HoaDonCTService : IHoaDonCTService
    {
        public IHoaDonCTRepository _ihdcts;
        public IHoaDonRepository _ihds;
        public IChiTietSPRepository _ictsps;
        public HoaDonCTService()
        {
            _ihdcts = new HoaDonCTRepository();
            _ihds = new HoaDonRepository();
            _ictsps = new ChiTietSPRepository();
        }
        public string AddHDCT(HoaDonCT hdct)
        {
            if (hdct == null) return "Them that bai.";
            if (_ihdcts.AddHoaDonCT(hdct)) return "Them thanh cong.";
            return "Them that bai.";
        }

        public string DeleteHDCT(Guid id)
        {
            if (id == null) return "Xoa that bai.";
            if (_ihdcts.DeleteHoaDonCT(id)) return "Xoa thanh cong.";
            return "Xoa that bai.";
        }

        public List<HoaDonCT> GetAllHDCT()
        {
            List<HoaDonCT> _lsthdct = new List<HoaDonCT>();
            _lsthdct = (from a in _ihdcts.GetAll()
                        join b in _ictsps.GetChiTietSP() on a.IDSP equals b.Id
                        join c in _ihds.GetAll() on a.IDHD equals c.ID
                        select new HoaDonCT
                        {
                            IDHD = c.ID ,
                            IDSP = b.Id ,
                            SoLuong = a.SoLuong ,
                            DonGia = a.DonGia ,
                     
                        }).ToList();
            return _lsthdct;
        }

        public string UpdateHDCT(Guid id, HoaDonCT hdct)
        {
            if (hdct == null) return "Cập nhật thất bại.";
            if (_ihdcts.UpdateHoaDonCT(id, hdct)) return "Cập nhật thành công .";
            return "Cập nhật thất bại.";
        }
    }
}
