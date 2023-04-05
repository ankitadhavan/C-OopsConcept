using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Polymorphism.DynamicPolymorphism
{
    class MHChild:MethodHiding
    {
        public  new void show()
        {
           // base.show();
            Console.WriteLine("this is child method hiding class");

        }
    }
}
