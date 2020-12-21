using System;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string S = Console.ReadLine();
                int i = 0;
                try
                {
                    i = Convert.ToInt32(S);
                    Console.WriteLine(S);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bad String");
                }
            }
        }
    }
}
