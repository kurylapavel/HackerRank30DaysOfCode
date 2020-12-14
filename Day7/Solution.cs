using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Solution
    {
        public string word;
        public Solution(string word)
        {
            this.word = word;
        }
        public void Print()
        {
            string[] toSplit = this.word.Split('^');
            for (int i = 0; i < toSplit.Length; i++)
            {
                string resultOne = "";
                string resultTwo = "";

                for (int j = 0; j < toSplit[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        resultOne += toSplit[i][j];
                    }
                    else
                    {
                        resultTwo += toSplit[i][j];
                    }
                }
                Console.WriteLine($"{resultOne} {resultTwo}");
            }
        }
    }
}
