using System;

namespace ArrayOfRandomNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            ArrayValues.FillArray(numbers);
            Console.WriteLine("values of array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine("\nvalues of new array with negative numbers:");
            int[] newnumbers = ArrayValues.FindNegativeNumbers(numbers);
            for (int i = 0; i < newnumbers.Length; i++)
            {
                Console.Write(newnumbers[i]);
            }
            Console.WriteLine("\nsorted array:");
            ArrayValues.SortArray(newnumbers);
            for (int i = 0; i < newnumbers.Length; i++)
            {
                Console.Write(newnumbers[i]);
            }
        }
    }
}
