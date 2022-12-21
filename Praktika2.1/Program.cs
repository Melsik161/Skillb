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
            float programmingPoints = 78.9f;
            float mathematicsPoint = 83.3f;
            float physicsPoint = 84.5f;
            Console.WriteLine($"ФИО: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {programmingPoints} \nБаллы по математике: {mathematicsPoint} \nБаллы по физике: {physicsPoint}");
            Console.ReadKey();
        }
    }
}
