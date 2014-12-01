using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the integer number: ");
            int value = int.Parse(System.Console.ReadLine());
            if (isPrime(value))
            {
                System.Console.WriteLine("Value is prime");
            }
            else
            {
                System.Console.WriteLine("Value is not prime");
            }
            if (IsPositive(value))
            {
                System.Console.WriteLine("Value is positive");
            }
            else System.Console.WriteLine("Value is negative");
            IsDivisible(value);

        }
        public static bool isPrime(int number)
        {
            int boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public static bool IsPositive(int x)
        {
            if (x >= 0)
                return true;
            else
                return false;
        }
        public static void IsDivisible(int x)
        {
            if (x%2==0)
            {
                 System.Console.WriteLine("Number is divisible by 2");
            }
            if (x%3==0)
            {
                 System.Console.WriteLine("Number is divisible by 3");
            }
            if (x % 5 == 0)
            {
                System.Console.WriteLine("Number is divisible by 5");
            }
            if (x % 6 == 0)
            {
                System.Console.WriteLine("Number is divisible by 6");
            }
            if (x % 9 == 0)
            {
                System.Console.WriteLine("Number is divisible by 9");
            }
        }
    }
}
