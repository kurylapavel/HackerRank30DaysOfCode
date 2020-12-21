using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day14
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] el)
        {
            this.elements = el;
        }
        public void computeDifference()
        {
            int max = this.elements.Max();
            int min = this.elements.Min();

            this.maximumDifference = max - min;

        }
    }
}
