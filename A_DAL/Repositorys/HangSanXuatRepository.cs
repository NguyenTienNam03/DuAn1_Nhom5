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
    public class HangSanXuatRepository : IHangSanXuatRepository
    {
        public QuanLyBanGiayDBContext _context;
        List<HangSanXuat> _lsthsx;
        public HangSanXuatRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lsthsx = new List<HangSanXuat>();
        }
        public bool AddHSX(HangSanXuat hsx)
        {
            if(hsx == null) return false;
            hsx.ID = Guid.NewGuid();
            _context.hangSanXuats.Add(hsx);
            _context.SaveChanges(); 
            return true;

        }

        public bool DeleteHSX(Guid Id)
        {
            if(Id == null) return false;
            var hsx1 = _context.hangSanXuats.FirstOrDefault(h => h.ID == Id);
            _context.hangSanXuats.Remove(hsx1);
            _context.SaveChanges();
            return true;
        }

        public HangSanXuat GetALLByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.hangSanXuats.FirstOrDefault(c => c.ID == id);

        }

        public List<HangSanXuat> GetAllHSXs()
        {
            
            return _lsthsx = _context.hangSanXuats.ToList();
        }

        public bool UpdateHSX(Guid id, HangSanXuat hsx)
        {
            if  (id == null ) return false;
            var hsx1 = _context.hangSanXuats.FirstOrDefault(c => c.ID ==id);
            //hsx1.MaHangSX = hsx.MaHangSX;
            hsx1.TenHSX= hsx.TenHSX;
            _context.hangSanXuats.Update(hsx1);
            _context.SaveChanges();
            return true;
        }
    }
}
