using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Class3_Task3
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string prokey = "111222333";
            string expertkey = "ExpertKeyLol";

            DocumentWorker worker;

            Console.WriteLine("Введите ключ программы");

            var key = Console.ReadLine();

            Console.WriteLine();
            if (key == prokey)
            {
                worker = new ProDocumentWorker();
                Console.WriteLine("Про версия программы активирована");
                Console.WriteLine();
                worker.OpenDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
                worker.EditDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
                worker.SaveDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
            }
            else if (key == expertkey)
            {
                worker = new ExpertDocumentWorker();
                Console.WriteLine("Эксперт версия программы активирована");
                Console.WriteLine();
                worker.OpenDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
                worker.EditDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
                worker.SaveDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
            }
            else
            {
                worker = new DocumentWorker();
                Console.WriteLine("Ключ не введен либо введен неверно. Доступна только бесплатная версия программы");
                Console.WriteLine();
                worker.OpenDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
                worker.EditDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
                worker.SaveDocument();
                Thread.Sleep(2000);
                Console.WriteLine();
            }
        }
    }
}
