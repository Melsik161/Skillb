using System;

namespace Work3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Приветствую тебя в игре 21. Введите количество карт на руке: ");
            var kard = Convert.ToSByte(Console.ReadLine());
            int summa = 0;
            for (sbyte i = 0; i < kard; i++)
            {
                Console.Write($"Введите номинал {i + 1}-й карты: ");
                string nominal = Console.ReadLine();
                if (nominal =="J" || nominal=="Валет" || nominal=="Q" || nominal=="Дама" || nominal=="K" || nominal=="Король" || nominal=="T" || nominal=="Туз")

                {
                    summa += 10;
                }
                else
                {
                    summa += Convert.ToInt32(nominal);
                }

            }
            Console.WriteLine("Общий вес карт: {0}", summa);
            Console.ReadKey();
        }
    }
}
