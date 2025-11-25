using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class4_Lesson1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт XML документ");
        }
        public override void Create()
        {
            Console.WriteLine("Создан XML документ");
        }
        public override void Change()
        {
            Console.WriteLine("Изменён XML документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранён XML документ");
        }

        public void gay()
        {
            Console.WriteLine();
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт TXT документ");
        }
        public override void Create()
        {
            Console.WriteLine("Создан TXT документ");
        }
        public override void Change()
        {
            Console.WriteLine("Изменён TXT документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранён TXT документ");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт DOC документ");
        }
        public override void Create()
        {
            Console.WriteLine("Создан DOC документ");
        }
        public override void Change(){
           Console.WriteLine("Изменён DOC документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранён DOC документ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\osu!\\osu!.txt";
            string format = path.Substring(path.LastIndexOf('.') + 1);
            AbstractHandler handler;

            switch (format)
            {
                case "xml":
                    handler = new XMLHandler();
                    break;

                case "txt":
                    handler = new TXTHandler();
                    break;

                case "doc":
                    handler = new DOCHandler();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Неизвестный формат");
                    return;
            }

            Console.WriteLine();
            Console.WriteLine("          Работа с документом");
            Console.WriteLine();
            handler.Create();
            Thread.Sleep(1000);
            Console.WriteLine();
            handler.Open();
            Thread.Sleep(1000);
            Console.WriteLine();
            handler.Change();
            Thread.Sleep(1000);
            Console.WriteLine();
            handler.Save();
            Thread.Sleep(1000);
        }
    }
}
