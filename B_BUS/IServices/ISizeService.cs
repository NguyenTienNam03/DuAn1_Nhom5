using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ISizeService
    {
        public string AddSize(Size size);
        public string UpdateSize(Guid id , Size size);
        public string DeleteSize(Guid id);
        List<SizeView> GetSizes();
    }
}
