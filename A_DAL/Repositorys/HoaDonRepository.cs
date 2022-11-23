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
    public class HoaDonRepository : IHoaDonRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<HoaDon> _lsthd;
        public HoaDonRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lsthd = new List<HoaDon>();
        }
        public bool AddHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            hd.ID = Guid.NewGuid();
            _context.hoaDons.Add(hd);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(HoaDon hd)
        {
            if(hd == null) return false;
            var hd1 = _context.hoaDons.FirstOrDefault(c => c.ID == hd.ID);
            _context.hoaDons.Remove(hd1);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _lsthd = _context.hoaDons.ToList();
        }

        public HoaDon GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.hoaDons.FirstOrDefault(c => c.ID == id);
        }

        
    }
}
