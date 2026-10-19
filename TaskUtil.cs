using System;
using static ConsoleToDo.ConsoleIO;
namespace ConsoleToDo
{
    internal class TaskUtil
    {

        public static void AddTask(List<ToDoItem> tasks)
        {
            string title = ReadString("Please a title of the task:");
            var task = new ToDoItem(title);
            tasks.Add(task);
            WriteLine("Successfully Added task to list");
        }

        public static void ViewTasks(List<ToDoItem> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list!");
                return;
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                ToDoItem task = tasks[i];
                string status = task.Status.ToString();
                WriteLine($" {i + 1}. {task.Title} - {status}");
            }
        }
        public static void DeleteTask(List<ToDoItem> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to delete");
                return;
            }
            ViewTasks(tasks);
            string deleteInput = ReadString("Do you want to delete all tasks(y/n):");
            if (deleteInput == "y")
            {
                tasks.Clear();
            }
            else if (deleteInput == "n")
            {
                int taskNumber = ReadInt("Please Enter no of Task to delete:");

                if (taskNumber <= tasks.Count && taskNumber >= 1)
                {
                    tasks.RemoveAt(taskNumber - 1);
                    WriteLine("task deleted successfully");
                }
            }
            else
            {
                Console.WriteLine("Please enter y or n");
            }
        }

        public static void UpdateStatus(List<ToDoItem> tasks)
        {
            if (tasks.Count == 0)
            {
                WriteLine("There are no tasks in the list to Update");
                return;
            }

            ViewTasks(tasks);

            int taskNumber = ReadInt("Enter the no of the Task to update status:");

            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                WriteLine("Please enter a valid tasks number");
                return;
            }

            WriteLine("Statues:");
            WriteLine("1.Pending");
            WriteLine("2.Completed");

            int statusInput = ReadInt("Please enter the no of option of you choice:");

            TaskStatus newStatus;

            switch (statusInput)
            {
                case 1:
                    {
                        newStatus = TaskStatus.Pending;
                        break;
                    }
                case 2:
                    {
                        newStatus = TaskStatus.Completed;
                        break;
                    }
                default:
                    {
                        WriteLine("Please enter a valid value");
                        return;
                    }
            }
            ToDoItem task = tasks[taskNumber - 1];
            task.Status = newStatus;
            WriteLine("Updated the status! Exiting to Menu :)");
        }
    }
}