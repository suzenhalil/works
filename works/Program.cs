using System;

namespace works
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru

            //miktar al
            //20 den küçükse toplamdan %5
            //20-50 %10
            //50-100 %15
            //100 den fazla %25
            //birim fiyat 5 tl
            //ödenecek tutar

            //int Adet;
            //double Tutar;
            //Console.WriteLine("Miktarı Giriniz.");
            //Adet = Convert.ToInt32(Console.ReadLine());
            //if (Adet < 20)
            //{
            //    Tutar = (Adet * 5) * 0.95;
            //    Console.WriteLine("Ödemeniz gereken miktar: " + Tutar);

            //}
            //else if (Adet >= 20 && Adet < 50)
            //{
            //    Tutar = (Adet * 5) * 0.9;
            //    Console.WriteLine("Ödemeniz gereken miktar: " + Tutar);
            //}
            //else if (Adet >= 50 && Adet < 100)
            //{
            //    Tutar = (Adet * 5) * 0.85;
            //    Console.WriteLine("Ödemeniz gereken miktar: " + Tutar);
            //}
            //else if (Adet >= 100)
            //{
            //    Tutar = (Adet * 5) * 0.75;
            //    Console.WriteLine("Ödemeniz gereken miktar: " + Tutar);
            //}


            #endregion

            #region Soru 1

            //2 sayı al
            //işlem al ve yap

            //int sayi1, sayi2;
            //string islem;
            //double sonuc;

            //Console.WriteLine("1. Sayı Giriniz.");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. Sayı Giriniz.");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İslem Seçiniz(+,-,*,/)");
            //islem = Console.ReadLine();
            //if ( islem =="+" )
            //{
            //    sonuc = sayi1 + (float)sayi2;
            //    Console.WriteLine("İşlem sonucu= " + sonuc);

            //}
            //else if ( islem =="-" )
            //{
            //    sonuc = sayi1 - (float)sayi2;
            //    Console.WriteLine("İşlem sonucu= " + sonuc);

            //}
            //else if (islem == "*")
            //{
            //    sonuc = sayi1 * (float)sayi2;
            //    Console.WriteLine("İşlem sonucu= " + sonuc);

            //}
            //else if (islem == "/")
            //{
            //    sonuc = sayi1 / (float)sayi2;
            //    Console.WriteLine("İşlem sonucu= " + sonuc);

            //    if (sayi2 ==0)
            //    {
            //        Console.WriteLine("Bölen Sayı '0' olamaz.");
            //    }

            //}


            #endregion

            #region Soru 2

            //mevsime göre ayları bastır
            //string Secim;
            //Console.WriteLine("Bir mevsim seçiniz.");
            //Secim = Console.ReadLine();
            //if (Secim == "İlkbahar")
            //{
            //    Console.WriteLine("İlkbahar Ayları==> Mart, Nisan, Mayıs.");
            //}
            //else if (Secim == "Yaz")
            //{
            //    Console.WriteLine("Yaz Ayları==> Haziran, Temmuz, Ağustos.");
            //}
            //else if (Secim == "Sonbahar")
            //{
            //    Console.WriteLine("Sonbahar Ayları==> Eylül, Ekim, Kasım.");
            //}
            //else if (Secim == "Kış")
            //{
            //    Console.WriteLine("Kış Ayları==> Aralık, Ocak, Şubat.");
            //}
            //else if (Secim != "İlkbahar" || Secim == "Yaz" || Secim == "Sonbahar" || Secim == "Kış")
            //{
            //    Console.WriteLine("Düzgün yazın lütfen");
            //}
            #endregion

            #region Soru 3

            //girilen bi tam sayının kaç basamaklı olduğunu yazdır.

            //Console.Write("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;
            //int sonuc;

            //while (sayi > 0)

            //{
            //    sayi /= 10;
            //    sayac++;

            //}
            //Console.WriteLine("Girdiginiz sayi " + sayac + " basamaklıdır.");



            #endregion
        }
    }
}
