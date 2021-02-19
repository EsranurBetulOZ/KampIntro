using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string[] isimler = new string[] {"Engin","Murat" };
            

            List<string> isimler2 = new List<string> { "engin", "murat", "Kamil" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[2]);
        }
    }
}