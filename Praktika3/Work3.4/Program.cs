using System;

namespace Work3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.Write("Введите длину последовательности: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine($"Осталось попыток: {b - i}");
                Console.Write("Введите число: ");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c < a) a = c;
            }
            Console.WriteLine($"Наименьшее число которое вы указали было: {a}");
            Console.ReadKey();
        }
    }
}
