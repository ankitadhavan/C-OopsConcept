using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Sealed
{
    class SealedDerived: SealedBase
    {
        public new void Run()
        {
            base.Run();
           // Console.WriteLine("this is second sealed class");
        }
    }
}
