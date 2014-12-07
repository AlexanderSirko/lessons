using System;

namespace HW04_classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter the side 1 of rectangle: ");
            var side1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the side 2 of rectangle: ");
            var side2 = double.Parse(Console.ReadLine());
            var r1 = new Rectangle(side1, side2);
            Console.WriteLine("Area is " + r1.AreaCalculator());
            Console.WriteLine("Perimeter is " + r1.PerimeterCalculator());
        }
    }

    internal class Rectangle
    {
        public double side1, side2;

        public Rectangle(double a, double b)
        {
            side1 = a;
            side2 = b;
        }

        public double AreaCalculator()
        {
            return side1*side2;
        }

        public double PerimeterCalculator()
        {
            return (side1 + side2)*2;
        }
    }
}