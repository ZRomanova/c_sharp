using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            FillList(numbers);
            PrintList(numbers);
            RemoveNumbers(numbers, 25, 50);
            PrintList(numbers);

            Console.ReadKey();
        }

        static void FillList(List<int> list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 101)); 
            }
        }

        static void RemoveNumbers(List<int> list, int minNum, int maxNum)
        {
            list.RemoveAll(num => num > minNum && num < maxNum);
        }

        static void PrintList(List<int> list)
        {
            Console.WriteLine("Содержимое списка:");
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n"); 
        }
    }
}
