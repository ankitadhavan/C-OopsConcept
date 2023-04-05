using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Polymorphism.DynamicPolymorphism.MethodOverriding
{
    class BClass:BaseClass
    {
        public override void Add()
        {
            Console.WriteLine("this is second class of method override ");
        }
    }
}
