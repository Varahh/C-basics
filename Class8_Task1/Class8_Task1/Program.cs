using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8_Task1
{
    internal class Program
    {
        public class MyList<T>
        {
            private T[] values;
            private int count;

            public MyList()
            {
                values = new T[3];
                count = 0;
            }

            public int Count
            {
                get { return count; }
            }

            public T this[int index]
            {
                get { return values[index]; }
            }

            public void Add(T value)
            {
                if (count == values.Length)
                {
                    Array.Resize(ref values, values.Length + 2);
                }
                values[count] = value;
                count++;
            }
        }
        static void Main(string[] args)
        {
            MyList<int> test = new MyList<int>();
            test.Add(15);
            test.Add(30);
            test.Add(45);
            test.Add(79);
            test.Add(75176);

            Console.WriteLine(test.Count);
            Console.WriteLine(test[6]);
        }
    }
}
