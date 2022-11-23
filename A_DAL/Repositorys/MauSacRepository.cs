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
    public class MauSacRepository : IMauSacRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<MauSac> _lstms;
        public MauSacRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstms= new List<MauSac>();
        }
        public bool AddMauSac(MauSac ms)
        {
            if(ms == null) return false;
            ms.ID = Guid.NewGuid();
            _context.mausacs.Add(ms);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteMauSac(Guid id)
        {
            if(id == null) return false;
            var ms1 = _context.mausacs.FirstOrDefault(c =>c.ID == id);
            _context.mausacs.Remove(ms1);
            _context.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _lstms = _context.mausacs.ToList();
        }

        public MauSac GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.mausacs.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateMauSac(Guid id, MauSac ms)
        {
            if(id ==null) return false;
            var ms1 = _context.mausacs.FirstOrDefault(c => c.ID == id);
            ms1.Mau = ms.Mau;
            _context.mausacs.Update(ms1);
            _context.SaveChanges();
            return true;
        }
    }
}
