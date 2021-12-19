using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 değeri = sayi2 değeri // değeri aktarırsın ve bütün bağlantın kopar. Değer tip değeri kopyalar ve işi biter.
            sayi2 = 65; // burada olay artık sadece değeri atamaktır.
            //sayi1 = ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999

            // int, decimal, float, double, bool(0-1) = değer tipi
            // array, class, interface = referans tipi
            // bellekte 2 alan vardır "Stack" ve "Heap"
            
            
            // stack sayi1 = 10 , sayi2 = 30 sayi1'in değeri = 10 sayi2'nin değeri = 30
            
            
            //Referans tipte alınan referansın bütün özellikleri alınır yani değişkendir eğer referans içerisinde bir değişiklik olursa bu hepsine yansır.
            //Referans tipte adresi atıyorsun.
        }
    }
}
