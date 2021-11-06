using static System.Console;

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            Product[] products = { apple, tree, house };
            
            // Old filter
            var productFilter = new ProductFilter();
            var greenProducts1 =
                productFilter.FilterByColor(products, Color.Green);

            WriteLine("Green products (old):");
            foreach (var p in greenProducts1)
                WriteLine($" - {p.Name} is green");

            // New filter
            var betterFilter = new BetterFilter();
            var greenSpec = new ColorSpecification(Color.Green);
            var greenProducts2 =
                betterFilter.Filter(products, greenSpec);
            WriteLine("Green products (new):");

            foreach (var p in greenProducts2)
                WriteLine($" - {p.Name} is green");

            WriteLine("Large products");
            var largeSpec = new SizeSpecification(Size.Large);
            var largeProducts =
                betterFilter.Filter(products, largeSpec);

            foreach (var p in largeProducts)
                WriteLine($" - {p.Name} is large");

            WriteLine("Large & blue items");
            var blueSpec= new ColorSpecification(Color.Blue);
            var largeAndBlueSpec = new AndSpecification<Product>(blueSpec, largeSpec);
            var largeAndBlueProducts =
                betterFilter.Filter(products, largeAndBlueSpec);
            foreach (var p in largeAndBlueProducts)
                WriteLine($" - {p.Name} is big and blue");
            
            ReadLine();
        }
    }
}
