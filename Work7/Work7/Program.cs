using System;

namespace Work7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Repository w = new Repository();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Добро пожаловать в базу данных сотрудников.");
            Console.ResetColor();
            w.checkFile(); // Проверка существует ли файл Staff.txt
            w.startProg(); // Запуск текста помощи.
            
            

        } 
    }
}
