using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManageAPI.ApplicationService;
using TaskManageAPI.DomainModel;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult Post(string email, string name)
        {
            var service = new UserApplicationService(_userRepository);
            var result = service.Create(email, name);

            if (result)
            {
                return Ok();
            } else
            {
                return BadRequest();
            }
        }
    }
}