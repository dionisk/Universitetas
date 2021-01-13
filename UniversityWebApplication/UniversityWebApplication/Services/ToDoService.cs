using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Models;
using UniversityWebApplication.Providers;

namespace UniversityWebApplication.Services
{
    public class ToDoService : IToDoService
    {
        public InMemoryDataProvider<ToDoItem> ToDoItemProvider { get; set; }

        public ToDoService()
        {
            ToDoItemProvider = new InMemoryToDoItemProvider();
        }

        public void Add(ToDoItem ToDoItem)
        {
            ToDoItemProvider.Add(ToDoItem);
        }

        public void Delete(int id)
        {
            ToDoItemProvider.Remove(id);
        }

        public void Edit(ToDoItem ToDoItem)
        {
            ToDoItemProvider.Update(ToDoItem);
        }
    }
}
