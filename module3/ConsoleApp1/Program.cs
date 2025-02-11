using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");

            string input = Console.ReadLine();

            int number = int.Parse(input);

            if (number % 2 == 0)
            { 
                Console.WriteLine("Число {0} - четное.", number);
            }
            else
            {
                Console.WriteLine("Число {0} - нечетое.", number);
            }

            Console.ReadKey();

        }
    }
}
