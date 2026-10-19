using System;
namespace ConsoleToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> tasks = new List<ToDoItem>();
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("===To-Do List Menu===");
                Console.WriteLine("1.Add task");
                Console.WriteLine("2.View tasks");
                Console.WriteLine("3.Delete task");
                Console.WriteLine("4.Exit");
                Console.WriteLine("5.Update Status of task");
                Console.Write("Choose an option:");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            {
                                TaskUtil.AddTask(tasks);
                                break;
                            }
                        case 2:
                            {
                                TaskUtil.ViewTasks(tasks);
                                break;
                            }
                        case 3:
                            {
                                TaskUtil.DeleteTask(tasks);
                                break;
                            }
                        case 4:
                            {
                                isExit = true;
                                Console.WriteLine("Exiting Console App!!!");
                                break;
                            }
                        case 5:
                            {
                                TaskUtil.UpdateStatus(tasks);
                                break;
                            }
                        default:
                            Console.WriteLine("Please a valid choice b/w option 1-4:");
                            break;
                    }
                }
            }
        }
    }
}
