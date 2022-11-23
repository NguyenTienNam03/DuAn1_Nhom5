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
    public class SizeRepository : ISizeRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<Size> _lstsize;
        public SizeRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstsize = new List<Size>();
        }
        public bool AddSize(Size size)
        {
            if (size == null) return false;
            size.ID = Guid.NewGuid();
            _context.sizes.Add(size);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSize(Size size)
        {
            if(size == null) return false;
            var size1 = _context.sizes.FirstOrDefault(c => c.ID == size.ID);
            _context.sizes.Remove(size1);
            _context.SaveChanges();
            return true;
        }

        public List<Size> GetAllSizes()
        {
            return _lstsize = _context.sizes.ToList();
        }

        public Size GetSizeById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.sizes.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateSize(Size size)
        {
            if(size == null) return false;
            var size1 = _context.sizes.FirstOrDefault(c =>c.ID == size.ID); 
            size1.SoSize = size.SoSize; 
            _context.sizes.Update(size1);
            _context.SaveChanges();
            return true;
        }
    }
}
