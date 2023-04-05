using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Anonymous
{
    public delegate void ParameterAno(int a );
    class ParameterAnonymous
    {
        public  static void Increment(ParameterAno  para ,int a)
        {
            a += 10;
            para.Invoke(a);

        }
       
    }
}
