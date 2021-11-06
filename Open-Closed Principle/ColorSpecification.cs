namespace Open_Closed_Principle
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;

        public ColorSpecification(Color color) => _color = color;

        public bool IsSatisfied(Product product) => product.Color == _color;
        
    }
}