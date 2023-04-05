using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Abstarction
{
    class Abstraction
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
          double TaxId=0.1;
          double netSalary;

        public Abstraction(int empId,string empName,double grossPay)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.GrossPay = grossPay;
        }
        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxId * GrossPay);
                Console.WriteLine("salary is {0}",netSalary);
            }
            else
            {
                Console.WriteLine("salary is {0}",GrossPay);
            }
               

        }
        public  void TotalSalary()
        {
            Console.WriteLine("this is empId id{0}", this.EmpId);
                Console.WriteLine(  "this is empName{0} ", this.EmpName);
            this.CalculateSalary();
        }
    }
}
