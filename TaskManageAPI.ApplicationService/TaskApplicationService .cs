using System;
using TaskManageAPI.DomainModel;
using TaskManageAPI.DomainService;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.ApplicationService
{
    public class TaskApplicationService
    {

        private ITaskRepository _taskRepository;
            

        public TaskApplicationService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }


        public bool Create(int userid, string title, string content, DateTime dueDate)
        {
            var task = new Task(userid, title, content, dueDate);
            _taskRepository.Add(task);
            
            return true;
        }

    }
}
