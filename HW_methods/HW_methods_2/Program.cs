using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the amount of currency 1: ");
            double a = double.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the exchange rate: ");
            double b = double.Parse(System.Console.ReadLine());

            System.Console.Write("Amount of currency 2 is : "+Exchange(a,b));
        }
        static double Exchange(double amount, double rate)
        {
            return amount * rate;
        }
        
        }
}
