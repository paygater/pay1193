﻿using Pay1193.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay1193.Service
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
        IEnumerable<TaxYear> GetAll();
        TaxYear GetById(int id);
    }
}
