﻿using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10 + 1; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }

        }
    }
}
