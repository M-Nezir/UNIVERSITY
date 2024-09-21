using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_siralama_algoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, gecici, EnbuyukYer;
            int[] A = { 78, 56, 23, 95, 68, 87, 61, 77, 45, 33 };
            for (i = 0; i <= A.Length - 1; i++)
            {
                EnbuyukYer = i;
                for (j = i + 1; j <= A.Length - 1; j++)
                {
                    if (A[j] > A[EnbuyukYer])
                    {
                        EnbuyukYer = j;

                    }
                }
                gecici = A[i];
                A[i] = A[EnbuyukYer];
                A[EnbuyukYer] = gecici;
                Console.WriteLine(A[i]);
            }
            Console.Write("Press any key to continue . . . "); Console.ReadKey(true);
            // ÖDEV: Programı, diziyi büyükten küçüğe yerleştirecek şekilde yeniden yazınız.
        }
    }
}
