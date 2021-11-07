using System;
using System.Threading.Tasks;

namespace Asynchronous_Factory_Method
{
    public class Foo
    {
        private Foo() { /* constructor is private */}

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
    class Program
    {
        static async Task Main()
        {
            Foo x = await Foo.CreateAsync();
            Console.ReadLine();
        }
    }
}
