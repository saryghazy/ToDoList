using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public class TaskItem
    {
        public int Id { get;  set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
