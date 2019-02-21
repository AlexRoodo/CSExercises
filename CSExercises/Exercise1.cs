using System;
using System.Globalization;
using System.Linq;

namespace CSExercises
{
    internal static class Exercise1
    {
        internal static void CalcFormula()
        {
            const string errorMsg = "Не был введен аргумент.";
            
            Console.WriteLine("\nЗадание 1а.");
            
            Console.WriteLine("Введите через запятую без пробела значения Х: ");
            var nums = (Console.ReadLine() ?? throw new ArgumentException(errorMsg))
                .Split(',')
                .Select(d => double.Parse(d, CultureInfo.InvariantCulture));
            
            Console.WriteLine("Введите А: ");
            var a = int.Parse(Console.ReadLine() ?? throw new ArgumentException(errorMsg));

            Console.WriteLine("Результат:");
            nums.Select(x => {
                    var ax = a * x;
                    var numerator = Math.Pow(a, Math.Pow(x, a)) * Math.Pow(x, Math.Pow(a, ax));
                    var denominator = Math.Pow(a, ax) + Math.Pow(x, ax);
                    return numerator / denominator;
                })
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}