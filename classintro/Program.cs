using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); // yani kurs oluşturdum.
            kurs1.KursAdi = "C#";  // mesala class adı oluştuğu için, içine artık kurs adını eklemek için . koyup atayabiliriz.
            kurs1.Egitmen = "cihan unal"; // tırnak içi çünkü string
            kurs1.IzlenmeOrani = 99; // tırnak yok çünkü integer 

            Kurs kurs2 = new Kurs(); // yani kurs oluşturdum.
            kurs2.KursAdi = "Python";  // mesala class adı oluştuğu için, içine artık kurs adını eklemek için . koyup atayabiliriz.
            kurs2.Egitmen = "ferhan unal"; // tırnak içi çünkü string
            kurs2.IzlenmeOrani = 99; // tırnak yok çünkü integer 

            Kurs kurs3 = new Kurs(); // yani kurs oluşturdum.
            kurs3.KursAdi = "java";  // mesala class adı oluştuğu için, içine artık kurs adını eklemek için . koyup atayabiliriz.
            kurs3.Egitmen = "esra lil"; // tırnak içi çünkü string
            kurs3.IzlenmeOrani = 99; // tırnak yok çünkü integer 

            Console.WriteLine(kurs1.KursAdi + ' ' + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 }; // kurslar array yaptık bak


            foreach (var kurs in kurslar) // tekrar tekrar dön ve her döndüğünde ilgili kurs adını yaz.
            {
                Console.WriteLine(kurs.KursAdi);

            }


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ':' + kurs.Egitmen);
            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; } //prop yaz tab tab yap. sonra string yaz sonra ismini yaz.

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }

    
}
