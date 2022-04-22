﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface ICategorySalesFor1997Service:IGenericService<CategorySalesFor1997, DtoCategorySalesFor1997>
    {
        IQueryable<DtoCategorySalesFor1997> GetTotalReport();

    }
}
