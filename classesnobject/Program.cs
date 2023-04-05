using classesnobject.Abstarction;
using classesnobject.Anonymous;
using classesnobject.DelegateClass;
using classesnobject.Encapsulations;
using classesnobject.Indexer;
using classesnobject.Inheritance;
using classesnobject.Inheritance.MultipleInheritance;
using classesnobject.Inheritance.SingleInheritance;
using classesnobject.Interface;
using classesnobject.Interface.InterfaceInheritance;
using classesnobject.Polymorphism.DynamicPolymorphism;
using classesnobject.Polymorphism.DynamicPolymorphism.MethodOverriding;
using classesnobject.Polymorphism.StaticPolymorphism;
using classesnobject.Sealed;
using classesnobject.Generics;

using System;
using classesnobject.ClassNObject1;

namespace classesnobject
{
    public class Program
    {
   
        static void Main(string[] args)
        {
            #region ClassnObject
            Student student = new Student();
          //student.set(23);
         // Console.WriteLine(student.get());
           
            student.setAll(23, "ankita", "Dhavan", "Latur");
            student.getAll();

            Student ram = new Student();
            ram.setAll(23,"rama","rajan","Nanded");
            ram.getAll();

           // Console.WriteLine("enter the id");
          //int id= int.Parse( Console.ReadLine());

            
            //Console.WriteLine("enter the firstname");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("enter the LastName");
            //string LastName = Console.ReadLine();

            //Console.WriteLine("enter the City");
            //string City = Console.ReadLine();

          //  student.setAll(id, firstName, LastName, City);
            //student.getAll();

            #endregion

            #region Constructor
          //  Constructor constructordefault=new Constructor();
            Constructor constructorparamterized = new Constructor(12, "an", "Dn");
            Constructor.staticConstructorMethod();

            Constructor copyconstructor = new Constructor(56, "ram");
            copyconstructor.copyConstructorGetMethod();
            Constructor copyconstructor1 = new Constructor(copyconstructor);
            copyconstructor1.copyConstructorGetMethod();

            //private constructor
            Constructor.a = 56;
            Console.WriteLine( Constructor.privateConstructorMethod());

            #endregion

            #region StaticClass
            StaticClass.getStaticClassMathod();
            StaticClass.getdiscount();
            #endregion

            #region Inheritance
            DChildren inheritancehieracical = new DChildren();
            Console.WriteLine( inheritancehieracical.FirstName = "Ankita");
            Console.WriteLine(inheritancehieracical.ChildLastName = "Dhavan");
            inheritancehieracical.printFullName();
            DChildren cinhertancehirerachical = new DChildren();
            Console.WriteLine( cinhertancehirerachical.ChildName = "Ankit");
            cinhertancehirerachical.LastName = "Dhavan";

            //single inheritance
            Derived derivedinheritance = new Derived();
            Console.WriteLine(derivedinheritance.Dlastname = "derivedname");
            Derived.fullname();

            //multiple inheritance 
            MDerived mderivedinheritance = new MDerived();
            Console.WriteLine(  mderivedinheritance.emploeeName="Ankita");
            Console.WriteLine (mderivedinheritance.employee1Age = 12);
            Console.WriteLine( mderivedinheritance.employee2Salary2 = "fifty");

            #endregion

            #region encapsulation
            //auto impleted public 
            Encap encapmethod = new Encap(56,"Ankita","dhavan");
            Console.WriteLine(encapmethod.Id = 23);
            Console.WriteLine(encapmethod.Name = "Nikita");
           // encapmethod.lsName="rane"-----inaccessible due to private

            //private asel tr fakt tyach method kiva property tyach class madhe iniliza zale pahijet:

            encapmethod.setage(67);
            encapmethod.getage();
            encapmethod.setfname("");
            encapmethod.getfanme();
           
            //setter and getter:
            encapmethod.setpropint=12;
            Console.WriteLine(encapmethod.setpropint);

            encapmethod.getstudentprop = "";
            Console.WriteLine(encapmethod.getstudentprop);
            //static properties:--cl with class name:
            Encap._UniversityName = "ramanand teerth nanded university";
            Console.WriteLine(Encap._UniversityName);
            Encap._UniversitySubject = "IT";
            Console.WriteLine(Encap._UniversitySubject);
            #endregion

            #region Polymorphism
            MethodOverloading methodOverLoading = new MethodOverloading();
            methodOverLoading.Add(1,3);
            methodOverLoading.Add(2, 4, 6);
           //oprator overloading----not done
            OperatorOverloading obj1 = new OperatorOverloading();
            obj1.name = "ankita";
            obj1.id =51;

            OperatorOverloading obj2 = new OperatorOverloading();
            obj1.name = "dhavan";
            obj1.id = 09;

            OperatorOverloading obj3 = new OperatorOverloading();
            obj3 = obj1 + obj2 ;
            Console.WriteLine(obj3.id);
            Console.WriteLine(obj3.name);



            //method hiding 
           //if we want parent method then add in child class base.parentclass method .
           //and add new keyword in it ;
           //anthor way-we want parent then go first parent class name=new child class()
           // we want child class then create object of child class:

           MethodHiding mHChild = new MHChild();
            mHChild.show();

            //Method overriding

           //methodovrride is used for child class method implememtation
           //in base class we use virtual keyword and derived class we use override 
           //if we want parent use base.parent class()to acheive parent method
           //CClass1
           BaseClass cClass = new CClass1();
            cClass.Add();
            
           //sealed class
           //give a error to  be not override
           //used to keep it private method and no inherited as child class and also not being parent class:
           SealedDerived sealedDerived =new SealedDerived();
            sealedDerived.Run();


            #endregion

            #region Indexer
            Indexerclass indexer = new Indexerclass();
            indexer[0] =9;
           Console.WriteLine(indexer[0]);
            #endregion

            #region Delegates

            Calculator calculator = new Calculator(Delegates.Addition);
            calculator.Invoke(23, 45);
            Calculator calculator1 = new Calculator(Delegates.Substritution);
            calculator1(12,5);
            Calculator calculator2 = new Calculator(Delegates.Multiplication);
            calculator2(23, 45);

            //singlecast delegates
            Addition addition = new Addition(SingleCastDelegates.Addition);
            addition(12, 4);
            //multiple delegates
            Show show = new Show(MultipleDelegates.Show);
            show.Invoke();
            Calender calender = new Calender(MultipleDelegates.Addition);
            calender.Invoke(12, 34, 56);
            Fun fun = new Fun(MultipleDelegates.Fun);
            fun.Invoke(12, 5);

            //multicast delegates

            //we object name+= a
            MultiCast multiCast = new MultiCast(MultiCastDelegates.Square);
            multiCast(12);


            #endregion

            #region Anonymous 
           // MyDelegate myDelegate = new MyDelegate (AnonymousFunction.Addition);
            //myDelegate.Invoke(12);


            //anonmyous
            //we used anonmyous function  used with delegates and delegate keyword:
            //just a body not a name is anonmyous function 
            //no access specifier no static and static method  is used and used for less coding
            //
            MyDelegate myDelegate1 = delegate (int a)
            {
                a += 10;
                Console.WriteLine("this is anonymous function{0}",a);
            };
            myDelegate1.Invoke(12);


            //paramter anonymous function

            ParameterAnonymous.Increment(delegate (int b) { b += 10; Console.WriteLine(b); },5);





            // lambda expression
            //work with anonmyous function 
            //there are two type input={statement}--multiple line
            //input=expression--one line code --explicitly return 
            MyDelegate statementlambada =  (a)=>
            {
                a += 10;
                Console.WriteLine("this is statement  in lambda expression{0}", a);
            };
            statementlambada.Invoke(5 );

            MyDelegate1 expressionlambda  = (a) => a * a;
            //   Console.WriteLine("this is expression in lambada expression{0}");
            Console.WriteLine(expressionlambda.Invoke(7));



            #endregion

            #region Abstraction
            Abstraction abstarction = new Abstraction(12, "ankita", 400000);
            abstarction.TotalSalary();

            //abstarction class
            AbstractStudent abstractStudent = new AbstractStudent();
            abstractStudent.id = 45;
            abstractStudent.LastName = "dhavan";
            abstractStudent.firstName = "Ankita";
            abstractStudent.studentLastName = "Dghfj";
            abstractStudent.studentName = "hkhjhjh";
            abstractStudent.PrintFull();

            #endregion

            #region Interface

            InterfaceClass interfaceClass = new InterfaceClass();
            interfaceClass.Get();

            InInheritanceCls inInheritanceCls = new InInheritanceCls();
            inInheritanceCls.show();
            inInheritanceCls.show2();
            inInheritanceCls.show3();

            //all method access
           Interface3 interface3 = new InInheritanceCls();
            interface3.show2();

            Interface2 interface2 = new InInheritanceCls();
            interface2.show2();

            Interface1 interface1 = new InInheritanceCls();
            interface1.show();

            #endregion

            #region Generics
            //int[] numbers = new int[3];
            //numbers[0] = 67;
            //numbers[1] = 90;
            //numbers[2] = 1;

            //string[] start = { "ankita", "dhavan", "latur", "pune" };

            //Generic.Check(numbers);
            //Generic.Check(start);


            //int[] home = { 12, 23, 45, 23, 56, 5 };
            //Generic.Check(home);

            //string[]arr= { "ankita", "dhavan", "latur", "pune" };
            //Generic.Check(arr);
            #endregion


            #region Classes n object1 
            ObjectClass objectClass = new ObjectClass();
            objectClass.set(12);
            Console.WriteLine(objectClass.get());


            objectClass.setAll("ankita", "Dhavan", "Latur");
            objectClass.GetAll();
            #endregion



            Console.ReadKey();
            






        }

        
    }
}
