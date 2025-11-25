using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7_Task2
{
    public class MyClass
    {
        public string change;
    }

    public struct MyStruct
    {
        public string change;
    }

    internal class Program
    {
        static void ClassTaker(MyClass myClass) 
        {
            myClass.change = "Изменено [класс]";
        }

        static void StructTaker(MyStruct myStruct) 
        {
            myStruct.change = "Изменено [структура]";
            Console.WriteLine(myStruct.change);
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "Не изменено [класс]";
            myStruct.change = "Не изменено [структура]";

           ClassTaker(myClass);
           StructTaker(myStruct);

           Console.WriteLine(myClass.change);
           Console.WriteLine(myStruct.change);
        }
    }
}
