using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IChucVuRepository
    {
        public bool AddChucVu(ChucVu chucVu);
        public bool UpdateChucVu(Guid id , ChucVu chucVu);
        public bool DeleteChucVu(Guid id );

        List<ChucVu> GetAllChucVu();
        ChucVu GetById(Guid id);

    }
}
