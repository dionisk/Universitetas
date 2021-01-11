using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApplication.Exceptions
{
    public class ProviderHasNoDataException : Exception
    {
        public ProviderHasNoDataException(int id) : base($"Item with id:{id} is not found in repository.")
        {
        }
    }
}
