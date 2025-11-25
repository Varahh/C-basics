using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Task3
{
    public class Article
    {
        private double price;
        private string title, shop;

        public Article(string title, string shop, double price)
        {
            this.price = price;
            this.title = title;
            this.shop = shop;
        }

        public void showInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Название товара: " + title);
            Console.WriteLine();
            Console.WriteLine("Магазин, в котором продается товар: " + shop);
            Console.WriteLine();
            Console.WriteLine("Цена товара: " +  price + " грн.");
            Console.WriteLine();
        }

        public string getTitle { get { return title; } }
    }

    public class Store
    {
        private Article[] articles;

        public Store (params Article[] articles)
        {
            this.articles = articles;
        }

        public void ShowByIndex(int index)
        {
            articles[index].showInfo();
        }

        public void ShowByName(string name) {

            for (int i = 0; i < articles.Length; i++) {

                if (articles[i].getTitle.ToLower() == name.ToLower())
                {
                    articles[i].showInfo();
                    break;
                }
                if (i == articles.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Данный товар не найден!");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("M4A1", "IKEA", 5000);
            Article a2 = new Article("Гамбургер", "Вкусно и точка", 1.69);
            Store store = new Store(a1, a2);
            Console.WriteLine("Введите название товара ");
            Console.WriteLine();
            store.ShowByName(Console.ReadLine());
        }
    }
}
