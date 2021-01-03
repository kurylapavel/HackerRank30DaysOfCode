using System;

namespace Day29
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int max = 0;
                for (int i = 1; i < n; i++)
                {

                    for (int j = i + 1; j <= n; j++)
                    {
                        int x = i & j;
                        if (x < k && x > max)
                        {
                            max = x;
                        }
                    }

                }

                Console.WriteLine(max);

            }


        }
    }
}
