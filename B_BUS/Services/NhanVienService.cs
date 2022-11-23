using A_DAL.IRepositorys;
using A_DAL.Models;
using A_DAL.Repositorys;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _Invs;
        private IChucVuRepository _Icvs;
        public NhanVienService()
        {
            _Invs = new NhanVienRepository();
            _Icvs = new ChucVuRepository();
        }
        public string AddNV(NhanVien nv)
        {
            if (nv == null) return "Thêm thất bại nhân viên.";
            if (_Invs.AddNV(nv)) return "Thêm thành công nhân viên ."; ;
            return "Thêm thất bại nhân viên.";
        }

        public string DeleteNV(Guid id)
        {
            if (id == null) return "Xoá thất bại.";
            if (_Invs.DeleteNV(id)) return "Xoá thành công.";
            return "Xoá thất bại.";
        }

        public List<NhanVienView> GetAllNV()
        {
            List<NhanVienView>  _lstnv = new List<NhanVienView>();
            _lstnv = (from a in _Invs.GetNhanVien()
                      join b in _Icvs.GetAllChucVu() on a.IDCV equals b.ID
                      select new NhanVienView
                      {
                          ID = a.ID,
                          IDCV = b.ID,
                          MaNV = a.MaNV,
                          Ten = a.Ten,
                          GioiTinh = a.GioiTinh,
                          NgaySinh = a.NgaySinh,
                          DiaChi = a.DiaChi,
                          SDT = a.SDT,
                          Email = a.Email,
                          TrangThai = a.TrangThai,
                          MatKhau = a.MatKhau
                      }).ToList();
            return _lstnv;
        }

        public string UpdateNV(Guid id, NhanVien nv)
        {
            if (id == null) return "Cập nhật thất bại.";
            if (_Invs.UpdateNV(id , nv )) return "Cập nhật thành công.";
            return "Cập nhật thất bại.";
        }
    }
}
