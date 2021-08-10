using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ToDo_Uygulaması
{
    public  class CardManager
    {
     
        public  void BoardList(List<Card> cardList, List<Card> ToDo, List<Card> InProgress, List<Card> Done)
        {
            ToDo.Clear();
            InProgress.Clear();
            Done.Clear();

            foreach (var item in cardList)
            {
                if (item.LineType.Equals(LineType.ToDo))
                {
                    ToDo.Add(item);
                }
                if (item.LineType.Equals(LineType.InProgress))
                {
                    ToDo.Add(item);
                }
                if (item.LineType.Equals(LineType.Done))
                {
                    ToDo.Add(item);
                }
            }

            Console.WriteLine("TO*DO Line");
            Console.WriteLine("************************");
            if (ToDo.Count == 0)
            {
                Console.WriteLine("The board list is empty!");
            }
            else
            {
                foreach (var item in ToDo)
                {
                    Console.WriteLine("Title      :{0}", item.Baslik);
                    Console.WriteLine("Content    :{0}", item.Icerik);
                    Console.WriteLine("Assigned to:{0}", item.KisiID);
                    Console.WriteLine("Size       :{0}", item.Buyukluk);
                 
                }
            }

            if (InProgress.Count == 0)
            {
                Console.WriteLine("The board list is empty!");
            }
            else
            {
                foreach (var item in InProgress)
                {
                    Console.WriteLine("Title      :{0}", item.Baslik);
                    Console.WriteLine("Content    :{0}", item.Icerik);
                    Console.WriteLine("Assigned to:{0}", item.KisiID);
                    Console.WriteLine("Size       :{0}", item.Buyukluk);

                }
            }

            if (Done.Count == 0)
            {
                Console.WriteLine("The board list is empty!");
            }
            else
            {
                foreach (var item in Done)
                {
                    Console.WriteLine("Title      :{0}", item.Baslik);
                    Console.WriteLine("Content    :{0}", item.Icerik);
                    Console.WriteLine("Assigned to:{0}", item.KisiID);
                    Console.WriteLine("Size       :{0}", item.Buyukluk);

                }
            }

        }

       

        public void CardEkle(List<Card> cardList, List<Kisi> kisiList)
        {
            Card card = new Card();
            Console.WriteLine("Başlık Giriniz                                  : ");
            string baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            string icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            var buyukluk = (Buyukluk)int.Parse (Console.ReadLine());
            Console.WriteLine("Kişi Seçiniz(id giriniz)                        :");
            int kisi_id = int.Parse(Console.ReadLine());

            int sayac = 0;

            foreach (var kisi in kisiList)
            {
                if(kisi.Id == kisi_id)
                {
                    cardList.Add(new Card(baslik, icerik, kisi_id, buyukluk));
                    sayac++;
                }
            }

            if (sayac == 0)
            {
                Console.WriteLine("Yanlış giriş yaptınız.");
            }
        }

        public void CardCikar(List<Card> cardList)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");

            string kartBasligi = Console.ReadLine();

            int sayac = 0;

            foreach (var item in cardList)
            {
                if(item.Baslik.ToLower()== kartBasligi.ToLower())
                {
                    cardList.Remove(item);
                    Console.WriteLine("Kart silindi.");
                    sayac++;
                    break;
                }
            }
        }


        public void CardTasi(List<Card> cardList)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");

            string baslik = Console.ReadLine();

            foreach (var item in cardList)
            {
                Console.WriteLine(" Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");

                Console.WriteLine("Başlık      :{0}", item.Baslik);
                Console.WriteLine("İçerik      :{0}", item.Icerik);
                Console.WriteLine("Atanan Kişi :{0}", item.KisiID);
                Console.WriteLine("Büyüklük    :{0}", item.Buyukluk);
                Console.WriteLine("Line        :");

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                int secim = int.Parse(Console.ReadLine());

                if(secim == 1)
                {
                    item.LineType = LineType.ToDo;
                }else if (secim == 2)
                {
                    item.LineType = LineType.InProgress;
                }else if(secim == 3)
                {
                    item.LineType = LineType.Done;
                }
                else
                {
                    Console.WriteLine("Yanlış bir değer girdiniz.");
                }
                Console.WriteLine("Taşıma işlemi başarıyle sonuçlandı.");
            }
        }

        
        

    }
}
