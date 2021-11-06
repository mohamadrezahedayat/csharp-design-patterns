﻿namespace Open_Closed_Principle
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;

        public SizeSpecification(Size size) => _size = size;

        public bool IsSatisfied(Product p) => p.Size == _size;
        
    }
}