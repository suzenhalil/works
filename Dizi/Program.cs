using System;

namespace Dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizi
            //string[] siniftakiler = { "ali", "veli", "ayse", "faatma" };
            //int[] vize1 = { 30, 40, 50, 35 };
            //int[] vize2 = { 50, 40, 45, 50 };
            //int[] final = { 50, 55, 60, 50 };
            //vize2[2] = 55;
            //Console.WriteLine(siniftakiler[2]);
            //Console.WriteLine(vize1[2]);
            //Console.WriteLine(vize2[2]);
            //Console.WriteLine(final[2]);


            //foreach (string ogrenci in siniftakiler)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            //for (int i = 0; i < siniftakiler.Length; i++)
            //{
            //    Console.WriteLine(siniftakiler[i]);

            //}
            //int sayac = 0;
            //while (sayac < siniftakiler.Length)
            //{
            //    Console.WriteLine(siniftakiler[sayac]);
            //    sayac++;
            //}



            #endregion

            #region Örnek 1

            //1. Yol

            //float ort1=0, ort2=0;
            //foreach (int not in vize1)
            //{
            //    ort1 = (ort1+not);
            //}
            //ort1 = ort1 / 4;
            //foreach(int not in vize2)
            //{
            //    ort2 = (ort2 + not);
            //}
            //ort2 = ort2 / 4;

            //Console.WriteLine(ort1);
            //Console.WriteLine(ort2);

            //2.Yol

            //ort1 = 0;
            //ort2 = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    ort1 = (ort1+vize1[i]);
            //    ort2 = (ort2 + vize2[i]);
            //}
            //ort1 = ort1 / 4;
            //ort2 = ort2 / 4;

            //Console.WriteLine(ort1);
            //Console.WriteLine(ort2);

            //Console.WriteLine("------Kişi Bazlı------");
            //float ort1 = 0;

            //for (int i = 0; i < siniftakiler.Length; i++)
            //{
            //    ort1 = (vize1[i] + vize2[i]) / 2;
            //    Console.WriteLine(siniftakiler[i] + "=" + ort1);
            //}
            #endregion


        }
    }
}
