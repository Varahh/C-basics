using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_Task1
{
    internal class Program
    {
        public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
        {
            private TKey[] keys;
            private TValue[] values;
            private int count;

            public MyDictionary()
            {
                keys = new TKey[3];
                values = new TValue[3];
                count = 0;
            }

            public TValue this[TKey key]
            {
                get
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (keys[i].Equals(key))
                            return values[i];
                    }
                    return default(TValue);
                }
            }

            public void Add(TKey key, TValue value) { 
                for (int i = 0; i< count; i++)
                {
                    if (keys[i].Equals(key))
                    {
                        throw new Exception("Такой ключ существует");
                    }
                }
                if (count == keys.Length)
                {
                    Array.Resize(ref keys, keys.Length + 2);
                    Array.Resize(ref values, values.Length + 2);
                }

                keys[count] = key;
                values[count] = value;
                count++;
            }

            public int Count
            {
                get { return count; }
            }
            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                for (int i = 0; i < count; i++)
                {
                    yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }                                                                   
        }
        static void Main(string[] args)
        {
            var test = new MyDictionary<int, string>();
            test.Add(1, "BMW");
            test.Add(3, "Nissan");
            test.Add(4, "Gssan");
            test.Add(8, "Ossan");
            foreach (var key in test) { 
            Console.WriteLine($"{key.Key} : {key.Value}");
            }
        }
    }
}
