using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tumSayilar = new List<int>(20);
            List<int> kucukSayilar = new List<int>(3);
            List<int> buyukSayilar = new List<int>(3);

            int kucukSayilarToplam=0;
            int kucukSayilarOrtalama;

            int buyukSayilarToplam = 0;
            int buyukSayilarOrtalama;

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    var girilenSayi = Int32.Parse(Console.ReadLine());


                    tumSayilar.Add(girilenSayi);
                }
                catch (Exception)
                {

                    Console.WriteLine("Geçersiz format");
                }
                tumSayilar.Sort();

            }
            Console.WriteLine("Küçük sayılar");
                kucukSayilar.Add(tumSayilar[0]);
                kucukSayilar.Add(tumSayilar[1]);
                kucukSayilar.Add(tumSayilar[2]);

            Console.WriteLine("Büyük sayılar");
            buyukSayilar.Add(tumSayilar[17]);
            buyukSayilar.Add(tumSayilar[18]);
            buyukSayilar.Add(tumSayilar[19]);

            for (int i = 0; i < kucukSayilar.Count; i++)
            {
                kucukSayilarToplam += kucukSayilar[i];
            }

            kucukSayilarOrtalama = kucukSayilarToplam / kucukSayilar.Count;
            Console.WriteLine("Küçük sayılar ortalama");
            Console.WriteLine(kucukSayilarOrtalama);

            for (int i = 0; i < buyukSayilar.Count; i++)
            {
                buyukSayilarToplam += buyukSayilar[i];
            }

            buyukSayilarOrtalama = buyukSayilarToplam / buyukSayilar.Count;
            Console.WriteLine("Büyük sayılar ortalama");
            Console.WriteLine(buyukSayilarOrtalama);

            Console.WriteLine("Ortalama toplamları");
            Console.WriteLine(kucukSayilarOrtalama + buyukSayilarOrtalama);





            //foreach (var item in kucukSayilar)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
