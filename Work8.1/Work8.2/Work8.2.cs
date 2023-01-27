using System;
using System.Collections.Generic;

namespace Work8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> contackBook = new Dictionary<long, string>();
            while (true)
            {
                Console.WriteLine("Нажмите '1' если хотите добавить новый контакт!");
                Console.WriteLine("Нажмите '2' если хотите найти контакт!");
                char Key = Console.ReadKey(true).KeyChar;
                switch (Key)
                {
                    case '1':
                        Console.Write("Введите номер: ");
                        long number = long.Parse(Console.ReadLine());
                        Console.Write("Введите Имя контакта:");
                        string name = Console.ReadLine();
                        if (name != string.Empty) AddContackt(number, name);
                        else Console.WriteLine("Вы ввели неверные значения! Попробуйте еще раз!");
                        break;
                    case '2':
                        Console.Write("Введине номер контакта");
                        number = long.Parse(Console.ReadLine());
                        FindContackt(number);
                        break;
                    default:
                        break;
                }
            }

            void AddContackt(long number, string name)
            {
                contackBook.Add(number, name);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Котакт успешно добавлен в записную книгу. Номер:{number}, Имя:{name}");
                Console.ResetColor();
                Console.WriteLine("Нажмите клавишу, чтобы продолжить...");
                Console.ReadKey();
            }

            void FindContackt(long number)
            {
                string result;
                if(contackBook.TryGetValue(number, out result))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Контакт найден. Имя:"+result+ " Номер:" +number);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такого контакта нет!");
                    Console.ResetColor();
                }
            }
        }
    }
}
