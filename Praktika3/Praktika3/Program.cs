using System;

namespace Praktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse (Console.ReadLine());
            switch (number % 2 == 0)
            {
                case true: Console.WriteLine("Число {0} четное!", number);  break;
                default: Console.WriteLine("Число {0} нечетное!", number);
                    break;
            }
            Console.Read();
        }
    }
}
