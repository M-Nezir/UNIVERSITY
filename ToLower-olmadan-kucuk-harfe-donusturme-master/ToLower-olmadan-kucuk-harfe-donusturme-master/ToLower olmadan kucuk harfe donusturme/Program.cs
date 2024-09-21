using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLower_olmadan_kucuk_harfe_donusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //büyük harfleri küçük harfe döndüren program
            string s, ys = ""; int a; byte c;
            Console.Write("Bir cümle giriniz:");
            s = Console.ReadLine();
            for (a = 0; a < s.Length; a++)
            {
                c = (byte)s[a];
                if (c >= 65 && c <= 90) 
                    ys = ys + (char)(c + 32);
                else ys = ys + s[a];
            }
            Console.WriteLine(ys);
            Console.WriteLine("\n\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
