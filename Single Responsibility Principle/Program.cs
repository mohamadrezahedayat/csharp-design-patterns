using System.Diagnostics;
using static System.Console;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main()
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            WriteLine(j.ToString());

            var p = new Persistence();
            const string fileName = @"../../journal.txt";
            p.SaveToFile(j,fileName,true);
            Process.Start(fileName);

        }
    }
}
