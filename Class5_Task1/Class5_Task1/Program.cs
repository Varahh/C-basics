using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введено неверное значение, введите целое число!");
            }
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }

            Console.WriteLine("Наибольшее значение: " + arr.Max());
            Console.WriteLine("Наименьшее значение: " + arr.Min());
            Console.WriteLine("Сумма всех элементов: " + arr.Sum());
            Console.WriteLine("Среднее значение всех элементов: " + arr.Average());
            Console.WriteLine("Нечетные элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
