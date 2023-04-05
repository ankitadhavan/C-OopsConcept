using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject
{
    class Constructor
    {
      public  int age;
      public  string name;
       public static int a;
      
        public  static string PersonName;
        //default constructor
        //public Constructor()
        //{
        //    Console.WriteLine("default constructor invoked");
        //}


        //paramterize Constructor
        public Constructor(int a,int b)
        {
            Console.WriteLine(a+b);
            Console.WriteLine("First paramterize constructor invoked");

        }
       
        public Constructor(int roll,string fn,string ln  )
        {
          
            Console.WriteLine("second parameterize constructor invoked{0}",roll+fn+ln);
        }
      

        //static constructor

        static Constructor()
        {
            PersonName = "ANkita";

            Console.WriteLine("static constructor invoked");
        }
        public static void staticConstructorMethod()
        {
            Console.WriteLine("this is static constructor:{0}",PersonName);

        }
        //copy constructor;
        public Constructor(int ag ,string nm)
        {
           this.age = ag;
            this.name = nm;
        } 
        public Constructor(Constructor e)
        {
            this.age = e.age;
            this.name = e.name;
        }
        public void copyConstructorGetMethod()
        {
            Console.WriteLine("this is copy constructo{0}r",name);
            Console.WriteLine("this is copy constructo{0}r", age);
        }
        //Private constructor

        private Constructor()
        {
            Console.WriteLine("private constructor invoked");

        }
        public static int privateConstructorMethod()
        {
            return --a;
        }


        ~Constructor()
        {
            Console.WriteLine("destroctor invoked");
        }
    }
}
