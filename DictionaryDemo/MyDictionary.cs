using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] key_array;
        Tvalue[] value_array;

        Tkey[] t_keyArray;
        Tvalue[] t_valueArray;
        public MyDictionary()
        {
            key_array = new Tkey[0];
            value_array = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] t_keyArray = key_array;
            Tvalue[] t_valueArray = value_array;
            
            key_array = new Tkey[key_array.Length + 1];
            value_array = new Tvalue[value_array.Length + 1];
            
            for (int i = 0; i < t_keyArray.Length; i++)
            {
                key_array[i] = t_keyArray[i];
                value_array[i] = t_valueArray[i];
            }
            
            key_array[key_array.Length - 1] = key;
            value_array[value_array.Length - 1] = value;
        }
        
        public int Count
        {
            get { return key_array.Length; }
        }

    }
}
