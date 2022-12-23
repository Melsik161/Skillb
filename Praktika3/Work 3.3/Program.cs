using System;

namespace Work_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool remains = true;
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int divider = 2;
            while (divider < number)
            {
                if (number % divider != 0) break;
                remains = false;
                divider++;
            }
            if(remains) Console.WriteLine("Число {0} простое!", number);
            else Console.WriteLine("Число {0} составное!", number);
            Console.ReadKey();
        }
    }
}
