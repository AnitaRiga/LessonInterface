using System;

namespace LessonInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPerson t1 = new Teacher();
            ISalary professorSalary = new Teacher();
            IPerson s1 = new Student();
            IPerson s2 = new Student();

            t1.SayHello();
            t1.GiveInfo("Alex", "White", 54);
            t1.Explain("Biology");
            Console.WriteLine($"Professor`s annual salary is {professorSalary.GetAnnualSalary(3000)} euro."); 

            Console.WriteLine();

            s1.SayHello();
            s1.GiveInfo("Anna", "Yellow", 21);
            s1.Explain("Medicy");

            Console.WriteLine();

            s2.SayHello();
            s2.GiveInfo("Tom", "Red", 19);
            s2.Explain("Psychology");
        }
    }
}

