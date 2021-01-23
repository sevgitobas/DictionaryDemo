using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Halit");
            myDictionary.Add(2, "Yıldız");
            myDictionary.Add(3, "Şahika");
            
            Console.WriteLine(myDictionary.Count);
            
        }
    }
}
