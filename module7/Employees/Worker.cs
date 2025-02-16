using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public struct Worker
    {
        public int ID { get; set; } 
        public DateTime DateAdded { get; set; } 
        public string FullName { get; set; } 
        public int Age { get; set; } 
        public double Height { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public string PlaceOfBirth { get; set; } 

        public Worker(int id, string fullName, int age, double height, DateTime dateOfBirth, string placeOfBirth)
        {
            ID = id;
            DateAdded = DateTime.Now; 
            FullName = fullName;
            Age = age;
            Height = height;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
        }

        public void Print()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Дата добавления: {DateAdded}");
            Console.WriteLine($"Ф.И.О.: {FullName}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Рост: {Height} см");
            Console.WriteLine($"Дата рождения: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Место рождения: {PlaceOfBirth}");
        }
    }
}
