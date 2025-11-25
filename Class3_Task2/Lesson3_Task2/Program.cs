using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Task2
{
    public class Vehicle
    {
        protected double cordX, cordY;
        protected int price, speed, year;

        public void ShowInfo()
        {
            Console.WriteLine($"Координаты средства передвижения | X:{this.cordX} Y:{this.cordY} |");
            Console.WriteLine($"Цена: {this.price} $");
            Console.WriteLine($"Максимальная скорость: {this.speed} км/ч");
            Console.WriteLine($"Год выпуска: {this.year}");
        }
    }

    public class Plane : Vehicle
    {
        private int height, passanger_num;
        public Plane (double cordX, double cordY, int price, int speed, int year, int height, int passanger_num)
        {
            this.cordX = cordX;
            this.cordY = cordY;
            this.price = price;
            this.speed = speed;
            this.year = year;
            this.height = height;
            this.passanger_num = passanger_num;
        }
        public void PlaneInfo()
        {
            Console.WriteLine("          Инфорамция о самолёте");
            ShowInfo();
            Console.WriteLine($"Максимальная высота полёта: {this.height}");
            Console.WriteLine($"Максимально допустимое кол-во пассажиров: {this.passanger_num}");
            Console.WriteLine();
        }
    }

    public class Ship : Vehicle
    {
        private int passanger_num;
        private string port_name;

        public Ship(double cordX, double cordY, int price, int speed, int year, int passanger_num, string port_name)
        {
            this.cordX = cordX;
            this.cordY = cordY;
            this.price = price;
            this.speed = speed;
            this.year = year;
            this.passanger_num = passanger_num;
            this.port_name = port_name;
        }

        public void ShipInfo()
        {
            Console.WriteLine("          Инфорамция о яхте");
            ShowInfo();
            Console.WriteLine($"Максимально допустимое кол-во пассажиров: {this.passanger_num}");
            Console.WriteLine($"Порт приписки: {this.port_name}");
            Console.WriteLine();
        }
    }

    public class Car : Vehicle
    {
        public Car(double cordX, double cordY, int price, int speed, int year)
        {
            this.cordX = cordX;
            this.cordY = cordY;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public void CarInfo()
        {
            Console.WriteLine("          Инфорамция о машине");
            ShowInfo();
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(11.3241516, 23.123526, 13000000, 6000, 1990, 32000, 72);
            Ship ship = new Ship(14.1574234, 12.332116, 600000, 150, 2007, 33, "Блэкфорт");
            Car car = new Car(65.1563112, 35.371626, 30000, 220, 2020);
            plane.PlaneInfo();
            ship.ShipInfo();
            car.CarInfo();
        }
    }
}
