using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "cihan kursu";
            string kurs2 = "unal kursu";
            string kurs3 = "java";

            //array-dizi

            string[] kurslar = new string[] { "cihan kursu" , "unal kursu", "java", "C#" };


            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //kursları tek tek dolaş demek. Yukarıdaki kodun aynı görevini yapar. Diziler için çalışır. bu kod kursların içinde tek tek dolaşır.
            // bak burada kurs nedir tanımlamadık ama kurs demekte sakınca yok.
            //sonuçta her eleman bir kurs değil mi evet kurs.

            foreach (string kurs in kurslar)  
            {
                Console.WriteLine(kurs);
            
            }


            Console.WriteLine("bitti.");
        }
    }
}
