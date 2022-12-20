using System;

namespace Praktika2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Калашников Виктор Александрович";
            byte age = 25;
            string email = "ak47@skillbox.ru";
            float bProg = 78.9f, bMat = 83.3f, bFiz = 84.5f;
            float bSumma = bProg + bMat + bFiz, arefm=bSumma/3;
            Console.WriteLine($"ФИО: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {bProg} \nБаллы по математике: {bMat} \nБаллы по физике: {bFiz}");
            Console.WriteLine("Для вывода информации о общей сумме баллов и среднем арефметическом нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Сумма баллов по всем предметам: {0:0.00}\nСреднее арифметическое:{1:0.00}", bSumma, arefm);
            Console.ReadKey();
        }
    }
}
