using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter the number of clients");
            int a = int.Parse(Console.ReadLine());
            int f = Factorial(a);
            System.Console.WriteLine("Number of possible ways is: " + f);
        }
        static int Factorial(int input)
        {
            int answer = 0;

            if (input > 0)
            {
                int count = 1;
                while (count <= input)
                {
                    if (count == 1)
                    {
                        answer = 1;
                        count++;
                    }
                    else
                    {
                        answer = count * answer;
                        count++;
                    }
                }
            }
            else
            {
                System.Console.Write("Please enter only a positive integer.");
            }

            return answer;
        }
    }
}
