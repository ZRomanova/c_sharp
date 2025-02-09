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
            string fullName; // Ф. И. О.
            int age; // Возраст
            string email; // Email
            double programmingScore; // Баллы по программированию
            double mathScore; // Баллы по математике
            double physicsScore; // Баллы по физике

            fullName = "Роамнова Зоя Ивановна";
            age = 22;
            email = "zoya@example.com";
            programmingScore = 95.5;
            mathScore = 90.1;
            physicsScore = 78.5;

            Console.WriteLine("Ф. И. О.: {0}", fullName);
            Console.WriteLine("Возраст: {0}", age);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("Баллы по программированию: {0:0.00}", programmingScore);
            Console.WriteLine("Баллы по математике: {0:0.00}", mathScore);
            Console.WriteLine("Баллы по физике: {0:0.00}", physicsScore);


            double totalScore; 
            double averageScore;

            totalScore = programmingScore + mathScore + physicsScore;
            averageScore = totalScore / 3;
            
            Console.WriteLine("Сумма баллов: {0:0.00}", totalScore);
            Console.WriteLine("Средний балл: {0:0.00}", averageScore);

            Console.ReadKey();
        }
    }
}
