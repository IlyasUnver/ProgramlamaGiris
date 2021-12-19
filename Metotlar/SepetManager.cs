using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi" + " "+ urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama + " " + urun.stokAdedi);
        }
            //public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
            //Console.WriteLine("Sepete eklendi" + urunAdi);
    }
} 
