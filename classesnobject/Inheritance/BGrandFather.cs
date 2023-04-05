using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Inheritance
{
    class BGrandFather
    {
       public int id;
      public  string FirstName;
      public  string LastName;
        public void printFullName()
        {
            Console.WriteLine(this.FirstName+this.LastName);
            Console.WriteLine("this is base class of hericiacl class");
        }
    }
}
