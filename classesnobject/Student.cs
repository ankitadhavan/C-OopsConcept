using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject
{
  public  class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public string city;


        //public void set(int id)
        //{
        //    this.id = id;
        //}
        //public int get()
        //{
        //    return this.id;
        //}
        public void setAll(int id, string fn, string ln, string ct)
        {
            this.id = id;
            this.firstName = fn;
            this.lastName =ln;
            this.city = ct;

          
        }
        public void getAll()
        {
            Console.WriteLine("this is id :{0}", this.id);
            Console.WriteLine("this is firstName{0}",this.firstName);
            Console.WriteLine("this is lastname{0}", this.lastName);
            Console.WriteLine("this is CityNAme{0}",this.city);
        }
    }
}
