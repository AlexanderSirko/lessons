using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5 };

            System.Console.WriteLine("Test array");

            for (int i = 0; i != (test.Length); i++)
            {
                System.Console.WriteLine(test[i]);
            }



            System.Console.WriteLine("extended array");

            int[] extarr = ExtendByOne(test, 2);

            for (int i = 0; i != (extarr.Length); i++)
            {
                System.Console.WriteLine(extarr[i]);
            }
        }
        static int[] ExtendByOne(int[] array, int value)
        {
            int [] ExtendedArray = new int[array.Length+1] ;
            for (int i = 0; i < array.Length; i++)
            {
                ExtendedArray[i] = array[i];
            }
            ExtendedArray[ExtendedArray.Length-1] = value;
            return ExtendedArray;
        }
    }
}
