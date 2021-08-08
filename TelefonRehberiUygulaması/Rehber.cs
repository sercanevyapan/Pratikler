using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelefonRehberiUygulaması
{
    class Rehber
    {
        public List<Kisi> kisilerim { get; set; } = new List<Kisi>();
        private void KisileriGoster(Kisi kisi)
        {
            Console.WriteLine($"Contact : {kisi.Ad}, {kisi.Soyad}, {kisi.TelNo}");
        }

        private void KisilerimiGoster(List<Kisi> kisilerim)
        {
            foreach (var kisi in kisilerim)
            {
                KisileriGoster(kisi);
            }
        }

        public void KisiEkle(Kisi kisi)
        {
            kisilerim.Add(kisi);
        }

        public void KisiGuncelleme(string ad,string soyad,string telNo)
        {
            var kisi = kisilerim.FirstOrDefault();
            if (kisi != null)
            {
                kisi.Ad = ad;
                kisi.Soyad = soyad;
                kisi.TelNo = telNo;
            }
        }

        public void KisiAramaTelNo(string telno)
        {
            var kisi = kisilerim.FirstOrDefault(n => n.TelNo == telno);

            if (telno == null)
            {
                Console.WriteLine("Kişi Bulunamadı");
            }
            else
            {
                KisileriGoster(kisi);
            }
        }

        public bool KisiAramaAd(string ad)
        {
            var kisi = kisilerim.FirstOrDefault(n => n.Ad == ad);

            if (ad == null)
            {
                Console.WriteLine("Kişi Bulunamadı");
                return false;
            }
            else
            {
                
                return true;
            }

            
        }

        public void KisiSil(string ad)
        {
            var kisi = kisilerim.FirstOrDefault(n => n.Ad == ad);
            kisilerim.Remove(kisi);
        }





        public void TumKisilerim()
        {
            KisilerimiGoster(kisilerim);
        }

        public void AdaGoreKisilerim(string arananKelime)
        {
            var eslesenKisilerim = kisilerim.Where(k => k.Ad.Contains(arananKelime)).ToList();
            KisilerimiGoster(eslesenKisilerim);

        }

        public void TelefonaGoreKisilerim(string arananTel)
        {
            var eslesenKisilerim = kisilerim.Where(k => k.TelNo.Contains(arananTel)).ToList();
            KisilerimiGoster(eslesenKisilerim);

        }
    }
}
