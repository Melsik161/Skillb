using System;

namespace Praktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки на четность: ");
            int checkNumber = int.Parse (Console.ReadLine());
            if(checkNumber % 2 == 0) Console.WriteLine("Число {0} четное!", checkNumber);
            else Console.WriteLine("Число {0} нечетное!", checkNumber);
            Console.Read();
        }
    }
}
