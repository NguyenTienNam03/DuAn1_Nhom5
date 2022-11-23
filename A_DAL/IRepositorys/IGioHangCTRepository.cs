using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IGioHangCTRepository
    {
        public bool AddGHCT(GioHangCT ghct);
        public bool UpdateGHCT(GioHangCT ghct);
        public bool DeleteGHCT(GioHangCT ghct);
        List<GioHangCT> GetAll();
        GioHangCT GetByID(Guid id);
    }
}
