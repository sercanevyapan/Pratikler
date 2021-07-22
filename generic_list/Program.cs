using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.collection.Generic
            // T-> object türündedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Forech ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var sayi in renkListesi)
            {
                Console.WriteLine(sayi);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");

            //Eleman ile index'e erişimi
            Console.WriteLine( renkListesi.BinarySearch("Turuncu"));

            //Dizi List'e çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temzileriz?
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kulllanici1 = new Kullanicilar();
            kulllanici1.Isim = "Ayşe";
            kulllanici1.Soyisim = "Yılmaz";
            kulllanici1.Yas = 26;

            Kullanicilar kulllanici2 = new Kullanicilar();
            kulllanici1.Isim = "Özcan";
            kulllanici1.Soyisim = "Çalışkan";
            kulllanici1.Yas = 26;

            kullaniciListesi.Add(kulllanici1);
            kullaniciListesi.Add(kulllanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar() { 
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas=24
            });

            foreach (var kullanıcı in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaş:" + kullanıcı.Yas);
            }



        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
