using System;

namespace Work5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            ReverseWords(Console.ReadLine());

        }
        static void ReverseWords(string inputPhrase)
        {
            string[] reverse = inputPhrase.Split(' ');
            string revers = "";
            Console.WriteLine(reverse.Length);
            for (int i = 0; i < reverse.Length; i++)
            {

                if (i != 0) revers += " " + reverse[reverse.Length - i - 1];
                else revers += reverse[reverse.Length - i - 1];

            }
            Reverse(revers);
        }
        static void Reverse(string text)
        {
            string[] result = text.Split(' ');
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }

    }
}
