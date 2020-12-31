using System;

namespace Day25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool isPrime = false;
            for (int i = 0; i < n; i++)
            {

                if (myArray[i] > 2)
                {
                    isPrime = false;
                    int range = Convert.ToInt32(Math.Sqrt(myArray[i]));

                    for (int j = 2; j < range+1; j++)
                    {
                        if (myArray[i] % j == 0)
                        {
                            isPrime = true;
                            break;
                        }
                    }

                }
                else if (myArray[i] == 1)
                {
                    isPrime = true;
                }
                if (isPrime)
                {
                    Console.WriteLine("Not prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }

            }
        }
    }
}
