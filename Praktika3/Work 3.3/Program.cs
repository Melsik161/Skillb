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
            int i = 2;
            while (i < number)
            {

                if (number % i != 0) ;
                else remains = false;
                i++;
            }
            switch (remains)
            {
                case true: Console.WriteLine("Число {0} простое!", number); break;
                default: Console.WriteLine("Число {0} составное!", number); break;
            }
            Console.ReadKey();
        }
    }
}
