using System;

namespace Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string [] words = SplitText(Console.ReadLine());
            GetWords(words);

        }
        static string[] SplitText(string text)
        {
            string[] result = text.Split(' ');
            return result; 
        }
        static void GetWords(string[] text)
        {
            string word = "П";
            for (int i = 0; i < text.Length; i++)
            {
                word = text[i].Substring(0, 1).ToUpper() + text[i].Remove(0, 1);
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
