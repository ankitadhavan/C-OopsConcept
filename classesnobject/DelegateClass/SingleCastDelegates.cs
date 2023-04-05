using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.DelegateClass
{
    public delegate void Addition(int num,int num2);
    class SingleCastDelegates
    {
        public  static void Addition(int num,int num2)
        {
            int result = num + num2;
            Console.WriteLine( "addition of num1 and num2 is{0}",result);
        }
    }
}
