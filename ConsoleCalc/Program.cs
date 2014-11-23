using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 2.54;
            double operand2 = 0;
            
            System.Console.Write("Enter the sign of arithmetic operation: ");
            var sign = System.Console.ReadLine();
            switch (sign)
            {

                case "+":
                    Console.WriteLine(add(operand1, operand2));
                    break;
                case "-":
                    Console.WriteLine(distract(operand1, operand2));
                    break;
                case "*":
                    Console.WriteLine(multiply(operand1, operand2));
                    break;
                case "/":
                    if (operand2==0)
                        System.Console.Write("Attempt to divide by zero detected. This is not allowed");
                    else 
                    divide(operand1, operand2);
                    break;
            }
        }
        static double add (double a, double b)
        {
            return a + b;
        }
        static double distract(double a, double b)
        {
            return a - b;
        }
        static double multiply(double a, double b)
        {
            return a * b;
        }
        static double divide(double a, double b)
        {
            return a / b;
        }
        

    }
}
