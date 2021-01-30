using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            //ctrl K ctrl C yorum satırı yapma
            //ctrl K ctrl U yorum satırı kaldırma

            Console.WriteLine("---------------------List<string>--------------");
            List<string> isimler2 = new List<string>();
            //veya 
            List<string> isimler3 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("İlker");
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);
              







        }
    }
}
