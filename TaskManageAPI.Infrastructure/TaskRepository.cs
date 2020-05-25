using System;
using System.Collections.Generic;
using TaskManageAPI.DomainModel;
using TaskManageAPI.DomainService.Interface;

namespace TaskManageAPI.Infrastructure
{
    public class TaskRepository: ITaskRepository
    {
        public List<Task> tasks = new List<Task>();

        public void Add(Task task)
            => tasks.Add(task);

    }
}
