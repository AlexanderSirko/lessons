using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter the integer number between 0 and 100: ");
            int val = ReadInt32(Console.ReadLine());
            if (CheckRange(val, 0, 100))
            {
                if (CheckRange(val,0,14))
                    System.Console.Write("Given number is in [0,14] range ");
                else if (CheckRange(val, 15, 35))
                    System.Console.Write("Given number is in [15,35] range ");
                else if (CheckRange(val, 36, 50))
                    System.Console.Write("Given number is in [36,50] range ");
                else if (CheckRange(val, 51, 100))
                    System.Console.Write("Given number is in [51,100] range ");

            }
            else
                System.Console.Write("Given number is outside of range");            
        }
        public static bool CheckRange(int numberToCheck, int bottom, int top)
        {
            return (numberToCheck >= bottom && numberToCheck <= top);
        }
        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }
    }
}
