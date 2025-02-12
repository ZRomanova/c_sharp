using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        static string filePath = "employees.txt"; 

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Вывести данные на экран");
                Console.WriteLine("2 - Добавить новую запись");
                Console.WriteLine("0 - Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayRecords();
                        break;
                    case "2":
                        AddEmployee();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }

        static void DisplayRecords()
        {
            if (File.Exists(filePath))
            {
                string[] records = File.ReadAllLines(filePath);
                foreach (string record in records)
                {
                    foreach (string word in record.Split('#'))
                    {
                        Console.Write($"{word} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }

        static void AddEmployee()
        {
            int id = GetNextId();
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            Console.Write("Введите Ф. И. О.: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            string birthDate = Console.ReadLine();

            Console.Write("Введите место рождения: ");
            string birthPlace = Console.ReadLine();

            string record = $"{id}#{dateTime}#{fullName}#{age}#{height}#{birthDate}#{birthPlace}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(record);
            }

            Console.WriteLine("Запись успешно добавлена!");
        }

        static int GetNextId()
        {
            if (File.Exists(filePath))
            {
                string[] records = File.ReadAllLines(filePath);
                if (records.Length > 0)
                {
                    string lastRecord = records[records.Length - 1];
                    string[] parts = lastRecord.Split('#');
                    return int.Parse(parts[0]) + 1; 
                }
            }
            return 1; 
        }
    }
}
