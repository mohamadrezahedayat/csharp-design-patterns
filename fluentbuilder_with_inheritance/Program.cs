using static System.Console;

namespace DesignPatterns
{
    public class Program
    {
        static void Main()
        {
            var person = Person.New
                .Called("John")
                .WorksAsA("Programmer")
                .Build();

            WriteLine(person.ToString());
            ReadLine();
        }
    }
}
