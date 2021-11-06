using System;
using static System.Console;

namespace Factory_Method
{
    public class Point
    {
        private readonly double _x;
        private readonly double _y;

        // Factory method
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString() =>
            $" x : {_x} and y : {_y} ";

    }
    class Program
    {
        static void Main()
        {
            var point1 = Point.NewPolarPoint(12.0, Math.PI/2);
            WriteLine(point1.ToString());

            var point2 = Point.NewCartesianPoint(12, 20);
            WriteLine(point2.ToString());
            ReadLine();

        }
    }
}
