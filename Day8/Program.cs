using System;
using System.Collections.Generic;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] toSplit = Console.ReadLine().Split(' ');
                phoneBook.Add(toSplit[0], int.Parse(toSplit[1]));
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name}={phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
