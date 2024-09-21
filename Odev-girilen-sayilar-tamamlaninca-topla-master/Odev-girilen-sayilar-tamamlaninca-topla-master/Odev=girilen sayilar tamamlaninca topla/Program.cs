using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_girilen_sayilar_tamamlaninca_topla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu program kullanıcıdan kaç tane sayı girmek istediğini sorar.
//istenilen adette sayı girilince bunların hem toplamını hem ortalamasını yazar.

 Console.WriteLine("kaç adet sayıyı toplamak istersiniz: ");
 int adet = Convert.ToInt32(Console.ReadLine());

 double toplam = 0;
 for (int i = 1; adet >= i; i++)
 {
     Console.WriteLine($"lütfen toplamak istediğiniz sayılardan {i}. sayıyı giriniz:");
     int sayılar = Convert.ToInt32(Console.ReadLine());

     toplam = sayılar + toplam;                
 }
 
 Console.WriteLine($"yazdığınız sayıların toplamı: {toplam}");
 Console.WriteLine($"yazdığnız sayıların ortalaması: {toplam / adet}");

 Console.WriteLine("bitirmek için enter: ");
 Console.ReadLine();


        }
    }
}
