using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IChucVuService
    {
        public string AddChucVu(ChucVu chucVu);
        public string UpdateChucVu (Guid id , ChucVu chucVu);
        public string DeleteChucVu (Guid id);

        public List<ChucVuView> GetAllCV();
    }
}
