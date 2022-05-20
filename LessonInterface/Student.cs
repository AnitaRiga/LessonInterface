using System;

namespace LessonInterface
{
    public class Student : IPerson
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public string Subject { get; private set; }

        public void Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, Professor!");
        }

        public void GiveInfo(string name, string surname, int age)
        {
            Console.WriteLine($"My name is {name} {surname}. I`m {age} old.");
        }

        public void Explain(string Subject)
        {
            Console.WriteLine($"I am studying {Subject}.");
        }
    }
}
