using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длинное предложение:");
            string inputPhrase = Console.ReadLine();
            string reversedPhrase = ReverseWords(inputPhrase);

            Console.WriteLine("\nПредложение с измененным порядком слов:");
            Console.WriteLine(reversedPhrase);
            Console.ReadKey();
        }

        static string ReverseWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        static string[] SplitText(string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
