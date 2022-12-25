using System;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numberRows;
            int numberCol = 0;
            int summa = 0;
            Console.Write("Введите количество строк матрицы:");
            numberRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы:");
            numberCol = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[numberRows, numberCol];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(10);
                    Console.Write($"{array[i, j],5}");
                    if (j == array.GetLength(1) - 1) ;
                    summa += array[i, j];
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов матрицы: {summa}");
            Console.ReadKey();

        }
    }
}
