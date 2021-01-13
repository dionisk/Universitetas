using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Models;
using UniversityWebApplication.Providers;

namespace UniversityWebApplication.Services
{
    public interface IToDoService
    {
        public InMemoryDataProvider<ToDoItem> ToDoItemProvider { get; set; }
        public void Add(ToDoItem ToDoItem);

        public void Edit(ToDoItem ToDoItem);

        public void Delete(int id);
    }
}
