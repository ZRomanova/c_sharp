using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Введите максимальное целое число диапазона: ");
            int maxNumber;

            while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber <= 0)
            {
                Console.Write("Пожалуйста, введите положительное целое число: ");
            }

            int secretNumber = random.Next(0, maxNumber + 1);
            Console.WriteLine($"Я загадал число от 0 до {maxNumber}. Попробуйте его угадать!");

            while (true)
            {
                Console.Write("Введите предположение (или нажмите Enter, чтобы выйти): ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine($"Вы вышли из игры. Моё число было: {secretNumber}");
                    break;
                }

                if (int.TryParse(userInput, out int userGuess))
                {
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine($"Моё число больше {userGuess}.");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine($"Моё число меньше {userGuess}.");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляем! Вы угадали число!");
                        break; 
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
