using System;
using System.Collections.Generic;
using System.Text;
using TaskManageAPI.DomainModel;

namespace TaskManageAPI.DomainService.Interface
{
    public interface IUserRepository
    {
        public void Add(User user);
        public List<User> Get();

    }
}
