using System;
using System.Collections.Generic;
namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            
            while (true)
            {
                Console.WriteLine("-----------Welcome--------------");
                Console.WriteLine("\n1-Add Task");
                Console.WriteLine("2- List Task");
                Console.WriteLine("3- Exit");
                Console.Write("Please Enter Choice: ");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter Task Title:");
                        var title = Console.ReadLine();
                        taskManager.AddTask(title);
                        Console.WriteLine("Task Added Successfully!\n");
                        break;
                    case "2":
                        var tasks = taskManager.GetAllTasks();
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("📭 No tasks found");
                            break;
                        }
                        foreach (var task in tasks)
                        {
                            string status = task.IsDone ? "Done" : "Pending";
                            Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, Status: {status}");
                        }
                        break;
                        case "3":
                        Console.WriteLine("Thank you, See you Later");
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}