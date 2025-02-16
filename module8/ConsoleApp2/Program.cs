using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>();

            InputPhoneData(phoneBook);
            SearchOwnerByPhoneNumber(phoneBook);
        }

        static void InputPhoneData(Dictionary<string, List<string>> phoneBook)
        {
            while (true)
            {
                Console.Write("Введите номер телефона (или нажмите Enter): ");
                string phoneNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    break;
                }

                Console.Write("Введите ФИО владельца: ");
                string ownerName = Console.ReadLine();

                AddToPhoneBook(phoneBook, phoneNumber, ownerName);
            }
        }

        static void AddToPhoneBook(Dictionary<string, List<string>> phoneBook, string phoneNumber, string ownerName)
        {
            if (!phoneBook.ContainsKey(phoneNumber))
            {
                phoneBook[phoneNumber] = new List<string>();
            }
            phoneBook[phoneNumber].Add(ownerName);
        }

        static void SearchOwnerByPhoneNumber(Dictionary<string, List<string>> phoneBook)
        {
            while (true)
            {
                Console.Write("Введите номер телефона для поиска владельца (или нажмите Enter): ");
                string searchNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(searchNumber))
                {
                    break;
                }
                DisplayOwnerInfo(phoneBook, searchNumber);
            }
        }

        static void DisplayOwnerInfo(Dictionary<string, List<string>> phoneBook, string searchNumber)
        {
            if (phoneBook.TryGetValue(searchNumber, out List<string> owners))
            {
                Console.WriteLine($"Владелец(ы) номера {searchNumber}: {string.Join(", ", owners)}");
            }
            else
            {
                Console.WriteLine($"Номер {searchNumber} не найден.");
            }
        }
    }
}
