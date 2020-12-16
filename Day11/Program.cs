using System;
using System.Linq;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int[] result = new int[16];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int index = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int g = 0; g < 4; g++)
                {
                    result[index] += arr[j][g];
                    result[index] += arr[j][g + 1];
                    result[index] += arr[j][g + 2];
                    result[index] += arr[j + 1][g + 1];
                    result[index] += arr[j + 2][g];
                    result[index] += arr[j + 2][g + 1];
                    result[index] += arr[j + 2][g + 2];
                    index++;
                }
            }
            int max = result.Max();
            Console.WriteLine(max);
        }
    }
    
}
