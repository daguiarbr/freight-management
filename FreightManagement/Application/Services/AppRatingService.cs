using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class AppRatingService : AppServiceBase<Rating>, IAppRatingService
    {
        private readonly IRatingService _ratingService;

        public AppRatingService(IRatingService ratingService)
            : base(ratingService)
        {
            _ratingService = ratingService;
        }
    }
}
