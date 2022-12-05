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

        public bool DeleteHoaDonCT(Guid id )
        {
            if(id == null ) { return false; }
            var hdct1 = _context.hoaDonCTs.FirstOrDefault(c => c.IDHD == id);
            _context.hoaDonCTs.Remove(hdct1);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSP(Guid id)
        {
            if(id == null) { return false; }
            var hdct1 = _context.hoaDonCTs.FirstOrDefault(c => c.IDSP== id);
            _context.hoaDonCTs.Remove(hdct1);
            _context.SaveChanges();
            return true;
        }

        public List<HoaDonCT> GetAll()
        {
            return _hoaDonCTs = _context.hoaDonCTs.ToList();
        }

        public HoaDonCT GetById( Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.hoaDonCTs.FirstOrDefault(c => c.IDHD == id);
        }

        public bool UpdateHoaDonCT(Guid id, HoaDonCT hdct)
        {
            if(hdct == null ) return false;
            var hdct1 = _context.hoaDonCTs.FirstOrDefault(c => c.IDHD == id);
            hdct1.IDSP = hdct.IDSP;
            hdct1.SoLuong = hdct.SoLuong;
            hdct1.DonGia = hdct.DonGia;
            _context.hoaDonCTs.Update(hdct1);
            _context.SaveChanges();
            return true;    
        }
    }
}
