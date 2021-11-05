namespace Faceted_Builder
{
    public class PersonBuilder // facade
    {
        // reference!
        protected Person Person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(Person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.Person;
        }
    }
}