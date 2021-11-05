namespace Functional_Builder
{
    public class Person
    {
        public string Name, Position;
        public override string ToString()
        {
            return $"{Name} works as a {Position}";
        }
    }
}