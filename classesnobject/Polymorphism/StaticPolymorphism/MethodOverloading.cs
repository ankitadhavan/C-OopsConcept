using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Polymorphism.StaticPolymorphism
{
    class MethodOverloading
    {
      
       public void Add(int a,int b)
        {
            Console.WriteLine( a + b);
        }


        public void Add(int x, int y,int z)
        {
            Console.WriteLine(x+y+z);
        }
        
    }
}
