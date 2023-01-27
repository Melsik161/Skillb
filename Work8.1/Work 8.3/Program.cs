using System;
using System.Collections.Generic;

namespace Work_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            while (true)
            {
                Console.Write("Введите число которое хотите добавить в библиотеку: ");
                int number = int.Parse(Console.ReadLine());
                if (numbers.Count == 0)
                {
                    numbers.Add(number);
                    AddComplete(number);
                }
                else AddNumber(number);
            }

            void AddNumber(int number)
            {
                bool result = false;

                foreach (var item in numbers)
                {
                    if (item == number)
                    {
                        result = true;
                        break;
                    }
                }

                if (result)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такое число уже есть в бибилиотеке. Невозможно добавить!");
                    Console.ResetColor();
                }
                else
                {
                    numbers.Add(number);
                    AddComplete(number);
                }
            }

            void AddComplete(int number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Число:{number} добавлено.");
                Console.ResetColor();
            }
        }
    }
}


