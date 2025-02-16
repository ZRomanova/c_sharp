using System;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите домашний телефон: ");
            string flatPhone = Console.ReadLine();

            XElement person = new XElement("Person",
                new XAttribute("name", fullName),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", flatPhone)
                )
            );

            string fileName = "ContactInfo.xml";
            person.Save(fileName);

            Console.WriteLine($"Данные успешно сохранены в файл {fileName}");

            Console.ReadKey();
        }
    }
}
