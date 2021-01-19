using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApplication.Exceptions
{
    public class ToDoItemProviderHasAlreadyTheSameNameException : Exception
    {
        public ToDoItemProviderHasAlreadyTheSameNameException(string name) : base($"Item with name {name} already exists.")
        {

        }
    }
}
