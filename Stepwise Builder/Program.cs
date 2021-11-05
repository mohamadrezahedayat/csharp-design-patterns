using static System.Console;

namespace Stepwise_Builder
{
    class Program
    {
        static void Main()
        {
            var car = CarBuilder.Create()
                .OfType(CarType.Crossover)
                .WithWheels(18)
                .Build();
            WriteLine(car.ToString());

           
            ReadLine();
        }
    }
}
