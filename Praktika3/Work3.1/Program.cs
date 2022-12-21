using System;

namespace Work3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Приветствую тебя в игре 21. Введите количество карт на руке: ");
            sbyte kard = Convert.ToSByte(Console.ReadLine());
            int summa = 0;
            for (sbyte i = 0; i < kard; i++)
            {
                Console.Write($"Введите номинал {i + 1}-й карты: ");
                string nominal = Console.ReadLine();
                switch (nominal)
                {
                    case "J": summa += 10; break;
                    case "Q": summa += 10; break;
                    case "K": summa += 10; break;
                    case "T": summa += 10; break;
                    default: summa += Convert.ToInt32(nominal); break;
                }

            }
            Console.WriteLine("Общий вес карт: {0}", summa);
            Console.ReadKey();
        }
    }
}
