﻿using System;

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

            //int a = 1, b = 5;
            //Console.WriteLine("Bir sayı giriniz.");
            //b = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    a = a * b;
            //    b--;
            //} while (b > 0);
            //Console.WriteLine(a);


            #endregion

            #region Fordongusu
            //Console.WriteLine("Bir sayı giriniz");

            //for (int i = Convert.ToInt32(Console.ReadLine()); i <= 1000; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Örnek 1

            //1 ile 10 arasındaki çift sayıları yazdır mod kullanmadan


            #endregion

            #region Örnek 2

            //1 ile 10 arasındak tek sayıları tersten yazdır
            //for (int i = 9; i > 0; i--)
            //    {
            //    Console.WriteLine(i);

            //    }

            #endregion

            #region Örnek 3

            //ayın ilk gün pazartesi
            //pazarları basın 1 aylık

            //for (int i = 7; i < 30; i = i + 7)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 30; i++)
            //{
            //    if (i % 7 == 0)
            //        Console.WriteLine(i);

            //}

            #endregion

            #region Örnek 4

            //for (char a = 'A'; a <= 'Z'; a++)
            //{
            //    Console.WriteLine(a + "-" + Convert.ToInt32(a));
            //}

            #endregion

            #region Örnek 5

            //for (int i = 2010 ; i <= DateTime.Now.Year; i++)
            //{

            //    if (i == 2020 || i == 2021)

            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Örnek 6

            //1-100 3 ve 4 ün

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 12 != 0)
            //        continue;
            //    else
            //        Console.WriteLine(i);

                
            //}

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    break;

            }

            #endregion


        }
    }
}
