using System;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 11;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdedi = 15;

            Urun[] urunler = new[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {           
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("-------------------");

            }

            Console.WriteLine("--------------Metodlar------------");

            //instance - class örneği olusturma
            //encaptulation - DRY ekle2 yanlıs bir kullanım sekli optimal olan "Ekle"    "düzensiz olacak yapıyı, düzen içine sokmak"
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            //sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 8);
            //sepetManager.Ekle2("Karpuz", "Güzel karpuz", 12, 9);
        }
    }
}


//Don't repeat urself - DRY - Clean Code - Best Practice