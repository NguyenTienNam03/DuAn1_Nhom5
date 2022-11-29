using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface INhanVienService
    {
        public string AddNV(NhanVien nv);
        public string UpdateNV(Guid id, NhanVien nv);
        public string UpdateMatKhau(string id, NhanVien nv);
        public string DeleteNV(Guid id);
        List<NhanVienView> GetAllNV();
    }
}
