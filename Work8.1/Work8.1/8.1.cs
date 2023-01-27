using System;
using System.Collections.Generic;

namespace Work8._1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();
            AddNumbersList();
            GetNumbers();
            Console.WriteLine("________________________________________________");
            DeleteNumbers();
            GetNumbers();

            void AddNumbersList()
            {
                for (int i = 0; i < 100; i++)
                 numbers.Add(rand.Next(0, 101));
            }
            void DeleteNumbers()
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > 25 && numbers[i] < 50)
                    {
                        numbers.RemoveAt(i);
                        i--;
                    }
                }
                   
            }
            
            void GetNumbers()
            {
                foreach (var item in numbers)
                Console.WriteLine(item);
            }
        }
        
    }
}
