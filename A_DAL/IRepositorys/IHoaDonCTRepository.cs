﻿using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositorys
{
    public interface IHoaDonCTRepository
    {
        bool AddHoaDonCT(HoaDonCT hdct);
        bool DeleteHoaDonCT(HoaDonCT hdct);
        List<HoaDonCT> GetAll();
        HoaDonCT GetById(Guid id);

    }
}
