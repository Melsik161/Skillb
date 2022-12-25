using System;

namespace Praktika4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numberRows;
            int numberCol;
            int summa = 0;
            int summa2=0;
            Console.Write("Введите количество строк матрицы:");
            numberRows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы:");
            numberCol = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[numberRows, numberCol];
            int[,] array2 = new int[numberRows, numberCol];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = r.Next(10);
                    array2[i, j] = array[i, j];
                    Console.Write($"{array[i, j],5}");
                    if (j == array.GetLength(1) - 1) Console.Write("  ||");
                    summa += array[i, j];
                }
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = r.Next(10);
                    Console.Write($"{array2[i, j],5}");
                    summa2 += array2[i, j];
                }
             
                Console.WriteLine();
            }
            Console.WriteLine("Сложенные матрицы А и Б");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] += array2[i, j];
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов матрицы 1: {summa}");
            Console.WriteLine($"Сумма элементов матрицы 2: {summa2}");
            Console.WriteLine($"Сумма всех матриц: {summa2 + summa}");
            Console.ReadKey();

        }
    }
}
