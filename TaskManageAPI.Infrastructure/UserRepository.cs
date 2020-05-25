using System;
using System.Collections.Generic;
using TaskManageAPI.DomainModel;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.Infrastructure
{
    public class UserRepository: IUserRepository
    {
        public List<User> users = new List<User>();

        public void Add(User user)
            => users.Add(user);

        public List<User> Get()
        {
            return users;
        }

    }
}
