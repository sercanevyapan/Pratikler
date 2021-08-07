using arayuzler_ornek;
using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
    }
}
