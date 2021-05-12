using System;

namespace interfaces
{
    //---diferences between interface and abstract class
 
 // abstract class can have implementations while interfaces cant
 //interfaces are public by default while abstract classes are not
 // interface cannot have fields but abstract classes can
 //you can inherit multiple interfaces but you cant inherit multiple abstract classes
    public abstract class studentDetails
    {
        public string StudentName;

        public string studentClass;

        public string tutorName;

        public virtual void studentsdetail()
        {
            Console.WriteLine($"Student name = {StudentName}\nStudent Class {studentClass}");
        }

        public abstract void studentfile();
    }


    public class  firstinputs : studentDetails
    {
        public override void studentfile()
        {
            StudentName = "Andrey Abstract";
            studentClass = "C# Abstract class";
            tutorName = "Mr Elijah";

            Console.WriteLine($"Tutor name : {tutorName}");
        }

        public override void studentsdetail()
        {
            Console.WriteLine($"Student name : {StudentName}\nStudent Class : {studentClass}\nTutor name : {tutorName}");
        }

    }
}