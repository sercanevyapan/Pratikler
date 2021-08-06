using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
        
            tohumluBitkiler.TohumlaCogalma();

            Kuslar martı = new Kuslar();
  
            martı.Ucmak();
        }
    }
}
