using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 3;
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Akbaba";
            musteri1.MusteriNo = 3456;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 6;
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Demir";
            musteri2.MusteriNo = 35475;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 8;
            musteri3.Adi = "Ayça";
            musteri3.Soyadi = "Karadağ";
            musteri3.MusteriNo = 775665;


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Delete(musteri1);
            musteriManager.List(musteri3);


        }
    }
}
