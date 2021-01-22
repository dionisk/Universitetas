using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Exceptions;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Providers
{
    public class InMemoryToDoItemProvider : InMemoryDataProvider<ToDoItem>
    {
        public InMemoryToDoItemProvider() : base()
        {


        }

        public void CheckForUniqueNameWhileAddingNewItem(string toDoItemName)
        {
            foreach (ToDoItem ItemInCollection in Data)
            {

                if (toDoItemName.Equals(ItemInCollection.Name))
                {
                    throw new ToDoItemProviderHasAlreadyTheSameNameException(toDoItemName);
                }
            }
        }

        public void CheckForUniqueNameWhileUpdatingExistingItem(ToDoItem toDoItem)
        {
            ToDoItem oldItem = Get(toDoItem.Id);
            Data.Remove(oldItem);
            foreach (ToDoItem ItemInCollection in Data)
            {

                if (toDoItem.Name.Equals(ItemInCollection.Name))
                {
                    Data.Add(oldItem);
                    throw new ToDoItemProviderHasAlreadyTheSameNameException(toDoItem.Name);
                }
            }
            Data.Add(oldItem);
        }
    }
}
