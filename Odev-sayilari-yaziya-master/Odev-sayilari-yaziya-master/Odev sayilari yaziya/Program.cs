using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_sayilari_yaziya
{
    internal class Program
    {
        static void Main(string[] args)
        {
        title:
            int a;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] yüzler = { "Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "Yediyüz", "Sekizyüz", "Dokuzyüz" };

            Console.Write("Bir Sayı Giriniz: ");
            a = int.Parse(Console.ReadLine());

            if (a / 100 >= 1 && a < 1000)
            {
                s = yüzler[(a / 100) - 1];
                a = a - ((a / 100) * 100);
            }

            if (a / 10 >= 1 && a < 1000)
            {
                s = s + Onlar[(a / 10) - 1];

            }


            if (a % 10 != 0 && a < 1000)
            {
                s = s + Birler[(a % 10) - 1];
            }

            if (a > 999)
            {
                Console.WriteLine("yeniden deneyiniz 1-999: ");
                goto title;
            }

            Console.WriteLine(s);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}
