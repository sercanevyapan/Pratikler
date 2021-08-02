using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> tumSayilar = new List<int>();
            List<int> asalOlmayanSayilar = new List<int>();
            List<int> asalSayilar = new List<int>();
            List<int> gecerliSayilar = new List<int>();

            for (int i = 1; i < 21; i++)
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
              
            }

            for (int i = 0; i < tumSayilar.Count; i++)
            {
                
                var isNumeric = int.TryParse(tumSayilar[0].ToString(), out _);

                try
                {
                    if (isNumeric&&Convert.ToInt32( tumSayilar[i])>0)
                    {
                        gecerliSayilar.Add(tumSayilar[i]);
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Geçersiz format");
                }

            }

            for (int i = 0; i < gecerliSayilar.Count; i++)
            {
                if (isPrime(gecerliSayilar[i])){
               
                    asalSayilar.Add(gecerliSayilar[i]);
                }
                else
                {
             
                    asalOlmayanSayilar.Add(gecerliSayilar[i]);
                }
            }

               asalSayilar.Sort();
            asalOlmayanSayilar.Sort();

            Console.WriteLine("Asal sayılar");
            foreach (var item in asalSayilar)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olmayan sayılar");
            foreach (var item in asalOlmayanSayilar)
            {
                
                Console.WriteLine(item);
            }


        }

        private static bool isPrime(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
