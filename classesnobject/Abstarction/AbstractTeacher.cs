using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Abstarction
{
    class AbstractTeacher:AbstractionClass

    {
        public string teacherName;
        public string teacherLastName;

        public override void PrintFull()
        {
            Console.WriteLine(  this.teacherLastName,this.id);
        }
    }
}
