using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Bosaltım()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }
}
