using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject
{
  static  class StaticClass
    {
        public static int roll;
        public static string name;
        public  static string lastName;

        static StaticClass()
        {
            roll = 45;
            name = "niku";
            lastName = "Dhavan";

        }
        public static void getStaticClassMathod()
        {
            Console.WriteLine("this is Static class method{0}",roll);
        }
        public static int getdiscount()
        {
           return  roll / 5;
        }


    }
}

