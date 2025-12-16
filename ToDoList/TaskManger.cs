using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    internal class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        public void AddTask(string title)
        {
            var task = new TaskItem
            {
                Id = tasks.Count + 1,
                Title = title,
                IsDone = false
            };
            tasks.Add(task);
        }
        public List<TaskItem> GetAllTasks()
        {
            return tasks;
        }
    }
}
