using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.DelegateClass
{
    public delegate void Calculator(int a,int b);

   public class Delegates
    {
        public  static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("addition of a and b is {0}",result);
        }
        public static void Substritution(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("substritution of a and b is {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a *b;
            Console.WriteLine("multiplication of a and b is {0}", result);
        }
    }
}
