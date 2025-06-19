using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeApplication.Interfaces
{
    public interface IRepositor<K, T> : IParentRepository<K, T> where T : class
    {
        T Update(T item);
        T Delete(K id);
        
    }
}
