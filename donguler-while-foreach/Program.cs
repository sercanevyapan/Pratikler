using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak console dan girilen sayıya kadar ortalama hesapla
            Console.Write("Bİr sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            //'a' dan 'z' ye kadar tüm harfleri yazdır

            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.Write("Foreach");
            string[] arabalar = { "BMV", "FOrd", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
