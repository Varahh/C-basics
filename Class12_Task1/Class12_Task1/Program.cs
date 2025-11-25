using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12_Task1
{
    internal class Program
    {
        public class Block
        {
           public int a, b, c, d;
            public Block(int a, int b, int c, int d) 
            {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            }

            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Block other = obj as Block;
                return this.a + this.b + this.c + this.d == other.a + other.b + other.c + other.d;
            }

            public override string ToString()
            {
                return $"Сторона а: {this.a}, Cторона b: {this.b}, Сторона c: {this.c}, Сторона d: {this.d}";
            }
        }
        static void Main(string[] args)
        {
            Block b1 = new Block(1,2, 3, 4);
            Block b2 = new Block(2, 3, 4, 1);
            Block b3 = new Block(5, 5, 5, 5);
            if (b1.Equals(b3))
            {
                Console.WriteLine("Квадраты равны");
            }
            else { Console.WriteLine("Квадраты не равны"); }

            Console.WriteLine(b2.ToString());
        }
    }
}
