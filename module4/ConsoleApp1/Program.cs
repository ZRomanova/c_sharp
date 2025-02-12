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
            Console.Write("Введите количество строк в матрице: ");
            int rows;

            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            {
                Console.Write("Пожалуйста, введите положительное целое число для количества строк: ");
            }

            Console.Write("Введите количество столбцов в матрице: ");
            int columns;

            while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0)
            {
                Console.Write("Пожалуйста, введите положительное целое число для количества столбцов: ");
            }

            int[,] matrixA = new int[rows, columns];
            Random random = new Random();
            int sum = 0;

            Console.WriteLine("\nСгенерированная матрица A:\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixA[i, j] = random.Next(1, 101); 
                    sum += matrixA[i, j];
                    Console.Write(matrixA[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма всех элементов матрицы A: {sum}");

            int[,] matrixB = new int[rows, columns];
            sum = 0;
            Console.WriteLine("\nСгенерированная матрица B:\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixB[i, j] = random.Next(1, 101);
                    sum += matrixB[i, j];
                    Console.Write(matrixB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма всех элементов матрицы B: {sum}");


            Console.WriteLine("\nСумма матриц A и B:\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write((matrixA[i, j] + matrixB[i, j]) + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
