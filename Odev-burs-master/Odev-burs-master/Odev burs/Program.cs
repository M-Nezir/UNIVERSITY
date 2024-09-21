using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_burs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 }; double b = 0;

            foreach (double d in a)
            {
                if (d >= 500)
                {
                    Console.WriteLine(d);
                    continue;
                }
                b = (d * 0.1) + d;
                b = b + 50;
                Console.WriteLine(b);

                 int s = Array.IndexOf(a, d);
                 a.SetValue(b, s);
            }
            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);

            //ÖDEV: Örnek096’yı foreach ile yeniden yazınız.
        }
    }
}
