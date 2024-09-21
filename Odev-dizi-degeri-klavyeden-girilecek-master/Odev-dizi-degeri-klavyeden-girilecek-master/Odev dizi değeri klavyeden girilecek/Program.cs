using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_dizi_değeri_klavyeden_girilecek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //bu program girdiğiniz ilk sayıya en yakın sayıyı gösterir 

            Console.WriteLine("kaç adet sayı girmek istersiniz ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int a, e = 1;
            int[] B = new int[adet];
            for (int s =0 ;s < adet ;s++ )
            {
                Console.WriteLine($"lütfen {s+1}. sayıyı giriniz ");
                B[s] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (a = 2; a < adet; a++)
            {
                if (Math.Abs(B[0] - B[a]) < Math.Abs(B[0] - B[e])) e = a;
            }

            Console.WriteLine("İlk Sayıya En Yakın Sayı = " + B[e]);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
