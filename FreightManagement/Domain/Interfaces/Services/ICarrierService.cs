﻿using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface ICarrierService : IServiceBase<Carrier>
    {
        IEnumerable<Carrier> Search(string companyName, string cnpj);
    }
}
