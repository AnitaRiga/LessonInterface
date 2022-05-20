namespace LessonInterface
{
    public interface IPerson
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        string Subject { get; }

        void SayHello();
        void GiveInfo(string name, string surname, int age);
        void Explain(string subject);  
    }
}
