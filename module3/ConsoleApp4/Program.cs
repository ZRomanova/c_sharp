using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности: ");
            int sequenceLength;

            while (!int.TryParse(Console.ReadLine(), out sequenceLength) || sequenceLength <= 0)
            {
                Console.Write("Пожалуйста, введите положительное целое число: ");
            }

            int minElement = int.MaxValue; 

            for (int i = 0; i < sequenceLength; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                int currentNumber;

                while (!int.TryParse(Console.ReadLine(), out currentNumber))
                {
                    Console.Write("Пожалуйста, введите целое число: ");
                }

                if (currentNumber < minElement)
                {
                    minElement = currentNumber; 
                }
            }

            Console.WriteLine($"Минимальный элемент в последовательности: {minElement}");
            Console.ReadKey();
        }
    }
}
