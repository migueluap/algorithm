using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, -4, 8, 11, 1, -1, 6 };
            //int[] arr = { 2, -7, 4, 8, -11 };

            var arrayResult = twoNumberSum(arr, 10);

            foreach (var item in arrayResult)
                Console.WriteLine(item);

            Console.WriteLine();
        }

        public static int[] twoNumberSum(int[] array, int targetSum)
        {
            if (array.Length == 0)
                Console.WriteLine("The array doesn't have values. Please insert a array with values");

            List<int> output = new List<int>();

            for ( int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] + array[j] == targetSum)
                    {
                        output.Add(array[i]);
                        output.Add(array[j]);
                    }

            int[] arrayShorted = output.ToArray();
            Array.Sort(arrayShorted);
            
            return arrayShorted;
        }
    }
}
