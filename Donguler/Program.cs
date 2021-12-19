namespace kampIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            //Array * liste

            string[] kurslar = new string[] { "Programlamaya giriş","Programlama","Dövüsmen Guzum" };
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
