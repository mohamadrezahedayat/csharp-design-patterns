using static System.Console;

namespace Faceted_Builder
{
    class Program
    {
        static void Main()
        {
            var personBuilder = new PersonBuilder();
            Person person = personBuilder
                .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW123AC")
                .Works
                .At("Microsoft")
                .AsA("Software Developer")
                .Earning(5000);
            
            WriteLine(person.ToString());
            
            ReadLine();
        }
    }
}
