using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface ISizeRepository
    {
        bool AddSize(Size size);
        bool UpdateSize(Size size);
        bool DeleteSize(Size size);
        List<Size> GetAllSizes();
        Size GetSizeById(Guid id);
    }
}
