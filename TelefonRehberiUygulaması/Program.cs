using System;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" (1) Yeni Numara Kaydetmek");
            Console.WriteLine(" (2) Varolan Numarayı Silmek");
            Console.WriteLine(" (3) Varolan Numarayı Güncelleme");
            Console.WriteLine(" (4) Rehberi Listelemek");
            Console.WriteLine(" (5) Rehberde Arama Yapmak");

            var kullaniciGirisi = Console.ReadLine();

            var rehber = new Rehber();

            while (true)
            {
                switch (kullaniciGirisi)
                {
                    case "1":
                        Console.WriteLine("Lütfen isim giriniz             : ");
                        var ad = Console.ReadLine();
                        Console.WriteLine("Lütfen soyisim giriniz          :");
                        var soyad = Console.ReadLine();
                        Console.WriteLine("Lütfen telefon numarası giriniz :");
                        var numara = Console.ReadLine();

                        var yeniKisi = new Kisi(ad, soyad, numara);
                        rehber.KisiEkle(yeniKisi);


                        break;
                    case "2":
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        var kullaniciGirisiSilmek = Console.ReadLine();

                        if (rehber.KisiAramaAd(kullaniciGirisiSilmek))
                        {
                            Console.WriteLine("Silmek istediğinizden emin mmisiniz?");
                            var eminMi = Console.ReadLine();
                            if (eminMi == "y" || eminMi == "Y")
                            {
                                Console.WriteLine("Kişi silindi");
                                rehber.KisiSil(kullaniciGirisiSilmek);
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Yeniden denemek için      : (2)");
                            kullaniciGirisi = Console.ReadLine();
                        }
                      
                        break;
                    case "3":
                        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                        var adGuncelleme = Console.ReadLine();
                        if (rehber.KisiAramaAd(adGuncelleme))
                        {
                            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin güncel adını giriniz:");
                            var kullaniciGirisiAd = Console.ReadLine();
                            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin güncel soyadını giriniz:");
                            var kullaniciGirisiSoyAd = Console.ReadLine();
                            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin güncel telefonunu giriniz:");
                            var kullaniciGirisiTel = Console.ReadLine();
                            rehber.KisiGuncelleme(kullaniciGirisiAd,kullaniciGirisiSoyAd,kullaniciGirisiTel);
                        }
                        
                        break;
                    case "4":
                        rehber.TumKisilerim();


                        break;
                    case "5":
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                        

                        var kullaniciGirisiArama = Console.ReadLine();

                        if (kullaniciGirisiArama == "1")
                        {
                            Console.WriteLine("Ad giriniz");
                            var kullanıcıadi = Console.ReadLine();
                            rehber.AdaGoreKisilerim(kullanıcıadi);


                        }
                        else if(kullaniciGirisiArama == "2")
                        {
                            Console.WriteLine("No giriniz");
                            var kullanıcıno = Console.ReadLine();
                            rehber.TelefonaGoreKisilerim(kullanıcıno);
                        }

                       

                        break;
                    default:
                        Console.WriteLine("Geçerli bir sayı giriniz");
                        break;
                }
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                kullaniciGirisi = Console.ReadLine();
            }


        }
    }
}
