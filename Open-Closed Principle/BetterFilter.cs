using System.Collections.Generic;
using System.Linq;

namespace Open_Closed_Principle
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec) =>
            items.Where(spec.IsSatisfied);
       
    }
}