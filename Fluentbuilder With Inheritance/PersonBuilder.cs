namespace DesignPatterns
{
    public abstract class PersonBuilder 
    {
        protected Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }
}