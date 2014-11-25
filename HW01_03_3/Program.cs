using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01_03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the salary of the employee: ");
            int salary = ReadInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the employment time in years: ");
            int time = ReadInt32(Console.ReadLine());
            double bonus = BonusCalculator(salary, time);
            System.Console.WriteLine("Bonus is: " + bonus);
        }
        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }
        public static double BonusCalculator (int salary, int time)
        {
            if (time<5)
            {
                return salary * 0.1;
            }
            else if (time >=5 && time <10)
            {
                return salary * 0.15;
            }
            else if (time >= 10 && time < 15)
            {
                return salary * 0.25;
            }
            else if (time >= 15 && time < 20)
            {
                return salary * 0.35;
            }
            else if (time >= 20 && time < 25)
            {
                return salary * 0.45;
            }
            else if (time >= 25)
            {
                return salary * 0.5;
            }
            return -1;  
        }
    }
}
