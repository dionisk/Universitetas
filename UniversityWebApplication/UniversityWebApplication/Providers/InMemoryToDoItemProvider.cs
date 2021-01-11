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
    }
}
