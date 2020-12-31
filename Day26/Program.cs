using System;

namespace Day26
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] returnDate = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] dueDate = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));


            int result = Calculate(returnDate[0], returnDate[1], returnDate[2], dueDate[0], dueDate[1], dueDate[2]);

            Console.WriteLine(result);


        }

        static int Calculate(int returnD, int returnM, int returnY, int dueD, int dueM, int dueY)
        {
            if (returnD > dueD && (returnM == dueM && returnY == dueY))
            {
                int difference = returnD - dueD;
                return 15 * difference;
            }
            else if (returnM > dueM && returnY == dueY)
            {
                int difference = returnM - dueM;
                return 500 * difference;
            }
            else if (returnY > dueY)
            {
                return 10000;
            }
            else
            {
                return 0;
            }
        }
    }
}
