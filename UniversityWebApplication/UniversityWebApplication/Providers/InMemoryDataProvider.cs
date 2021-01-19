using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityWebApplication.Exceptions;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Providers
{
    public class InMemoryDataProvider<DataClass> : IDataProvider<DataClass> where DataClass : IHasId
    {

        public InMemoryDataProvider()
            {
                Data = new List<DataClass>();
            }

    private static int MaxId = -1;

        public List<DataClass> Data { get; set; }

        public void Add(DataClass item)
        {
            item.Id = ++MaxId;
            Data.Add(item);
        }

        

        public List<DataClass> GetAll()
        {
            return Data;
        }

        public DataClass Get(int id)
        {
            DataClass item = Data.Find(d => d.Id == id);
            if (item == null)
            {
                throw new ProviderHasNoDataException(item.Id);
            }
            return item;
        }

        public void Update(DataClass item)
        {
            DataClass oldItem = Get(item.Id);
            if (item != null)
            {
                Data.Remove(oldItem);
                Data.Add(item);
            }
            else
            {
                throw new ProviderHasNoDataException(item.Id);
            }
        }

        public void Remove(int id)
        {
            DataClass item = Get(id);
            if (item != null)
            {
                Data.Remove(item);
            }
            else
            {
                throw new ProviderHasNoDataException(id);
            }
        }

    }
}
