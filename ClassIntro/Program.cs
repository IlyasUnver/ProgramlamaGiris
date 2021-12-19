using System;

namespace kampIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            string adi = "ilyas";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmeni = "Ilyas Unver";
            kurs1.IzlenmeOrani = "145";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Python";
            kurs2.Egitmeni = "Mehmet";
            kurs2.IzlenmeOrani = "82";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Java";
            kurs3.Egitmeni = "Ahmet";
            kurs3.IzlenmeOrani = "1325";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "JavaScript";
            kurs4.Egitmeni = "Ali";
            kurs4.IzlenmeOrani = "324";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmeni + " : " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmeni { get; set; }
        public string IzlenmeOrani { get; set; }

    }
}
