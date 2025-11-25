using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12_Task2
{
    internal class Program 
    {
        public class Address
        {
            public string city, street;
            public Address (string city, string street)
            {
                this.city = city;
                this.street = street;
            }
        }
        public class House : ICloneable
        {
            public double area;
            public Address address;

            public House (double area, Address address)
            {
                this.area = area;
                this.address = address;
            }

            public object Clone()
            {
                return (House)this.MemberwiseClone();
            }

            public House DeepClone()
            {
                return new House(this.area, new Address(this.address.city, this.address.street));
            }
        }
        static void Main(string[] args)
        {
            House original = new House(100, new Address("Минск", "Ольшевского"));
            House clone = (House)original.Clone();
            House deepClone = original.DeepClone();

            Console.WriteLine($"Оригинал     | Площадь: {original.area}, Адрес: г.{original.address.city} ул.{original.address.street}");
            Console.WriteLine($"Копия        | Площадь: {clone.area}, Адрес: г.{clone.address.city} ул.{clone.address.street}");
            Console.WriteLine($"Глубокий клон| Площадь: {deepClone.area}, Адрес: г.{deepClone.address.city} ул.{deepClone.address.street}");

            original.area = 150;
            original.address.city = "Москва";
            original.address.street = "Колотушкина";

            Console.WriteLine("\nПосле изменений\n");

            Console.WriteLine($"Оригинал     | Площадь: {original.area}, Адрес: г.{original.address.city} ул.{original.address.street}");
            Console.WriteLine($"Копия        | Площадь: {clone.area}, Адрес: г.{clone.address.city} ул.{clone.address.street}");
            Console.WriteLine($"Глубокий клон| Площадь: {deepClone.area}, Адрес: г.{deepClone.address.city} ул.{deepClone.address.street}");
        }
    }
}
