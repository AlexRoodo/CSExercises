using System;
using System.Globalization;
using System.Linq;

namespace CSExercises
{
    internal class Exercise1
    {
        public static void Main(string[] args)
        {
            const string errorMsg = "Не был введен аргумент.";
            
            Console.WriteLine("Вариант №5");
            
            Console.WriteLine("\nВведите через запятую без пробела значения Х: ");
            var numList = (Console.ReadLine() ?? throw new ArgumentException(errorMsg))
                .Split(',')
                .Select( d => double.Parse(d, CultureInfo.InvariantCulture));
            
            Console.WriteLine("\nВведите А: ");
            var a = int.Parse(Console.ReadLine() ?? throw new ArgumentException(errorMsg));

            numList.Select(x => {
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