using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IKhachHangRepository
    {
        bool AddKhachHang(KhachHang kh);
        bool UpdateKhachHang(Guid id , KhachHang kh);
        bool DeleteKhachHang(Guid id);
        List<KhachHang> GetAllHangs();
        KhachHang GetAllKH(Guid id);
    }
}
