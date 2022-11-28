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
    public class KhachHangRepository : IKhachHangRepository
    {
        private QuanLyBanGiayDBContext _context;
        public List<KhachHang> _lstKH;
        public KhachHangRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstKH = new List<KhachHang>();
        }
        public bool AddKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
            kh.ID = Guid.NewGuid();
            _context.khachHangs.Add(kh);
            _context.SaveChanges();
            return true;

        }

        public bool DeleteKhachHang(Guid id)
        {
            if (id == null) return false;
            var kh1 = _context.khachHangs.FirstOrDefault(c => c.ID == id);
            _context.khachHangs.Remove(kh1);
            _context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAllHangs()
        {
            return _lstKH = _context.khachHangs.ToList();
        }

        public KhachHang GetAllKH(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.khachHangs.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateKhachHang(Guid id, KhachHang kh)
        {
            if(id == null ) return false;
            var kh1 = _context.khachHangs.FirstOrDefault(c => c.ID == id);
            //kh1.MaKH = kh.MaKH;
            kh1.SDT = kh.SDT;
            kh1.Ten = kh.Ten;
            kh1.DiaChi = kh.DiaChi;
            
            _context.khachHangs.Update(kh1);
            _context.SaveChanges();
            return true;
        }
    }
}
