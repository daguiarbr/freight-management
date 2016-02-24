﻿using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface ICarrierRepository : IRepositoryBase<Carrier>
    {
        IEnumerable<Carrier> GetByCompanyName(string companyName);
    }
}
