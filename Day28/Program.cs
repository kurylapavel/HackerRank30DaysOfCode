using System;
using System.Collections.Generic;

namespace Day28
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> data = new List<string>();
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                data.Add($"{firstNameEmailID[0]} {firstNameEmailID[1]}");

            }
            data.Sort();
            foreach (var item in data)
            {
                if (item.Contains("@gmail.com"))
                {
                    string[] toWrite = item.Split(' ');
                    Console.WriteLine(toWrite[0]);
                }
            }
        }
    }
}
