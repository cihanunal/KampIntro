using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "cihan", "ferhan", "unal", "nenni" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            // yeni eleman ekleme sorun, c# ta genellikle array (dizi) kullanmmıyorlar. kolleksiyonları kullancaz.

            List<string> isimler2 = new List<string> { "cihan", "ferhan", "unal", "nenni" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("devran");  // ekleme yapmanın yolu
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
