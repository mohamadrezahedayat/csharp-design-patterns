﻿namespace Liskov_Substitution_Principle
{
    public class Rectangle
    {
        //public int Width { get; set; }
        //public int Height { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(){}

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString() 
            => $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}