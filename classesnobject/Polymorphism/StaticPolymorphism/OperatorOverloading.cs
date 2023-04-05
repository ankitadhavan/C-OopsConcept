using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Polymorphism.StaticPolymorphism
{
    class OperatorOverloading
    {
        public string name;
        public int id;
       

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading obj3 = new OperatorOverloading();
            obj3.name = obj1.name + obj2.name;
            obj3.id = obj1.id + obj2.id;
            return obj3;
        }
        
       
    }
}
