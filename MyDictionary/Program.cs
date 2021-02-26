using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {

        static Dictionary<string, int> kutuphane = new Dictionary<string, int>();


        static void Main(string[] args)
        {
            kutuphane.Add("Emre", 27);
            kutuphane.Add("Mustafa", 29);
            kutuphane.Add("Ahmet", 45);
            kutuphane.Add("Veli", 38);

            foreach (var item in kutuphane)
            {
                Console.WriteLine(item);
            }

        }
    }
}
