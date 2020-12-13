using System;

namespace Day2
{
    class Program
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = (meal_cost / 100) * tip_percent;
            double tax = (meal_cost / 100) * tax_percent;
            double totalCoast = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(totalCoast));
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
