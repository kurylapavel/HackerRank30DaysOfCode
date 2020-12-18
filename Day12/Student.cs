using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    class Student : Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
        {
            this.testScores = scores;
        }

        public string Calculate()
        {
            int sum = 0;
            for (int i = 0; i < this.testScores.Length; i++)
            {
                sum += this.testScores[i];
            }
            sum /= this.testScores.Length;
            string result = "";
            if (sum < 40)
            {
                result = "T";
            }
            else if (40 <= sum && sum < 55)
            {
                result = "D";
            }
            else if (55 <= sum && sum < 70)
            {
                result = "P";
            }
            else if (70 <= sum && sum < 80)
            {
                result = "A";
            }
            else if (80 <= sum && sum < 90)
            {
                result = "E";
            }
            else if (90 <= sum && sum <= 100)
            {
                result = "O";
            }
            return result;
        }
    }
}
