using arayuzler_ornek;
using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}
