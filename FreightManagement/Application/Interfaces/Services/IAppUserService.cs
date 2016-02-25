using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAppUserService : IAppServiceBase<User>
    {
        User GetByStringId(string id);
    }
}
