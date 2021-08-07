using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());
        }
    }
}
