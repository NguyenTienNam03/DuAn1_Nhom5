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
    public class NhanVienRepository : INhanVienRepository
    {
        private QuanLyBanGiayDBContext _context;
        public NhanVienRepository()
        {
            _context = new QuanLyBanGiayDBContext();
        }
        public bool AddNV(NhanVien nv)
        {
            if(nv == null) { return false; }
            nv.ID = Guid.NewGuid();
            _context.nhanViens.Add(nv);
            _context.SaveChanges();
            return true;

        }

        public bool DeleteNV(Guid id)
        {
            if(id == null) { return false; }
            var nv1 = _context.nhanViens.FirstOrDefault(c => c.ID == id);
            _context.nhanViens.Remove(nv1);
            _context.SaveChanges();
            return true;
        }

        public NhanVien GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _context.nhanViens.FirstOrDefault(c => c.ID == id);
        }

        public List<NhanVien> GetNhanVien()
        {
            return _context.nhanViens.ToList();
        }

        public bool LayEmail(string email, NhanVien nv)
        {
            var nv1 = _context.nhanViens.FirstOrDefault(c => c.Email == email);
            nv1.MatKhau = nv.MatKhau;
            _context.nhanViens.Update(nv1);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateNV(Guid id, NhanVien nv)
        {
            if(id == null) return false;
            var nv1 = _context.nhanViens.FirstOrDefault(c => c.ID == id);
            //nv1.MaNV = nv.MaNV;
            nv1.Ten = nv.Ten;
            nv1.SDT = nv.SDT;
            nv1.IDCV =  nv.IDCV;
            nv1.DiaChi = nv.DiaChi;
            nv1.GioiTinh = nv.GioiTinh;
            nv1.NgaySinh = nv.NgaySinh;
            nv1.TrangThai = nv.TrangThai;
            nv1.Email = nv.Email;
            nv1.MatKhau = nv.MatKhau;
            _context.nhanViens.Update(nv1);
            _context.SaveChanges();
            return true;
        }
    }
}
