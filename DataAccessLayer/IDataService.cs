using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataService
    {
        public IEnumerable<T> GetData<T>();

        //public T GetSingleItem<T>(Guid id);
    }
}
