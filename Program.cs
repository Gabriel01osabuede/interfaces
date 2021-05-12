using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Animals catObject = new Cats();
            Animals dogObject = new Dogs();
            catObject.cats();
            dogObject.dogs();


           //An INTERFACE in C# is a type definition similar to a class,
           // except that it purely represents 
            //a contract between an object and its user. 
            //It can neither be directly instantiated as an object, nor
            // can data members be defined. 
            //So, an interface is nothing but a collection of method declarations.

            //interface members are public by default
            //Interface does not contain fields
            //A class must implement all the interface member
            //the signatures of the method must be equal to the signature of the interface.

            student Andrey = new student();
            Andrey.doSomeThing();
            Andrey.printFulllName("Andrey");

            studentDetails myObject = new firstinputs();
            myObject.studentfile();
            myObject.studentsdetail();
        
        }
    }
    
        interface IStudent
        {
            void printFulllName(string name);
            void doSomeThing();
        }

        public class student : IStudent
        {
            public void printFulllName(string name)
            {
                Console.WriteLine("My full name " + name);
            }

            public void doSomeThing()
            {
                 Console.WriteLine("Do something My full name ");
            }

        }
}
