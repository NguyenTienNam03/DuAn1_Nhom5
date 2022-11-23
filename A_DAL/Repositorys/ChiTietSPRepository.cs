using System;
using A_DAL.IRepositorys;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Models;
using A_DAL.Context;

namespace A_DAL.Repositorys
{
    public class ChiTietSPRepository : IChiTietSPRepository
    {
        public QuanLyBanGiayDBContext _context;
        private List<ChiTietSanPham> _lstctsp;
        public ChiTietSPRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstctsp = new List<ChiTietSanPham>();
        }
        public bool AddChiTietSP(ChiTietSanPham chiTietSanPham)
        {
            if(chiTietSanPham== null) return false;
            chiTietSanPham.Id = Guid.NewGuid();
            _context.ChiTietSanPhams.Add(chiTietSanPham);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteChiTietSP(Guid id)
        {
            if(id == null) return false;
            var ctsp = _context.ChiTietSanPhams.FirstOrDefault(x => x.Id == id);
            _context.ChiTietSanPhams.Remove(ctsp);
            _context.SaveChanges();
            return true;
        }

        public ChiTietSanPham GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.ChiTietSanPhams.FirstOrDefault(c => c.Id == id);
        }

        public List<ChiTietSanPham> GetChiTietSP()
        {
            return _lstctsp = _context.ChiTietSanPhams.ToList();
        }

        public bool UpdateChiTietSP(Guid id, ChiTietSanPham chiTietSanPham)
        {
            if (id == null) return false;
            var ctsp = _context.ChiTietSanPhams.FirstOrDefault(c => c.Id == id);
            ctsp.IDSP = chiTietSanPham.IDSP;
            ctsp.IDMauSac = chiTietSanPham.IDMauSac;
            ctsp.IDHSX = chiTietSanPham.IDHSX;
            ctsp.IDSize = chiTietSanPham.IDSize;
            ctsp.SoLuong = chiTietSanPham.SoLuong;
            ctsp.Anh = chiTietSanPham.Anh;
            ctsp.GiaBan = chiTietSanPham.GiaBan;
            ctsp.GiaNhap = chiTietSanPham.GiaNhap;
            ctsp.TrangThai = chiTietSanPham.TrangThai;
            _context.ChiTietSanPhams.Update(ctsp);
            _context.SaveChanges();
            return true;
        }
    }
}
