using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7_Task1
{
    public struct Train : IComparable<Train>
    {
        private string destination, time;
        public int id;
        

        public Train(string destination, string time, int id)
        {
            this.destination = destination;
            this.time = time;
            this.id = id;
        }

        public int CompareTo(Train obj)
        {
            return id.CompareTo(obj.id);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Номер поезда: " + id);
            Console.WriteLine("Пункт назначения: " + destination);
            Console.WriteLine("Время отправления: " + time);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int searchID;
            Train[] trains = new Train[3];

            for (int i = 0; i < trains.Length; i++)
            {
                int id;

                Console.WriteLine("Введите номер поезда");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("\nВведенное значение не может быть номером поезда! Введите целочисленное значение \n");
                }
                Console.WriteLine("\nВведите пункт назначения");
                string destination = Console.ReadLine();
                Console.WriteLine("\nВведите время отправления");
                string time = Console.ReadLine();

                trains[i] = new Train(destination, time, id);
                Console.WriteLine();

            }

            Array.Sort(trains);

            Console.Clear();



             Console.WriteLine("Введите номер поезда для поиска");
             while (!int.TryParse(Console.ReadLine(), out searchID))
             {
                 Console.WriteLine("\nВведенное значение не может быть номером поезда! Введите целочисленное значение \n"); break;
             }
             
             for (int i = 0; i < trains.Length; i++)
             {
                 if (trains[i].id == searchID)
                 {
                     trains[i].ShowInfo();
                     break;
                 }
                 if (i == trains.Length - 1)
                 {
                     Console.WriteLine("Данный поезд не найден, повторите попытку");
                 }
             }
        }
    }
}
