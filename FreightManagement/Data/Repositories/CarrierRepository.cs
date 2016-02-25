using System.Linq;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;
using LinqKit;

namespace Data.Repositories
{
    public class CarrierRepository : RepositoryBase<Carrier>, ICarrierRepository
    {
        public IEnumerable<Carrier> GetByFilter(string companyName, string cnpj)
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


        public IEnumerable<Carrier> GetAllWithoutRating(string userId)
        {
            var userRatings = (from tbRatings in Db.Ratings
                               where tbRatings.UserId.ToLower().Equals(userId.ToLower())
                               select tbRatings.CarrierId);

            var result = (from tbCarriers in Db.Carriers
                          where !userRatings.Contains(tbCarriers.Id)
                          select tbCarriers);

            return result;
        }
    }
}
