using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter the integer number to check if it is even: ");
            int val = ReadInt32(Console.ReadLine());
            if (IsEven1(val))
            {
                System.Console.Write("First method says that integer is even. Double checking with another method... ");
                string binary = Convert.ToString(val, 2);
                char last = binary[binary.Length - 1];
                if (last == '0')
                {
                    System.Console.Write("Another method confirms that integer is even ");
                }
            }
            else
                System.Console.Write("First method says that integer is not even. Double checking with another method... ");
            string binary1 = Convert.ToString(val, 2);
            char last1 = binary1[binary1.Length - 1];
            if (last1 == '1')
            {
                System.Console.Write("Another method confirms that integer is not even ");
            }
        }
        public static bool IsEven1(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
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
