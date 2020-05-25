using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManageAPI.ApplicationService;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        private ITaskRepository _taskRepository;

        public TaskController(ITaskRepository userRepository)
        {
            _taskRepository = userRepository;
        }

        [HttpPost]
        public IActionResult Post(int userid, string title, string content, DateTime dueDate)
        {
            var service = new TaskApplicationService(_taskRepository);
            var result = service.Create(userid, title, content, dueDate);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}