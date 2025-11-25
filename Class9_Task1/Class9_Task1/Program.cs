using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//А можно ли это сделать как-то через двумерный массив? 

namespace Lesson8_Task_1
{
    internal class Program
    {

        public class Car
        {
            public string name;
            public int year;

            public Car(string name, int year)
            {
                this.name = name;
                this.year = year;
            }

            public override string ToString()
            {
                return $"Марка: {name} | Год выпуска: {year}";
            }
        }
        public class CarCollection<T>
        {
            private T[] cars;
            private int count;

            public CarCollection()
            {
                cars = new T[3];
                count = 0;
            }

            public int Count
            {
                get { return count; }
            }

            public T this[int index]
            {
                get { return cars[index]; }
            }

            public void Add(T car)
            {
                if (count == cars.Length)
                {
                    Array.Resize(ref cars, cars.Length + 2);
                }
                cars[count] = car;
                count++;
            }

            public void Clear()
            {
                cars = new T[3];
                count = 0;
            }
        }
        static void Main(string[] args)
        {
            var park = new CarCollection<Car>();
            park.Add(new Car("Suzuki", 1999));
            park.Add(new Car("Nisan", 2023));
            park.Add(new Car("Hendai", 2015));
            park.Add(new Car("Honda", 1998));
            park.Add(new Car("Kawasaki", 2007));
            park.Add(new Car("BMW", 2005));

            Console.WriteLine(park[2].ToString());
            park.Clear();
        }
    }
}
