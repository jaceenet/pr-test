using System;
using System.Collections;
using System.Collections.Generic;

namespace SomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var item = new Dictionary<string, object>();
            item.Add("key1", 1);
            item.Add("key2", 2);
            item.Add("key3", 3);
        }
    }
}