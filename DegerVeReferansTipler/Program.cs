using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {   //değer tip sadece stackte çalışır
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=? 30


            //referans tip stack ve heapte çalışır
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar2[0] = 999;
            //sayilar[0] = ? 999

            //int, double, string, bool, decimal, flood: değer tip
            //array, class, interfare: referans tip
            //stack //heap
        }
    }
}
