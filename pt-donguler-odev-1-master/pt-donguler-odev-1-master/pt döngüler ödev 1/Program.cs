using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_döngüler_ödev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                Console.WriteLine("Lütfen toplamak istediğiniz her bir sayıyı girdikten sonra enter'ı tuşlayınız(bitirmek için 83 yazıp enter'ı tuşlayın)");

                int toplam = 0, b = 0;

                for (; ; )
                {
                    Console.WriteLine("bir sayı giriniz: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a == 83)
                    {
                        Console.WriteLine("yazdığınız sayıların toplamı : " + toplam);
                        break;
                    }

                    b = toplam + a;
                    toplam = b;

                }
                Console.WriteLine("tekrar işlem yapmak için lütfen e harfini tuşlayınız (çıkmak için enter)");
                string tekrar = Convert.ToString(Console.ReadLine());
                if (tekrar.ToLower() != "e")

                {
                    break;
                }
            }
        }
    }
}
