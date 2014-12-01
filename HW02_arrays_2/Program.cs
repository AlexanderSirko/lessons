using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_array_2
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

            

            System.Console.WriteLine("out of bounds subarray");

            int[] subarr=SubArray(test,2,4);

            for (int i = 0; i != (subarr.Length); i++)
            {
                System.Console.WriteLine(subarr[i]);
            }

            int[] reversed = MyReverse(test);

            System.Console.WriteLine("Reversed array");

            for (int i = 0; i != (reversed.Length); i++)
            {
                System.Console.WriteLine(reversed[i]);
            }
        }
        
        static int[] MyReverse(int [] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            return array;
        }
        static int [] SubArray(int [] array, int index, int count)
        {
            int[] arr2 = new int[count];
            
            if ((index + count) > array.Length)
            {
                for (int i = 0; i < array.Length - index; i++)
                    arr2[i] = array[i + index];
                for (int i = array.Length - index; i < arr2.Length; i++)
                    arr2[i] = 1;
                return arr2;
            }
            else
                Array.Copy(array, index, arr2, 0, count);
            return arr2;
        }
        }
}
