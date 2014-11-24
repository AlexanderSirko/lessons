using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        static int x = 5, y = 10, z = 15;
        static public int res1 = x+=y>>x++*z;
        static public int res2 = z = ++x & y * 5;
        static public int res3 = y /= x + 5 | z;
        static public int res4 = z = x++ & y * 5;
        static public int res5 = x = y << x++ ^ z;

        static void Main(string[] args)
        {
            System.Console.WriteLine("x += y >> x++ * z");
            System.Console.WriteLine(res1);
            System.Console.WriteLine("z = ++x & y * 5");
            System.Console.WriteLine(res2);
            System.Console.WriteLine("y /= x + 5 | z");
            System.Console.WriteLine(res3);
            System.Console.WriteLine("z = x++ & y * 5");
            System.Console.WriteLine(res4);
            System.Console.WriteLine("x = y << x++ ^ z");
            System.Console.WriteLine(res5);
        }
    }
}
