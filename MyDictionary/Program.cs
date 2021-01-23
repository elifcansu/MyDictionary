using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(1, "elif");
            ogrenci.Add(2, "murat");
            Console.WriteLine(ogrenci.Count);

            MyDictionary<int,string> ogrenci2 = new MyDictionary<int,string>();
            ogrenci2.Add(1, "burak");
            ogrenci2.Add(2, "cemile");
            ogrenci2.Add(2, "nevzat");
            Console.WriteLine(ogrenci2.Count);

        }
    }
}
