using System;
namespace ConsoleToDo
{
        public enum TaskStatus
        {
            Pending,
            Completed
        }
    public class ToDoItem
    {

        public string Title { get; set; }
        public TaskStatus Status { get; set; }
        

        public ToDoItem(string title)
        {
            Title = title;
            Status = TaskStatus.Pending;
        }
    }
}