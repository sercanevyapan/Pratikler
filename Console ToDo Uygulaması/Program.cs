using System;

namespace Console_ToDo_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" (1) Board Listelemek");
            Console.WriteLine(" (2) Board'a Kart Eklemek");
            Console.WriteLine(" (3) Board'dan Kart Silmek");
            Console.WriteLine(" (4) Kart Taşımak");

            Console.WriteLine("Başlık Giriniz                                  : ");
            var baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            var icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            var buyukluk = Console.ReadLine();
            Console.WriteLine("Kişi Seçiniz                                    : ");
            var kisi = Console.ReadLine();


            var yeniKisi = new Kisi(1, "Takım Üyesi1", "Developer");
            rehber.KisiEkle(yeniKisi);

        }
    }
}
