using arayuzler_ornek;
using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }
        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkaninAraci();
       
    }
}
