using System;
using System.Linq;
using TaskManageAPI.DomainModel;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.DomainService
{
    public class UserService
    {

        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsDuplicated(string email)
            =>  _userRepository.Get().Where(user => user.email == email).Any();
        

    }
}
