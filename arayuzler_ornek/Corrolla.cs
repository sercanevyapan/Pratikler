using System;
using System.Collections.Generic;
using System.Text;

namespace arayuzler_ornek
{
    public class Corrolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
           return Renk.Beyaz;
        }
    }
}
