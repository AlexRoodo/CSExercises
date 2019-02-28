using System;
using System.Globalization;
using System.Linq;

namespace CSExercises
{
    internal class Exercise2
    {
        private readonly double _k1, _b1, _x0, _y0;
        private double _k2, _b2, _x1, _y1;
        
        public Exercise2()
        {
            Console.WriteLine("\nЗадание 1Б a).");
            Console.WriteLine("Введите через запятую без пробела k1, x0, y0:");
            var nums = (Console.ReadLine() ?? throw new ArgumentException())
                .Split(',')
                .Select(d => double.Parse(d, CultureInfo.InvariantCulture))
                .ToList();
            
            if (nums.Count != 4)
            {
                _k1 = 1;
                _b1 = 1;
                _x0 = 0;
                _y0 = 2;
            }
            else 
            {
                _k1 = nums[0];
                _b1 = nums[1];
                _x0 = nums[2];
                _y0 = nums[3];
            }
        }
        
        internal void CalcA()
        {
            _k2 = 1 / -_k1;
            _b2 = _x0 / _k1 + _y0;
            
            Console.WriteLine($"Результат A: Y =  {_k2} * X + {_b2}");
        }

        internal void CalcB()
        {
            _x1 = (_b2 - _b1) / (_k1 - _k2);
            _y1 = _k1 * _x1 + _b1;
            
            Console.WriteLine($"Результат Б: X = {_x1}; Y = {_y1}");
        }

        internal void CalcC()
        {
            var y2 = 0;
            var x2 = -_b1 / _k1;
            
            double Segment(double x, double y) => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            var a = Segment(_x0 - _x1, _y0 - _y1);
            var b = Segment(_x1 - x2, _y1 - y2);
            var c = Segment(x2 - _x0, y2 - _y0);

            var p = (a + b + c) / 2;
            var square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Результат С: {square}");
        }

    }
}