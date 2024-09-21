using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_en_kuçuk_değer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, Enküçük = 1500, yer = 0;
            String[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 23 };
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] <= Enküçük)
                {
                    Enküçük = B[c];
                    yer = c;
                }
            }
            Console.WriteLine("En düşük Not = " + Enküçük);
            Console.WriteLine("En düşük notu alan kişiler:");
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == Enküçük)
                {
                    Console.WriteLine(A[c]);
                }
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
