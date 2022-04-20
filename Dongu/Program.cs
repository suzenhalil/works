using System;

namespace Dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dongu

            //{
            int sayac = 0;
            //    int toplam = 0;
            //    while (sayac <= 100)
            //    {

            //        toplam = toplam + sayac;
            //        sayac++;

            //    }
            //    Console.WriteLine(toplam);


            //}
            #endregion

            #region Örnek

            //int tekToplam = 0, ciftToplam = 0;
            //while (sayac <= 100)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        ciftToplam += sayac;
            //    }
            //    else
            //    {
            //        tekToplam += sayac;
            //    }
            //    sayac++;
            //}
            //Console.WriteLine("tek:" + tekToplam);
            //Console.WriteLine("cift:" + ciftToplam);



            #endregion

            #region Do While(Faktoriyel)

            int a = 1, b = 5;
            Console.WriteLine("Bir sayı giriniz.");
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                a = a * b;
                b--;
            } while (b > 0);
            Console.WriteLine(a);


            #endregion



        }
    }
}
