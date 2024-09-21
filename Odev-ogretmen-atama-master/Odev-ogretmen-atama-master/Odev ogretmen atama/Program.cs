using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_ogretmen_atama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7 farklı öğretmeni random seçip yine random seçilmiş 7 farklı şehre atamasını yapan program  */
            int sayi, a, sayi2;
            string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };
            bool[] D = new bool[7];
            bool[] F = new bool[7];


            Random rastgele = new Random();

            for (a = 0; a <= 6; a++)
            {
                do
                {
                    sayi = rastgele.Next(0, 7);

                } while (D[sayi] == true);
                D[sayi] = true;

                do
                {                     
                    sayi2 = rastgele.Next(0, 7);

                } while (F[sayi2] == true);           
                F[sayi2] = true;

                Console.WriteLine(isim[sayi2] + "\t= " + il[sayi]);
            }
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }

    }
}
