using System;
using System.Globalization;
using System.Linq;

namespace CSExercises
{
    internal static class Exercise2
    {
        internal static void CalcA()
        {
            double k1, x0, y0;
            Console.WriteLine("\nЗадание 1Б a).");
            Console.WriteLine("Введите через запятую без пробела k1, x0, y0:");
            var nums = (Console.ReadLine() ?? throw new ArgumentException())
                    .Split(',')
                    .Select(d => double.Parse(d, CultureInfo.InvariantCulture))
                    .ToList();
            if (nums.Count != 3)
            {
                k1 = 1;
                x0 = 0;
                y0 = 2;
            }
            else 
            {
                k1 = nums[0];
                x0 = nums[1];
                y0 = nums[2];
            }

            var k2 = 1 / -k1;
            var b2 = (y0 >= 0 ? " + " : " - ") + y0;
            var x = Math.Abs(x0) < 0.0000001 ? "X" : "( X - " + x0 + ")";
            Console.WriteLine("Результат: Y = " + k2 + " * " + x + b2 );
        }
    }
}