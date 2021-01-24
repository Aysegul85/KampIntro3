using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklama2 = "Çilek gibi çilek";

            //array
            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("..............metotlat...........");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil armut", 12, 16);


        }
    }
}
