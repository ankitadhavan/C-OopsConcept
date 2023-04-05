using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Inheritance.SingleInheritance
{
    class Base
    {
        public static int id;
        public static  string firstName;
        public static string LastName;
        public static void fullname()
        {
            Console.WriteLine("this is base class of single inheritance ");
            
            Console.WriteLine(firstName="kiran");
            Console.WriteLine(LastName="Dhavan");

        }
    }
}
