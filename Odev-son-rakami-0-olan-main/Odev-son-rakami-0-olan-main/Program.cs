using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_son_rakami_0_olan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 elemanlı bir X dizisi içinde son rakamı sıfır olan kaç tane sayı olduğunu hesaplar 
            int[] B = new int[5];
            int a = 0, say = 0;
            double toplam = 0, newtoplam = 0;

            for (a = 0; a <= B.Length - 1; a++)
            {
                Console.Write((a + 1) + ". Elemanı Gir: ");
                B[a] = Int32.Parse(Console.ReadLine());

                if (B[a] % 10 == 0)
                {
                    say++;
                    newtoplam = B[a] + toplam;
                    toplam = newtoplam;
                }
            }
            Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);
            Console.WriteLine($"son rakamı 0 olan sayıların toplamı: {toplam}");
            Console.WriteLine($"son rakamı 0 olan sayıların ortalaması {toplam / say}");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

            //ÖDEV: Yukarıdaki örneği son rakamı sıfır olan değerlerin toplamı ve ortalamasını da verecek şekilde yeniden yaz
        }
    }
}
