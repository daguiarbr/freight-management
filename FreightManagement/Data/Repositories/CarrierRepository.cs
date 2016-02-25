﻿using System.Linq;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;
using LinqKit;

namespace Data.Repositories
{
    public class CarrierRepository : RepositoryBase<Carrier>, ICarrierRepository
    {
        public IEnumerable<Carrier> Search(string companyName, string cnpj)
        {
            var condition = PredicateBuilder.True<Carrier>();
            if (!string.IsNullOrEmpty(companyName))
            {
                condition = condition.And(m => m.CompanyName.ToLower().Contains(companyName.ToLower()));
            }

            if (!string.IsNullOrEmpty(cnpj))
            {
                condition = condition.And(m => m.Cnpj.Equals(cnpj));
            }

            return Db.Carriers.AsExpandable().Where(condition);
        }
    }
}
