using System;

namespace Praktika_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Калашников Виктор Александрович";
            byte age = 25;
            string email = "ak47@skillbox.ru";
            float programmingPoints = 78.9f;
            float mathematicsPoint = 83.3f;
            float physicsPoint = 84.5f;
            float bSumma = programmingPoints + mathematicsPoint + physicsPoint;
            float arefm = bSumma / 3;
            Console.WriteLine($"ФИО: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {programmingPoints} \nБаллы по математике: {mathematicsPoint} \nБаллы по физике: {physicsPoint}");
            Console.WriteLine("Для вывода информации о общей сумме баллов и среднем арефметическом нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Сумма баллов по всем предметам: {0:0.00}\nСреднее арифметическое:{1:0.00}", bSumma, arefm);
            Console.ReadKey();
        }
    }
}
