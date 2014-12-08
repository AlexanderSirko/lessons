using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_classes_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure Triangle = new Figure(Point);
        }
    }
    class Point
    {
        private readonly int x;
        private readonly int y;
        private readonly string name;


        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public String Name
        {
            get { return name; }
        }
        
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    class Figure
    {
        public double Perimeter = 0;

        public Figure(Point a, Point b, Point c)
        {
            Console.WriteLine("Triange perimeter is: ");
            PerimeterCalculator(a,b,c);
        }

        public Figure(Point a, Point b, Point c, Point d)
        {

        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {

        }

        double LengthSide(Point A, Point B)
        {
            return (Math.Sqrt((B.X - A.X) ^ 2 + (B.Y - A.Y) ^ 2));
        }

        void PerimeterCalculator(Point A, Point B, Point C)
        {
            Perimeter = LengthSide(A,B)+LengthSide(B,C)+LengthSide(A,C);
            Console.WriteLine(Perimeter);
        }
        void PerimeterCalculator(Point A, Point B, Point C, Point D)
        {
            Perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D)+LengthSide(A,D);
        }
        void PerimeterCalculator(Point A, Point B, Point C, Point D, Point E)
        {
            Perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E)+LengthSide(A,E);
        }
    }
}
