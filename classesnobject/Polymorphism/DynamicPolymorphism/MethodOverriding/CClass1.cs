using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Polymorphism.DynamicPolymorphism.MethodOverriding
{
    class CClass1:BaseClass
    {
        public override void Add()
        {
            base.Add();
          //  Console.WriteLine("this is third class of method override");
        }
    }
}
