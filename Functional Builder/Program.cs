using static System.Console;

namespace Functional_Builder
{
    class Program
    {
        static void Main()
        {
            var person = new PersonBuilder()
                .Called("Mohammad")
                .WorksAs("Developer")
                .Build();
            WriteLine(person.ToString());
            
            ReadLine();

        }
    }
}
