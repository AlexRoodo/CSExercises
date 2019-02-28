using System;

namespace CSExercises
{
    public class Exercise3
    {
        public Exercise3()
        {
            Console.WriteLine("Введите первоначальную стоимость вклада в долларах:");
            var deposit = 
                decimal.Parse(Console.ReadLine() ?? throw new ArgumentException("Не введена сумма"));
            if (deposit < 5000) throw new ArgumentException("Сумма должна быть не меньше 5000 долларов");
            
            
        }
    }
}