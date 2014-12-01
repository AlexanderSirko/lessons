using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the first operand: ");
            double operand1 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the second operand: ");
            double operand2 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the sign of arithmetic operation: ");
            var sign = System.Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(add(operand1, operand2));
                    break;
                case "-":
                    Console.WriteLine(sub(operand1, operand2));
                    break;
                case "*":
                    Console.WriteLine(Mul(operand1, operand2));
                    break;
                case "/":
                       div(operand1, operand2);
                    break;
            }
        }
        static double add(double a, double b)
        {
            return a + b;
        }
        static double sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double div(double a, double b)
        {
            if (b==0)
            {
               System.Console.Write("Attempt to div by zero detected. This is not allowed");
                return -1;
            }
            else return a / b;
        }


    }
}