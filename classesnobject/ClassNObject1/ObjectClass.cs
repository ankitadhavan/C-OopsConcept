using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.ClassNObject1
{
 public   class ObjectClass
    {
        public int id;
        public string firstName;
        public string lastName;
        public string city;
        
        public void set(int id)
        {
            this.id = id;
        }
        public int get()
        {
            return this.id;
        }

        public void setAll(string fn,string ls,string city )
        {
            this.firstName = fn;
            this.lastName = ls;
            this.city = city;
     
        }
        public void GetAll()
        {
            Console.WriteLine( this.firstName);
            Console.WriteLine(this.lastName);
            Console.WriteLine(this.city);    
        }
    }
}
