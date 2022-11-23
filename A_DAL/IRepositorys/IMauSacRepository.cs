using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IMauSacRepository
    {
        bool AddMauSac(MauSac ms);
        bool UpdateMauSac(Guid id , MauSac ms);
        bool DeleteMauSac(Guid id);
        List<MauSac> GetAll();
        MauSac GetByID(Guid id);
    }
}
