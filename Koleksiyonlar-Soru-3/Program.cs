using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = Console.ReadLine().ToLower();

            List<char> sesliHarfler = new List<char>();

            List<char> vowels = new List<char>() {'a','e','i','o','u' };

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    sesliHarfler.Add(sentence[i]);
                }
            }

            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }


        }
    }
}
