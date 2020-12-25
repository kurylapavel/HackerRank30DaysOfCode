using System;
using System.Collections.Generic;
using System.Text;

namespace Day19
{
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int result = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
