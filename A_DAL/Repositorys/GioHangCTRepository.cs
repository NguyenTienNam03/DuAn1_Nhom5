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
    public class GioHangCTRepository : IGioHangCTRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<GioHangCT> _lstghct;
        public GioHangCTRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstghct= new List<GioHangCT>();
        }
        public bool AddGHCT(GioHangCT ghct)
        {
            if(ghct == null) return false;
            _context.gioHangCTs.Add(ghct);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteGHCT(GioHangCT ghct)
        {
            if(ghct == null) return false;
            var ghct1 = _context.gioHangCTs.FirstOrDefault(c => c.IDGH == ghct.IDGH);
            _context.gioHangCTs.Remove(ghct1);
            _context.SaveChanges();
            return true;
        }

        public List<GioHangCT> GetAll()
        {
            return _lstghct = _context.gioHangCTs.ToList();
        }

        public GioHangCT GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.gioHangCTs.FirstOrDefault(c => c.IDGH == id);

        }

        public bool UpdateGHCT(Guid id , GioHangCT ghct)
        {
            if(ghct == null) return false;
            var ghct1 = _context.gioHangCTs.FirstOrDefault(c => c.IDGH == id);
            ghct1.IDSP = ghct.IDSP;
            ghct1.SoLuong = ghct.SoLuong;
            _context.gioHangCTs.Update(ghct1);
            _context.SaveChanges();
            return true;
        }
    }
}
