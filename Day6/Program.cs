using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = Convert.ToInt32(Console.ReadLine());
            string word = "";
            for (int i = 0; i < wordsCount; i++)
            {
                word += Console.ReadLine();
                word += "^";
            }
            Solution solution = new Solution(word);
            solution.Print();
        }
    }
}
