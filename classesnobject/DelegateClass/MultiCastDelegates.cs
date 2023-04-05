using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.DelegateClass
{

    public delegate void MultiCast(int input);
    class MultiCastDelegates
    {
        public static void Square(int input)
        {
            int result = input * input;
            Console.WriteLine("Square of {0}is{1}", input, result);

        }
        public static void cube(int input)
        {
            int result = input * input*input;
            Console.WriteLine("cube of {0}is{1}", input, result);
        }
    }
}
