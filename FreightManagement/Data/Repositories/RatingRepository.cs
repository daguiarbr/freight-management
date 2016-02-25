using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using LinqKit;

namespace Data.Repositories
{
    public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        public IEnumerable<Rating> GetByFilter(string companyName, int rate)
        {
            var condition = PredicateBuilder.True<Rating>();
            if (!string.IsNullOrEmpty(companyName))
            {
                condition = condition.And(m => m.Carrier.CompanyName.ToLower().Contains(companyName.ToLower()));
            }

            if (rate > 0)
            {
                condition = condition.And(m => m.RateType.Equals(rate));
            }

            return Db.Ratings.AsExpandable().Where(condition);
        }
    }
}
