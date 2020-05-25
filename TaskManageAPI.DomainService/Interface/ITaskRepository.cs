using System;
using System.Collections.Generic;
using System.Text;
using TaskManageAPI.DomainModel;

namespace TaskManageAPI.DomainService.Interface
{
    public interface ITaskRepository
    {
        public void Add(Task user);

    }
}
