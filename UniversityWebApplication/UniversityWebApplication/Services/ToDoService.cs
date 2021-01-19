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
            if (!ToDoItemProvider.HasItemWithTheSameName(ToDoItem))
            {
                ToDoItemProvider.Add(ToDoItem);
            }
            else
            {
                throw new ToDoItemProviderHasAlreadyTheSameNameException(ToDoItem.Name);
            }
            
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
