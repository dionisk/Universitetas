using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Exceptions;
using UniversityWebApplication.Models;
using UniversityWebApplication.Providers;

namespace UniversityWebApplication.Services
{
    public class ToDoService : IToDoService
    {
        public InMemoryToDoItemProvider ToDoItemProvider { get; set; }

        public ToDoService()
        {
            ToDoItemProvider = new InMemoryToDoItemProvider();
        }

        public void Add(ToDoItem ToDoItem)
        {
            try
            {
                ToDoItemProvider.CheckForUniqueNameWhileAddingNewItem(ToDoItem.Name);
                ToDoItemProvider.Add(ToDoItem);
            }
            catch (Exception)
            {
                throw;
            }                                                 
        }

        

        public void Delete(int id)
        {
            ToDoItemProvider.Remove(id);
        }

        public void Edit(ToDoItem ToDoItem)
        {
            try
            {
                ToDoItemProvider.CheckForUniqueNameWhileUpdatingExistingItem(ToDoItem);
                ToDoItemProvider.Update(ToDoItem);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
