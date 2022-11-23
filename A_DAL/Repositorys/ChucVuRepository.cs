using A_DAL.Context;
using A_DAL.IRepositorys;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositorys
{
    public class ChucVuRepository : IChucVuRepository
    {
        public QuanLyBanGiayDBContext _context;
        public List<ChucVu> _lstCV;
        public ChucVuRepository()
        {
            _context = new QuanLyBanGiayDBContext();
            _lstCV= new List<ChucVu>();
        }
        public List<ChucVu> GetAllChucVu()
        {
            return _lstCV = _context.chucVus.ToList();
        }
        public bool AddChucVu(ChucVu chucVu)
        {
            if(chucVu == null)
            {
                return false;
            }
            chucVu.ID = Guid.NewGuid();
            _context.chucVus.Add(chucVu);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteChucVu(Guid id)
        {
            if(id == null) 
                {
                    return false;
                } 
            var cv1 = _context.chucVus.FirstOrDefault(c => c.ID== id);
            _context.chucVus.Remove(cv1);
            _context.SaveChanges();
            return true;
        }

       

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.chucVus.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateChucVu(Guid id, ChucVu chucVu)
        {
            if(id == null) 
                {
                    return false;
                } 
            var cv1 = _context.chucVus.FirstOrDefault(c => c.ID == id);
            cv1.MaCV = chucVu.MaCV;
            cv1.TenCV = chucVu.TenCV;
            _context.chucVus.Update(cv1);
            _context.SaveChanges();
            return true;
        }
    }
}
