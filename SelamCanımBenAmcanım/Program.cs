using System;

namespace kampIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            //Don't repeat urself 
            //burada bulunan kategoriEtiketi bir değer tutucu = Alias
            //String = yazı olan değerler
            //integer = int = sayı olan değerler
            //double = float = ondalıklı sayı
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

          
            bool sistemeGirisYapildiMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun < dolarBugun)
                Console.WriteLine("Artış Butonu");

            else
            {
                Console.WriteLine("Eşittir Butonu");

            }

            if (sistemeGirisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
           
            Console.WriteLine(kategoriEtiketi);
            
        }


    }
}



