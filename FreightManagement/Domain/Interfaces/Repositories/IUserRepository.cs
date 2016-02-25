﻿using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetByStringId(string id);
    }
}
