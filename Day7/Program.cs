using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (int i = n; i > 0; i--)
            {
                Console.Write($"{arr[i - 1]} ");
            }
        }
    }
}
