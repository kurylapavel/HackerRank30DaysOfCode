﻿using System;
using System.IO;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int factorial(int n)
        {
            int result = 1;
            if (n <= 1 && n >= 0)
            {
                return result;
            }
            for (int i = 2; i < n + 1; i++)
            {
                result *= i;
            }
            return result;
        }



    }
}
