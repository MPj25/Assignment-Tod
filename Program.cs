using System;

namespace Practice       //Helps to keep name separated for organization
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture_1 lecture_1 = new Lecture_1();
            lecture_1.Person();

            lecture_2.Grade();
        }
    }
    //NON-STATIC
    class Lecture_1{        //a data stuct. combining data var & funct. into a unit
        public string Person()
        {
            string firstName = "Stone";
            string lastName = "Victor";
            int age = 20;
            char gender = 'M';
            string university = "Oxford University Dwey (OUD)";
            string course = "Nurition";
            int level = 300;

            Console.WriteLine($"{firstName} {lastName} is a {age} student in {university}");
            Console.WriteLine($"He is currently in {level} level studying {course}");
            return "";
        }
    }
    
    class lecture_2
    {
        //STATIC
        //A static method can be invoked directly from the class level
        //It does not require any class object
        //Any main() method is shared through the entire class scope, so it always appears with a static keyword.
     public static string Grade()
        {
            string CCD = "CCD: A";
            string ACP = "ACP: A";
            string URP = "URP: B";
            Double GPA = 4.40;
            Console.WriteLine("RESULT");
            Console.WriteLine(CCD);
            Console.WriteLine(ACP);
            Console.WriteLine(URP); 
            Console.WriteLine($"GPA: {GPA}");    
            return "GPA";
        }
    }
}