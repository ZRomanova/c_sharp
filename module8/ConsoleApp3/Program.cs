using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>(); 

            while (true)
            {
                Console.Write("Введите число (или нажмите Enter для выхода): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    if (numbers.Add(number)) 
                    {
                        Console.WriteLine("Число успешно сохранено.");
                    }
                    else
                    {
                        Console.WriteLine("Это число уже было записано ранее.");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите целое число.");
                }
            }
        }
    }
}
