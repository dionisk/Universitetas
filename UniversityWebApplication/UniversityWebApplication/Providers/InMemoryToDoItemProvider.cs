using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Providers
{
    public class InMemoryToDoItemProvider : InMemoryDataProvider<ToDoItem>
    {
        public InMemoryToDoItemProvider() : base()
        {


        }

        public bool HasItemWithTheSameName(ToDoItem toDoItem)
        {
            bool HasItemWithTheSameName = false;
            foreach (ToDoItem ItemInCollection in Data)
            {

                if (toDoItem.Name.Equals(ItemInCollection.Name))
                {
                    HasItemWithTheSameName = true;
                    break;
                }

            }
            return HasItemWithTheSameName;
        }
    }
}
