using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adi);
        }

        public void List (Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Listelendi : "+ musteri.Id+"-" +musteri.Adi+"-"+musteri.Soyadi+"-"+musteri.MusteriNo );
        }


	





    }



}
