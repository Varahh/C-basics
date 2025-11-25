using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Задания 1 и 2 я совмещу в одном решении так как задание 2 требует модификации задания 1

namespace Lesson6_Task1
{
    public static class FindAndReplaceManager
    {
        private static string filepath = "E:\\file.txt";
        public static void FindText(string search)
        {
            string[] lines = File.ReadAllLines(filepath);
            int counter = 0;
            foreach (string line in lines) {
                counter++;
                if (line == search)
                {
                    Console.WriteLine("Нужная строка найдена! Её номер " + counter);
                }
            }
        }

        public class Notes
        {
            private string notepath;
            public static void AddToNote(string notepath, string text)
            {
                using (StreamWriter writer = File.AppendText(notepath)) 
                {
                    writer.Write(text + "\r\n");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindText("r34");

            FindAndReplaceManager.Notes.AddToNote("E:\\note.txt", "Я вторая строка");
        }
    }
}
