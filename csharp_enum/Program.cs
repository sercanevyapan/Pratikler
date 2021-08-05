using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 25;

            if (sıcaklık <= (int)Havadurumu.Normal)
                Console.WriteLine("Dışarıta çıkmak için havanın ısınmasını bekle");
            else if (sıcaklık >= (int)Havadurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sıcaklık>=(int) Havadurumu.Normal && sıcaklık<(int)Havadurumu.CokSıcak)
                Console.WriteLine("Dışarıya çıkalım");

        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum Havadurumu
    {
        Soguk =5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 38
    }
}
