using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11_Task1
{
    internal class Program
    {
        public struct Worker : IComparable<Worker>
        {
            public string FIO, title;
            public int year;
            

            public Worker(string FIO, string title, int year)
            {
                this.FIO = FIO;
                this.title = title;
                this.year = year;
            }

            int IComparable<Worker>.CompareTo(Worker other)
            {
                return this.FIO.CompareTo(other.FIO);
            }

            public void Print() {
                Console.WriteLine($"Фамилия и инициалы: {FIO}");
                Console.WriteLine($"Должность: {title}");
                Console.WriteLine($"Год поступления на работу: {year}\n\n");
            }
        }
        static void Main(string[] args)
        {
            int minAge;
            Worker[] workers = new Worker[2];
            for (int i = 0; i < workers.Length; i++)
            {
                int year;
                Console.WriteLine("\nВведите фамилию и инициалы\n");
                string FIO = Console.ReadLine();
                Console.WriteLine("\nВведите должность\n");
                string title = Console.ReadLine();
                Console.WriteLine("\nВведите год поступления на работу\n");
                if (!int.TryParse(Console.ReadLine(), out year) || year < 1925)
                {
                    throw new Exception("Введено неверное значение");
                }
                workers[i] = new Worker(FIO, title, year);
            }

            Array.Sort(workers);
            Console.Clear();
            foreach (Worker worker in workers)
            {
                worker.Print();
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Введите необходимый стаж\n");
            while (!int.TryParse(Console.ReadLine(), out minAge))
            {
                Console.WriteLine("\nВведено неверное значение! Пожалуйста, введите целочисленное значение\n");
            }

            foreach (Worker worker in workers)
            {
                if(2025 - worker.year >= minAge)
                {
                    Console.WriteLine();
                    Console.WriteLine(worker.FIO);
                }
            }
        }
    }
}
