using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_loops_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter A: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter B, greater than A: ");
            int b = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i=a+1; i<b; i++)
            {
                sum = sum + i;
                if (!IsEven(i))
                    System.Console.WriteLine(i);

            }
            System.Console.WriteLine("sum of numbers between given ones is: "+sum);

        }
        public static bool IsEven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
