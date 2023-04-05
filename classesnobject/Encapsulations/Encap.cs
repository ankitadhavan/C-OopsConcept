using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesnobject.Encapsulations
{
    public class Encap
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public string lsName { get; private set; }

        //static property
        private  static string UniversitySubject;
        private static string UniversityName;

        public static string _UniversitySubject
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please proper string");
                }
                else
                {

                    UniversitySubject = value;
                }
            }
            get
            {
                return UniversitySubject;
            }

        }
        public static string _UniversityName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please proper string");
                }
                else
                {


                    UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }

        }



        // properties get and set:
        public int roll;
        public string studentName;

        //methodss

        public int age;
        public string fname;



        //for properties:

        public Encap(int id,string name,string ls)
        {
            this.Id = id;
            this.Name = name;
            this.lsName = ls;
        }
        public void setage(int age)
        {
            if (age <= 0)
            {
                Console.WriteLine("please provide ur age ");
            }
            else
            {
                this.age = age;
            }

        }
        public void getage()
        {
            if (age <= 0)
            {

            }
            else
            {
                Console.WriteLine(this.age);
            }
        }
        public void setfname(string fname)
        {
            if (string.IsNullOrEmpty(fname))
            {
                Console.WriteLine("please provide ur proper name");

            }
            else
            {
                this.fname = fname;
            }

        }
        public void getfanme()
        {
            if (string.IsNullOrEmpty(fname))
            {

            }
            else
            {

                Console.WriteLine(this.fname);
            }

        }

        //properties:
        public int setpropint
        {
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("this is not proper input");
                }
                else
                {
                    this.roll = value;
                }
            }
            get
            {
                return this.roll;
            }
        }
        public string getstudentprop
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("plx provide proper input");
                }
                else
                {


                    this.studentName = value;
                }
            }
            get
            {

              
                return this.studentName;
            }


            //static properties;



            

        }

    }
}
