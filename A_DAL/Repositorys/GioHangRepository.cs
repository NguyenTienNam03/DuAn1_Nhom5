using A_DAL.Context;
using A_DAL.IRepositorys;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositorys
{
    public class GioHangRepository : IGioHangRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<GioHang> _lstgh;
        public GioHangRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstgh = new List<GioHang>();
        }
        public bool AddGioHang(GioHang gh)
        {
            if (gh == null) return false;
            gh.ID = Guid.NewGuid();
            _context.gioHangs.Add(gh);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteGioHang(GioHang gh)
        {
            if (gh == null) return false;
            var gh1 = _context.gioHangs.FirstOrDefault(c => c.ID == gh.ID);
            _context.gioHangs.Remove(gh1);
            _context.SaveChanges();
            return true;
        }

        public List<GioHang> GetAllHang()
        {
            return _lstgh = _context.gioHangs.ToList();
        }

        public GioHang GetghByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.gioHangs.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateGioHang(Guid id , GioHang gh)
        {
            if (gh == null) return false;
            var gh1 = _context.gioHangs.FirstOrDefault(c => c.ID == id);
            gh1.SoLuong = gh.SoLuong;
            gh1.DonGia = gh.DonGia;
            gh1.IDNV = gh.IDNV;
            _context.gioHangs.Update(gh1);
            _context.SaveChanges();
            return true;

            
        }
    }
}
