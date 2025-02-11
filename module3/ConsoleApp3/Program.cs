using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N;

            while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.Write("Введите положительное целое число: ");
            }

            bool isNotPrime = false;

            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isNotPrime = true; 
                    break; 
                }
            }

            if (N == 1 || isNotPrime)
            {
                Console.WriteLine($"{N} не является простым числом.");
            }
            else
            {
                Console.WriteLine($"{N} - простое число.");
            }

            Console.ReadKey();
        }
    }
}
