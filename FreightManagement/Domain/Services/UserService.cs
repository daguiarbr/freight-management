using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetByStringId(string id)
        {
            return _userRepository.GetByStringId(id);
        }
    }
}
