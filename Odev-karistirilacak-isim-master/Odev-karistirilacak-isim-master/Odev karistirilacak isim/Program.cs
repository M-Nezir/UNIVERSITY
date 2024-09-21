using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_karistirilacak_isim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bu program girdiğiniz ismin harflerini karıştırıp ekrana yazdırıyor 
            Console.Write("lütfen isim giriniz: ");
            string ad = Convert.ToString(Console.ReadLine());

            int sayi;
            char[] isim = ad.ToCharArray();
            bool[] D = new bool[isim.Length];

            Random rastgele = new Random();
            for (int a = 0; a <= isim.Length; a++)
            {
                do
                {
                    sayi = rastgele.Next(isim.Length);
                } while (D[sayi] == true);
                D[sayi] = true;

                Console.Write(isim[sayi]);
            }
            Console.Write("\n\n\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
