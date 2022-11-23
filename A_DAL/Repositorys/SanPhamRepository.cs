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
    public class SanPhamRepository : ISanPhamRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<SanPham> _lstsp;
        public SanPhamRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstsp= new List<SanPham>();
        }
        public bool AddSP(SanPham sp)
        {
            if (sp == null) return false;
            sp.ID = Guid.NewGuid();
            _context.sanPhams.Add(sp);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSP(Guid id)
        {
            if(id == null) return false;
            var sp1 = _context.sanPhams.FirstOrDefault(c => c.ID == id);
            _context.sanPhams.Remove(sp1);
            _context.SaveChanges();
            return true;
        }

        public List<SanPham> GetAllSP()
        {
            return _lstsp = _context.sanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.sanPhams.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateSP(Guid id, SanPham sp)
        {
            if (id == null) return false;
            var sp1 = _context.sanPhams.FirstOrDefault(c => c.ID == id);
            sp1.TenSP = sp.TenSP;
            _context.sanPhams.Update(sp1);
            _context.SaveChanges();
            return true;
        }
    }
}
