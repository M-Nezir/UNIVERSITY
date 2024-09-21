using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Odev_burs__goto_label_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for/while/do -while ile yaptığınız tüm örnekleri bu kelimeleri kullanmadan goto-label kelimelerini kullanarak yapmaya çalışınız.
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 }; double b = 0; int d = -1;
        Label:
            
            d++;

            if (a[d] >= 500)
            {
                Console.WriteLine(a[d]);
            }

            if (a[d] < 500)
            {
                b = (a[d] * 0.1) + a[d];
                b = b + 50;
                Console.WriteLine(b);

                int s = Array.IndexOf(a, a[d]);
                a.SetValue(b, s);
            }

            if (d != 9)
            {
                goto Label;
            }
            

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);

        }
    }
}
