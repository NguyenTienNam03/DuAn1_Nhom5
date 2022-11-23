using A_DAL.Context;
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
    public class ChiTietSPService : IChiTietSPService
    {
        public IChiTietSPRepository _Ictsps;
        public IHangSanXuatRepository _IHsxs;
        public ISizeRepository _Isize;
        public IMauSacRepository _Imss;
        public ISanPhamRepository _Isps;
        public ChiTietSPService() 
        {
            _Ictsps = new ChiTietSPRepository();
            _IHsxs = new HangSanXuatRepository();
            _Isize = new SizeRepository();
            _Imss = new MauSacRepository();
            _Isps = new SanPhamRepository();
        }
        public string AddCTSP(ChiTietSanPham ctsp)
        {
            if (ctsp == null) { return "Them San Pham That Bai."; }
            if (_Ictsps.AddChiTietSP(ctsp)) return "Them san pham thanh cong.";
            return "Them San Pham That Bai.";
        }

        public string DeleteCTSP(Guid id)
        {
            if (id == null) return "Xoa san pham that bai.";
            if (_Ictsps.DeleteChiTietSP(id)) return "Xoa thanh cong.";
            return "Xoa san pham that bai.";
        }

        public List<ChiTietSPView> GetAll()
        {
            List<ChiTietSPView> _lstctsp = new List<ChiTietSPView>();
            _lstctsp = (from a in _Ictsps.GetChiTietSP()
                        join b in _Imss.GetAll() on a.IDMauSac equals b.ID
                        join c in _IHsxs.GetAllHSXs() on a.IDHSX equals c.ID
                        join d in _Isize.GetAllSizes() on a.IDSize equals d.ID
                        join f in _Isps.GetAllSP() on a.IDSP equals f.ID
                        select new ChiTietSPView
                        {
                            ID = a.Id,
                            IDms = b.ID,
                            IDHSX = c.ID,
                            IDSize = d.ID,
                            IDSP = f.ID,
                            MaCTSP = a.MaSPCT,
                            SoLuong = a.SoLuong,
                            GiaBan = a.GiaBan,
                            GiaNhap = a.GiaNhap,
                            Trangthai = a.TrangThai,
                            anh = a.Anh
                        }).ToList();
            return _lstctsp;

                       
        }

        public string UpdateCRSP(Guid id, ChiTietSanPham ctsp)
        {
            if (id == null) return "Cap nhat that bai.";
            if (_Ictsps.UpdateChiTietSP(id, ctsp)) return "Cap nhat thanh cong.";
            return "Cap nhat that bai.";
        }
    }
}
