using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длинное предложение:");
            string inputText = Console.ReadLine();
            string[] words = SplitText(inputText);
            PrintWords(words);
            Console.ReadKey();
        }

        static string[] SplitText(string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        static void PrintWords(string[] words)
        {
            Console.WriteLine("\nСлова в предложении:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
