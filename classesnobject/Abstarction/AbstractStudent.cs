using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Abstarction
{
    class AbstractStudent:AbstractionClass
    {
        public string studentName;
        public string studentLastName;

        public override void PrintFull()
        {
            Console.WriteLine(this.firstName+"  "+this.LastName+this.studentLastName);
        }
    }
}
