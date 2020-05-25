using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManageAPI.DomainModel
{
    public class Task
    {
        public int taskId { get; set; }

        public int userId { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public DateTime dueDate { get; set; }

        public bool isCompleted { get; private set; }

        public Task(int id, string title, string content, DateTime dueDate)
        {
            this.userId = id;
            this.title = title;
            this.content = content;
            this.dueDate = dueDate;
            this.isCompleted = false;   // インスタンスが作られるときは毎回未完了
        }

    }
}
