using System;
using System.Collections.Generic;

namespace algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Pozitif bir sayı girin: ");
            //var n = Convert.ToInt32(Console.ReadLine());


            //    List<int> ciftSayilar = new List<int>();
            //    for (int i = 0; i < n; i++)
            //    {
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        if (num % 2 == 0)
            //        {
            //            ciftSayilar.Add(num);
            //        }
            //    }

            //    foreach (var num in ciftSayilar)
            //    {
            //        Console.Write(num + " ");
            //    }


            //Console.Write("Pozitif bir sayı girin: ");
            //var n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Pozitif bir sayı girin: ");
            //var m = Convert.ToInt32(Console.ReadLine());


            //List<int> tamBolenSayilar = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num % m == 0 || num==m || m%num==0)
            //    {
            //        tamBolenSayilar.Add(num);
            //    }
            //}

            //foreach (var num in tamBolenSayilar)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.Write("Pozitif bir sayı girin: ");
            //var n = Convert.ToInt32(Console.ReadLine());


            //List<string> kelimeler = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    string kelimelerGiris = Convert.ToString(Console.ReadLine());
            //    var chars = kelimelerGiris.ToCharArray();
            //    Array.Reverse(chars);
            //    var reversedText = new String(chars);
            //    kelimeler.Add(reversedText);
            //}

            //foreach (var kelime in kelimeler)
            //{
            //    Console.Write(kelime + " ");
            //}

            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine();

            //int harfSayisi;
            string[] kelime =  cumle.Trim().Split(' ');
            Console.Write("Kelime sayısı: " + kelime.Length + " ");
            foreach (var harf in kelime)
            {
                Console.Write("Harf sayısı: " + harf.Length + " ");
            }

       

        }
    }
}
