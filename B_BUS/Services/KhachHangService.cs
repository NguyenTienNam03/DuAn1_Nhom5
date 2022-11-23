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
    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository _ikhs;
        public KhachHangService()
        {
            _ikhs = new KhachHangRepository();
        }
        public string AddKH(KhachHang KH)
        {
            if (KH == null) return "Them KH That bai.";
            if (_ikhs.AddKhachHang(KH)) return "Them KHach Hang thanh cong.";
            return "Them KH That bai."; 
        }

        public string DeleteKH(Guid id)
        {
            if (id == null) return "Xoa KH That bai.";
            if (_ikhs.DeleteKhachHang(id)) return "Xoa KH Thanh cong.";
            return "Xoa KH That bai.";
        }

        public List<KhachHangView> GetAllKH()
        {
            List<KhachHangView> _lst = new List<KhachHangView>();
            _lst = (from a in _ikhs.GetAllHangs()
                    select new KhachHangView
                    {
                        ID = a.ID ,
                        TenKH = a.Ten ,
                        DiaChi = a.DiaChi ,
                        Email = a.Email ,
                        MaKH = a.MaKH ,
                        MatKhau = a.MatKhau ,
                        SDT = a.SDT ,
                        TrangThai = a.TrangThai ,
                    }).ToList();
            return _lst;
        }

        public string UpdateKH(Guid id, KhachHang KH)
        {
            if (id == null) return "Cap Nhat Khach hang that bai.";
            if (_ikhs.UpdateKhachHang(id, KH)) return "Cap nhat khach hang thanh cong .";
            return "Cap Nhat Khach hang that bai.";
        }
    }
}
