using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager  // claslar mutlaka pascal case şeklinde yazılmalı. İlk harfler büyük olacak
    {
        // fonksiyon görev operasyon ekleme için yazıyoruz.
        public void Add(Product product) // Product türünde product giricez. Bunu string türünde isim vermek gibi düşün.
        {
            Console.WriteLine(product.ProductName + "eklendi." );
        
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName+ "güncellendi");
        
        }

        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }



    }
}
