using System;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            string binary = "";

            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    binary += "0";
                }
                else
                {
                    binary += "1";
                }
                n /= 2;
            }

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    int x = i;
                    int y = 0;
                    while (x < binary.Length && binary[x] != '0')
                    {
                        x++;
                        y++;
                    }
                    i = x;
                    if (result < y)
                    {
                        result = y;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
