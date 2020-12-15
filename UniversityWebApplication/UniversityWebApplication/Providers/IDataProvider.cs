using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApplication.Providers
{
    public interface IDataProvider<DataClass>
    {
        //Create
        void Add(DataClass item);

        //Read
        List<DataClass> GetAll();
        DataClass Get(int id);

        //Update
        void Update(DataClass item);

        //Delete
        void Remove(int id);
    }
}
