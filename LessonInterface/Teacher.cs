using System;

namespace LessonInterface
{
    public class Teacher : IPerson, ISalary
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Subject { get; set; }

        public void Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, students!");
        }

        public void GiveInfo(string name, string surname, int age)
        {
            Console.WriteLine($"My name is {name} {surname}. I`m {age} old.");
        }

        public void Explain(string subject)
        {
            Console.WriteLine($"I am explaining {subject}.");
        }

        public int GetAnnualSalary(int annualSalary)
        {
            return annualSalary * 12;            
        }
    }
}
