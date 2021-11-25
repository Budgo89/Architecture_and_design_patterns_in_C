using System;

namespace DZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("Пажалуйста введите число: ");

            string text = Console.ReadLine();

            if (text == "q")
            {
                return;
            }
            int value = Int32.Parse(text);
            int factorial = 1; int sum = 0;
            int max = 0;
            for (int i = 1; i <= value; i++)
            {
                factorial = factorial * i;
                sum = sum + i;
                if (i % 2 == 0)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Факториал равен {factorial}"); 
            Console.WriteLine($"Сумма от 1 до N равна {sum}");

            Console.WriteLine($"Максимальное четное число меньше N равно {max}");
            Console.ReadLine();
        }
    }
}
