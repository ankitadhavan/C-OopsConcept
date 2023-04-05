using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Generics
{
    class GenericClass1<T>
    {
        public  static void Show<T>(T a,T b)
        {
           a.Equals(b);
        }

    }
}
