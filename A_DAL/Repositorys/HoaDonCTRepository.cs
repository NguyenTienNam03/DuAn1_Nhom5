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
    public class HoaDonCTRepository : IHoaDonCTRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<HoaDonCT> _hoaDonCTs;
        public HoaDonCTRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _hoaDonCTs = new List<HoaDonCT>();
        }
        public bool AddHoaDonCT(HoaDonCT hdct)
        {
            if(hdct == null ) { return false; }
            _context.hoaDonCTs.Add(hdct);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonCT(HoaDonCT hdct)
        {
            if(hdct == null ) { return false; }
            _context.hoaDonCTs.Remove(hdct);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDonCT> GetAll()
        {
            return _hoaDonCTs = _context.hoaDonCTs.ToList();
        }

        public HoaDonCT GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.hoaDonCTs.FirstOrDefault(c => c.IDHD == id);
        }
    }
}
