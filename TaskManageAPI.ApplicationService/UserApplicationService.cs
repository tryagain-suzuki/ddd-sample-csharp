using System;
using TaskManageAPI.DomainModel;
using TaskManageAPI.DomainService;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.ApplicationService
{
    public class UserApplicationService
    {

        private IUserRepository _userRepository;
            

        public UserApplicationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public bool Create(string email, string name)
        {
            if (new UserService(_userRepository).IsDuplicated(email)) return false;

            var user = new User { userId = 0, email = email, name = name };
            _userRepository.Add(user);
            
            return true;
        }

    }
}
