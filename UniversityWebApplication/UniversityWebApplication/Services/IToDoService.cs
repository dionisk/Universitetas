using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Services
{
    public interface IToDoService
    {
        public List<ToDoItem> ToDoItems { get; set; }
        public void Add(ToDoItem ToDoItem);

        public void Edit(ToDoItem ToDoItem, int Id, string Name, string Description, DateTime CreationDate, DateTime DeadLineDate, int Priority, ToDoItemStatus Status, int CategoryId);

        public void Delete(ToDoItem ToDoItem);
    }
}
