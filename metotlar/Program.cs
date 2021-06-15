using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
           // Console.WriteLine(a+b);

           int sonuc = Topla(a,b);
           //Console.WriteLine(sonuc);

           Metotlar ornek = new Metotlar();
           ornek.EkranaYazdır(sonuc.ToString());

           int sonuc2 = ornek.ArttırTopla(ref a, ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(String veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1 + deger2;
        }

    }
}
