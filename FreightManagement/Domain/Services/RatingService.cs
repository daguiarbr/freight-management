using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class RatingService : ServiceBase<Rating>, IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
            : base(ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public IEnumerable<Rating> GetByFilter(string companyName, int rate)
        {
            return _ratingRepository.GetByFilter(companyName, rate);
        }
    }
}
