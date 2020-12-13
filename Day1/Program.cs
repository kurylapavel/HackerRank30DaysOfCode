using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =4;
            double d =4.0;
            string s = "HackerRank "

            int ii;
            double dd;
            string ss;
            ii = Convert.ToInt32(Console.ReadLine());
            dd = Convert.ToDouble(Console.ReadLine());
            ss = Console.ReadLine();
            Console.WriteLine(i + ii);
            Console.WriteLine("{0:F1}", d + dd);
            Console.WriteLine(s + ss);

        }
    }
}
