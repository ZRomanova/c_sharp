using System;

namespace Employees
{
    internal class Program
    {
        static Repository repository = new Repository("emloyee.txt");

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Вывести все данные на экран");
                Console.WriteLine("2 - Добавить новую запись");
                Console.WriteLine("3 - Удалить запись");
                Console.WriteLine("4 - Найти добавленных в заданном промежутке");
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
                    case "3":
                        DeleteEmployee();
                        break;
                    case "4":
                        FilterEmployees();
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
            Worker[] workers = repository.GetAllWorkers();
            ShowEmployees(workers);

        }

        static void AddEmployee()
        {
            Console.Write("Введите Ф. И. О.: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения (гггг-мм-дд): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите место рождения: ");
            string birthPlace = Console.ReadLine();

            Worker worker = new Worker(0, fullName, age, height, birthDate, birthPlace);

            repository.AddWorker(worker);
        }

        static void DeleteEmployee()
        {
            Console.Write("Введите ID: ");
            int id = int.Parse(Console.ReadLine());
            repository.DeleteWorker(id);
        }

        static void FilterEmployees()
        {
            Console.Write("Введите нижнюю границу (гггг-мм-дд чч:мм:сс): ");
            DateTime fromDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите верхнюю границу (гггг-мм-дд чч:мм:сс): ");
            DateTime toDate = DateTime.Parse(Console.ReadLine());

            Worker[] workers = repository.GetWorkersBetweenTwoDates(fromDate, toDate);
            ShowEmployees(workers);
        }


        private static void ShowEmployees(Worker[] workers)
        {
            foreach (var worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }
        }
    }
}
