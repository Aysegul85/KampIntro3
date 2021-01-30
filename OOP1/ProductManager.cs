using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
      //ürünle ilgili operasyonlar yazılır
      //..Manager //..Service
      //Add fonksiyon, metot ya da operasyon denebilir
       
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : "+ product.ProductName);
            product.ProductName = "Kamera";
        }


        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        public void BirSeyYap(int sayi)
        {
            sayi = 99;
            Console.WriteLine();
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }


    }     
}
