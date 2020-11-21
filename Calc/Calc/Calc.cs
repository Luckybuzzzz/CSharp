using System;

namespace Calc
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие: ");
            String act = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            float y = float.Parse(Console.ReadLine());

            switch (act)
            {
                case "+":
                    float sum = x + y;
                    Console.WriteLine("Результат: {0}", sum);
                    break;
                case "-":
                    float subt = x - y;
                    Console.WriteLine("Результат: {0}", subt);
                    break;
                case "*":
                    float mult = x * y;
                    Console.WriteLine("Результат: {0}", mult);
                    break;
                case "/":
                    float div = x / y;
                    Console.WriteLine("Результат: {0}", div);
                    break;
            }
        }       
    }
}
