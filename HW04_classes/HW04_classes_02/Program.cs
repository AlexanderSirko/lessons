using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW04_classes_02
{
    
        
    

    public class CalculatePerimetre
    {
        private class Point
        {
            private double x, y;
            private string name;
        

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
            public double X
            {
                get
                {
                    return this.x;
                }
                set
                {
                    try
                    {
                        this.x = value;
                    }
                    catch (InvalidCastException)
                    {
                        Console.Error.WriteLine("Invalid argument value of `X'");
                    }
                   
                }
            }
            public double Y
            {
                get
                {
                    return this.y;
                }
                set
                {
                    try
                    {
                        this.y = value;
                    }
                    catch (InvalidCastException)
                    {
                        Console.Error.WriteLine("Invalid argument value of `Y'");
                    }
                }
            }
        }
        private class Figure
        {
            private Point[] points;

            public Figure(Point a, Point b, Point c)
            {
                points= new Point[3]{a,b,c};
            }
            public Figure(Point a, Point b, Point c, Point d)
            {
                points = new Point[4] { a, b, c, d};
            }
            public Figure(Point a, Point b, Point c, Point d, Point e)
            {
                points = new Point[5] { a, b, c ,d, e};
            }

            public double GetPerimetre()
            {
                double result = 0;
                points.Initialize();
                for (int i = 0; i < points.Length - 1; i++)
                {
                    result += LengthSide(points[i], points[i + 1]);
                }
                return result;
            }
            public double LengthSide(Point point, Point point2)
            {
                return Math.Sqrt((point2.X - point.X) * (point2.X - point.X) + (point2.Y - point.Y) * (point2.Y - point.Y));
            }
}
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter {0} points (described with their coordiantes (x and y) :", n);
            string[] values;
            List<Point> points = new List<Point>(); // нету динамических массивов (
            for (int i = 0; i < n; i++)
            {
                values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                points.Add(new Point(double.Parse(values[0]), double.Parse(values[1])));
            }
            Figure poly = new Figure(points[0],points[1],points[2]);
            Console.WriteLine("\nperimetre = {0:f2}", poly.GetPerimetre());
        }
    }
}
