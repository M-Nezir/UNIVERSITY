using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_asal_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // b değerinin asal sayı olup olmadığını bulan program!
            //ÖDEV: Aşağıdaki örneği b değeri kullanıcı tarafından girilecek şekilde düzenleyiniz.

            Console.WriteLine("lütfen bir sayı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            String s = "girdiğiniz Sayı Asal Sayı";
            if (b == 1) { Console.WriteLine("ASAL DEĞİL!"); goto bitir; }
            for (int a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "girdiğiniz Sayı Asal Sayı Değil!";
                    break;
                }
            }
            Console.WriteLine(s);
        bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);


        }
    }
}








