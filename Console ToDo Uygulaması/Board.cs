using System;
using System.Collections.Generic;
using System.Text;

namespace Console_ToDo_Uygulaması
{
    public class Board
    {
        public List<Card> todo { get; set; } = new List<Card>();
        public List<Card> inprogress { get; set; } = new List<Card>();
        public List<Card> done { get; set; } = new List<Card>();



        public void KartEkle(Card card)
        {
            todo.Add(card);
        }
    }
}
