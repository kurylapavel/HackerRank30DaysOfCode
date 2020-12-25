using System;
using System.Linq;

namespace Day20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int swaps = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] > a[i])
                {
                    int toSwap = a[i];
                    a[i] = a[i - 1];
                    a[i - 1] = toSwap;
                    i = 0;
                    swaps++;
                }
            }
            Console.WriteLine($"Array is sorted in {swaps} swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a.Last());
        }
    }
}
