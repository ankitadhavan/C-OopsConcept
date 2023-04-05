using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Indexer
{
    class Indexerclass
    {
       private int[] age = new int[3];
        public int  this[int index]
        {
            set
            {
                if (index >= 0 && age.Length > index)
                {
                    if (value<=0)
                    {
                        Console.WriteLine("Please provide proper age input");
                    }
                    else
                    {
                        age[index] = value;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
                
            }
            get 
            {
                return age[index];
            }
           
        }
    }
}
