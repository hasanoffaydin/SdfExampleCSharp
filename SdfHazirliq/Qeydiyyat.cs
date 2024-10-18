using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdfHazirliq
{
    internal class Qeydiyyat<T> : IstifadecilerAdd<T>
    {

        List<T> list = new List<T>();
        public void add(T t)
        {
            list.Add(t);
        }
        
    }
}
