using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.DelegateClass
{
    public delegate void Show();
    public delegate void Calender(int a,int b,int c);
    public delegate void Fun(int a,int b);
    
    class MultipleDelegates
    {
        public static  void Show()
        {
            Console.WriteLine("this is show method of multiple delegates");
        }
        public static void Addition(int a,int b,int c)
        {
            int result = a + b + c;
            Console.WriteLine("Addition of multiple delegetes is {0}",result );

        }
        public static void Fun( int a,int b)
        {
            int result = a * b;
            Console.WriteLine("this is fun method of multiple delegate",result);
        }
    }

}
