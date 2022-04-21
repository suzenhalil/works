using System;

namespace Dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizi
            string[] siniftakiler = { "ali", "veli", "ayse", "faatma" };
            int[] vize1 = { 30, 40, 50, 35 };
            int[] vize2 = { 50, 40, 45, 50 };
            int[] final = { 50, 55, 60, 50 };
            vize2[2] = 55;
            Console.WriteLine(siniftakiler[2]);
            Console.WriteLine(vize1[2]);
            Console.WriteLine(vize2[2]);
            Console.WriteLine(final[2]);


            foreach (string ogrenci in siniftakiler)
            {
                Console.WriteLine(ogrenci);
            }
            for (int i = 0; i < siniftakiler.Length; i++)
            {
                Console.WriteLine(siniftakiler[i]);

            }
            int sayac = 0;
            while (sayac < siniftakiler.Length)
            {
                Console.WriteLine(siniftakiler[sayac]);
                sayac++;
            }
            #endregion
        }
    }
}
