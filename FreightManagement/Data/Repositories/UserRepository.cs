using System.Linq;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User GetByStringId(string id)
        {
            return Db.Set<User>().FirstOrDefault(m => m.UserId.ToLower().Equals(id.ToLower()));
        }
    }
}
