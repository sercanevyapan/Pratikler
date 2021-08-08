using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulaması
{
    public class Kisi
    {
        public Kisi(string ad, string soyad, string telno)
        {

            Ad = ad;
            Soyad = soyad;
            TelNo = telno;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
    }
}
