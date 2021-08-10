namespace Console_ToDo_Uygulaması
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public Kisi(int id, string ad)
        {
            Id = id;
            Ad = ad;
        }

    }
}