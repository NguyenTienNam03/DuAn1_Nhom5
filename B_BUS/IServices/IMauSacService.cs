using A_DAL.Models;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IMauSacService
    {
        public string AddMauSac(MauSac mauSac);
        public string UpdateMauSac(Guid id , MauSac mauSac);
        public string DeleteMauSac(Guid id);
        List<MauSacView> GetAllMS();
    }
}
