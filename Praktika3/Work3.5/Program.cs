using System;

namespace Work3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Приветствую тебя, друг. Введи число макс. диапазона, чтобы мы сгенерировали случайное число от 0: ");
            int range = rand.Next(0, Convert.ToInt32(Console.ReadLine()));
            Console.Write("Число сгенерировано! Введите число: ");
            string number = Console.ReadLine();
            if (String.IsNullOrEmpty(number))
            {
                Console.WriteLine("Вы ввели пустую строку. Сгенерированное число: {0}. Для закрытия программы нажмите любую кнопку", range);

                Environment.Exit(0);
            }
            do
            {

                if (Convert.ToInt32(number) < range)
                {
                    Console.Write("Число меньше загаданного. Попробуйте ввести новое:");
                    number = Console.ReadLine();
                    if (String.IsNullOrEmpty(number))
                    {
                        Console.WriteLine("Вы ввели пустую строку. Сгенерированное число: {0}. Для закрытия программы нажмите любую кнопку", range);

                        Environment.Exit(0);
                    }

                }
                else if (Convert.ToInt32(number) > range)
                {
                    Console.Write("Число больше загаданного. Попробуйте ввести новое:");
                    number = Console.ReadLine();
                    if (String.IsNullOrEmpty(number))
                    {
                        Console.WriteLine("Вы ввели пустую строку. Сгенерированное число: {0}. Для закрытия программы нажмите любую кнопку", range);

                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Вы угадали число: {0}", number);
                    break;
                }

            } while (1 == 1);


            Console.ReadKey();
        }
    }
}
