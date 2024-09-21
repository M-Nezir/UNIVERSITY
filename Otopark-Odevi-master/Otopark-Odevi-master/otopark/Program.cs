using System;
using System.Runtime.ConstrainedExecution;

namespace otopark
{
    class Program
    {

        /* Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
 Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
 İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit
        */
        static void Main(string[] args)
        {
           
                Console.WriteLine("arac türünü giriniz otomobil için=1 /kamyon için=2 /iş makinası için=3");
                int aracturu = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("kac saat kalmak istiyorsunuz:");
                double kullanımsuresı = Convert.ToDouble(Console.ReadLine());

                double ucret;

                switch (aracturu)
                {

                    //    Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
                    case 1:
                        if (kullanımsuresı <= 2)
                        {
                            ucret = 5;
                        }
                        else if (kullanımsuresı <= 10)
                        {
                            ucret = 5 + (kullanımsuresı - 2) * 1;
                        }
                        else
                        {//sabıt ucret 13
                            int gun = (int)kullanımsuresı / 24;
                            double saat = kullanımsuresı % 24;
                            ucret = (gun * 13) + 5 + (saat - 2) * 1;
                        }

                        break;


                    case 2:
                        //Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
                        if (kullanımsuresı <= 2)
                        {
                            ucret = 8;
                        }
                        else if (kullanımsuresı <= 8)
                        {
                            ucret = 8 + (kullanımsuresı - 2) * 2;
                        }
                        else
                        {
                            int gun = (int)kullanımsuresı / 24;
                            double saat = kullanımsuresı % 24;
                            ucret = (gun * 20) + 8 + (saat - 2) * 2;
                        }
                        break;



                    // İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit ücret
                    case 3:

                        if (kullanımsuresı <= 2)
                        {
                            ucret = 12;
                        }
                        else if (kullanımsuresı <= 8)
                        {
                            ucret = 12 + (kullanımsuresı - 2) * 3;
                        }
                        else
                        {
                            int gun = (int)kullanımsuresı / 24;
                            double saat = kullanımsuresı % 24;
                            ucret = (gun * 30) + 12 + (saat - 2) * 3;
                        }


                        break;



                    default:
                        Console.WriteLine("yanlış değer girdiniz lütfen tekrar deneyiniz");
                        Console.WriteLine();
                        return;




                }



                Console.Write("Ücretiniz: " + ucret + " TL");
                Console.ReadKey();


        }
    }
}