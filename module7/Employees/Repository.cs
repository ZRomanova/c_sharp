using Employees;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Employees
{
    public class Repository
    {
        private readonly string fileName;

        public Repository(string fileName)
        {
            this.fileName = fileName;
        }

        public Worker[] GetAllWorkers()
        {
            if (!File.Exists(fileName))
            {
                return Array.Empty<Worker>(); 
            }

            var workers = new List<Worker>();
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                var parts = line.Split('#');
                if (parts.Length == 7)
                {
                    var id = int.Parse(parts[0]);
                    var dateAdded = DateTime.Parse(parts[1]);
                    var fullName = parts[2];
                    var age = int.Parse(parts[3]);
                    var height = double.Parse(parts[4]);
                    var dateOfBirth = DateTime.Parse(parts[5]);
                    var placeOfBirth = parts[6];

                    var worker = new Worker(id, fullName, age, height, dateOfBirth, placeOfBirth)
                    {
                        DateAdded = dateAdded 
                    };
                    workers.Add(worker);
                }
            }

            return workers.ToArray(); 
        }

        public Worker GetWorkerById(int id)
        {
            var workers = GetAllWorkers();
            return workers.FirstOrDefault(w => w.ID == id); 
        }

        public void DeleteWorker(int id)
        {
            var workers = GetAllWorkers();
            Nullable<Worker> workerToDelete = workers.FirstOrDefault(w => w.ID == id);

            if (workerToDelete is null)
            {
                Console.WriteLine($"Работник с ID {id} не найден.");
                return;
            }

            var updatedWorkers = workers.Where(w => w.ID != id).ToArray();
            SaveWorkersToFile(updatedWorkers); 
            Console.WriteLine($"Работник с ID {id} успешно удален.");
        }

        public void AddWorker(Worker worker)
        {
            var workers = GetAllWorkers();
            worker.ID = workers.Length > 0 ? workers.Max(w => w.ID) + 1 : 1; 
            var updatedWorkers = workers.Append(worker).ToArray();
            SaveWorkersToFile(updatedWorkers); 
            Console.WriteLine("Новый работник успешно добавлен.");
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            var workers = GetAllWorkers();
            return workers.Where(w => w.DateAdded >= dateFrom && w.DateAdded <= dateTo).ToArray(); 
        }

        private void SaveWorkersToFile(Worker[] workers)
        {
            using (var writer = new StreamWriter(fileName))
            {
                foreach (var worker in workers)
                {
                    writer.WriteLine($"{worker.ID}#{worker.DateAdded}#{worker.FullName}#{worker.Age}#{worker.Height}#{worker.DateOfBirth}#{worker.PlaceOfBirth}");
                }
            }
        }
    }
}
