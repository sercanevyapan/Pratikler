using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";


            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 4, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Sercan", "Evyapan");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
