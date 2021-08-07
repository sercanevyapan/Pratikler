using arayuzler_ornek;
using System;
using System.Collections.Generic;
using System.Text;
namespace abstract_class
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
