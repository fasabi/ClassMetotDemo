using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void Print()
        {
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < keys.Length ; i++)
            {
                Console.WriteLine("Key: " + keys[i] + "    Value: " + values[i]);
            }

            Console.WriteLine("--------------------------------------------");
        }
    }
}
