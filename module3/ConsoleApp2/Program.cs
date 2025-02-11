using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать в игру! Сколько карт у вас на руках? ");

            int numberOfCards;

            while (!int.TryParse(Console.ReadLine(), out numberOfCards) || numberOfCards <= 0)
            {
                Console.Write("Введите целое положительное число: ");
            }

            int totalWeight = 0; 

            for (int i = 1; i <= numberOfCards; i++)
            {
                Console.Write($"Введите номинал карты {i} (число или J, Q, K, T): ");
                string cardInput = Console.ReadLine().ToUpper(); 

                switch (cardInput)
                {
                    case "J": 
                    case "Q": 
                    case "K": 
                    case "T": 
                        totalWeight += 10; 
                        break;
                    default:
                        if (int.TryParse(cardInput, out int cardValue) && cardValue > 0 && cardValue <= 10)
                        {
                            totalWeight += cardValue; 
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                            i--; 
                        }
                        break;
                }
            }

            Console.WriteLine($"Общая сумма карт: {totalWeight}");
            Console.ReadKey();
        }
    }
}
