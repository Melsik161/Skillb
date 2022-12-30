using System;

namespace Work5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение:");
            ReverseWords(Console.ReadLine());
            Console.ReadKey();

        }
        static void ReverseWords(string inputPhrase)
        {
            string[] reverse = inputPhrase.Split(' ');
            string result = string.Empty;
            Console.WriteLine("Предложение разбито на слова:");
            for (int i = 0; i < reverse.Length; i++)
            {
                result += reverse[i] + " ";
                Console.WriteLine(reverse[i]);
            }
            Reverse(result);
        }
        static void Reverse(string text)
        {
            string[] changeWords = text.Split(" ");
            Console.WriteLine();
            Console.WriteLine("Предложение перевернуто: ");
            for (int i = 0; i < changeWords.Length; i++)
            { 
                Console.Write(changeWords[changeWords.Length - i - 1] + " ");

            }
            
            
        }

    }
}
