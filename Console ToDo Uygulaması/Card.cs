using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ToDo_Uygulaması
{
    public class Card
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public int KisiID { get; set; }

        public Buyukluk Buyukluk { get; set; }

        public LineType LineType { get; set; }

        public Card()
        {

        }

        public Card(string baslik, string icerik, int kisiID, Buyukluk buyukluk)
        {
            Baslik = baslik;
            Icerik = icerik;
            KisiID = kisiID;
            Buyukluk = buyukluk;
        }

      
    }
}
