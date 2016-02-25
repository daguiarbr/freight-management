using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class AppUserService : AppServiceBase<User>, IAppUserService
    {
        private readonly IUserService _appUserService;

        public AppUserService(IUserService appUserService)
            : base(appUserService)
        {
            _appUserService = appUserService;
        }

        public User GetByStringId(string id)
        {
            return _appUserService.GetByStringId(id);
        }
    }
}
