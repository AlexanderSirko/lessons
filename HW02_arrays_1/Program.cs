using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            System.Console.WriteLine("Please enter the length of array: ");
            int a = int.Parse(Console.ReadLine());
            int[] customArray = new int[a];
            for (int i = 0; i != (customArray.Length); i++)
            {
                customArray[i] = rnd.Next(-100,100);
            }
            
            //find max and min value

            int minint = customArray[0];
            int maxint = customArray[0];
            int sum = 0;
            foreach (int value in customArray) //calculating max, min and sum (for avg) in the single loop
            {
                if (value < minint) minint = value;
                if (value > maxint) maxint = value;
                sum += value;
            }
            
            System.Console.WriteLine("The maximum value of array is: " + maxint);
            System.Console.WriteLine("The minimum value of array is: " + minint);
            System.Console.WriteLine("The average value of array is: " + sum / customArray.Length);
            for (int i = 0; i != (customArray.Length); i++)
            {
                if (!IsEven(customArray[i]))
                {
                    System.Console.WriteLine(customArray[i]);
                }
                
            }
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
