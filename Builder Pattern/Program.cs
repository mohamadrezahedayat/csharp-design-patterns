using static System.Console;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            var builder = new HtmlBuilder("ul");
            builder
                .AddChild("li","hello")
                .AddChild("li", "world");

            WriteLine(builder.ToString());
            ReadLine();
        }
    }
}
