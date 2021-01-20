using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        // naming convention Pythondaki def yani metod, (fonksiyondu sank)...
        // eğer bir yerde normal parantez görürsek anlarız ki orada metod kullanılıyor.

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! sepete eklendi" + ":" + urun.urunAdi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("sepete eklendi" + ":" + urun.urunAdi);


        }


    }
}
