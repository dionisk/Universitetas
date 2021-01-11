using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Services
{
    public class ToDoService : IToDoService
    {
        public List<ToDoItem> ToDoItems { get; set; }

        public ToDoService()
        {
            ToDoItems = new List<ToDoItem>();
        }

        public void Add(ToDoItem ToDoItem)
        {
            ToDoItems.Add(ToDoItem);
        }

        public void Delete(ToDoItem ToDoItem)
        {
            ToDoItems.Remove(ToDoItem);
        }

        public void Edit(ToDoItem ToDoItem, int Id, string Name, string Description, DateTime CreationDate, DateTime DeadLineDate, int Priority, ToDoItemStatus Status, int CategoryId)
        {
            
        }
    }
}
