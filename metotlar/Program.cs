using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };


            Urun urun1 = new Urun(); // Urun clasını oluşturmuştuk. Şimdi bu claasa ait bir urun girmek için bu kod yazılır.
            urun1.urunAdi = "elma";
            urun1.fiyati = 15;
            urun1.aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.urunAdi = "karpuz";
            urun2.fiyati = 80;
            urun2.aciklama = "diyar bakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2}; // ürünleri dizi olarak yazma. süslü parantezin içine urunleri yazmayı unutma ...

            // ..Üstteki Urun clasına ait urunler adlı veri dizisi. 

            foreach (Urun urun in urunler) // Urun clasında olan (var yazsanda olur) ve urunler arrayından urun ...
                // ..(bu adı biz verdik istersen mahmut de) adlı elemanları dolaşır. Yani iki kere döner.
            {
                Console.WriteLine(urun.urunAdi); // print ve console writeline yazılımcının kod sonucunu hemen görmek istediği için kullandığı kod parçasıdır.
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("------------");
                
                
            }

            Console.WriteLine("----------metotlar------");

            // instance- örnek oluşturma. Şimdi sepet manager sayfasında metodu yazdıktan sonra mesela metodu burada ..
            // .. kullanmak istediğimi düşün. bu durumda önce instance yapıyoruz. Kısacası tanıtıyoruz ne olduğunu söylüyoruz.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            // bu yukarısında olan kod aynı işi yapar. ama bu kod kendini tekrar kontrol ettirme ihtiyacı hisseder.
            // mesela yönetim bir de stok adedi ekleyelim derse her sayfa güncelleme ister.
            sepetManager.Ekle2("armut", "yeişl armut", 12); 

            


      

        }
    }
}
