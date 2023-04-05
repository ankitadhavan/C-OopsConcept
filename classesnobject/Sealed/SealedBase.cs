using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Sealed
{
    class SealedBase
    {
        //use sealed keyword==>no override
        public   void Run()
        {
            Console.WriteLine("this is first sealed class");
        }
    }
}
