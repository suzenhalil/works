using System;

namespace Sansoyunları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazıTura
            //int deneme = 0;
            //Console.WriteLine("Deneme sayısı girinz.");
            //deneme = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int[] yaziTura = new int[deneme];
            //for (int i = 0; i < deneme; i++)
            //{
            //    yaziTura[i] = rnd.Next(2);
            //}
            //int yazi = 0, tura = 0;

            //for (int i = 0; i < deneme; i++)
            //{
            //    if (yaziTura[i] == 0)
            //        yazi = yazi + 1;
            //    else
            //        tura = tura + 1;

            //}
            //Console.WriteLine("Tura: " + tura);
            //Console.WriteLine("Yazi: " + yazi);
            #endregion

            #region Zar

            //int deneme = 0;
            //Console.WriteLine("Deneme sayısı girinz.");
            //deneme = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int[] zaryuz = new int[deneme];
            //for (int i = 0; i < deneme; i++)
            //{
            //    zaryuz[i] = rnd.Next(6);
            //}
            //int bir = 0, iki = 0, uc = 0, dort = 0, bes = 0, alti = 0;

            //for (int i = 0; i < deneme; i++)
            //{
            //    if (zaryuz[i] == 0)
            //        bir = bir + 1;
            //    else if (zaryuz[i] == 1)
            //        iki = iki + 1;
            //    else if (zaryuz[i] == 2)
            //        uc = uc + 1;
            //    else if (zaryuz[i] == 3)
            //        dort = dort + 1;
            //    else if (zaryuz[i] == 4)
            //        bes = bes + 1;
            //    else if (zaryuz[i] == 5)
            //        alti = alti + 1;
            //}
            //Console.WriteLine("1 gelme ihtimali: " + bir);
            //Console.WriteLine("2 gelme ihtimali: " + iki);
            //Console.WriteLine("3 gelme ihtimali: " + uc);
            //Console.WriteLine("4 gelme ihtimali: " + dort);
            //Console.WriteLine("5 gelme ihtimali: " + bes);
            //Console.WriteLine("6 gelme ihtimali: " + alti);


            #endregion

            #region Basketbol

            int deneme = 150;
            byte[] Fenerbahce = new byte[deneme];
            byte[] Galatasaray = new byte[deneme];

            Random rand = new Random();

            for (int i = 0; i < deneme; i++)
            {
                Fenerbahce[i] = (byte)rand.Next(4);
                Galatasaray[i] = (byte)rand.Next(4);
            }
            int bos = 0, serbest = 0, ikilik = 0, ucluk = 0, toplam = 0;
            int gsbos = 0, gsserbest = 0, gsikilik = 0, gsucluk = 0, gstoplam = 0;

            for (int i = 0; i < deneme; i++)
            {
                switch (Fenerbahce[i])
                {
                    case 0:
                        bos = bos + 1;
                        break;
                    case 1:
                        serbest = serbest + 1;
                        break;
                    case 2:
                        ikilik = ikilik + 1;
                        break;
                    case 3:
                        ucluk = ucluk + 1;
                        break;

                }
                switch (Galatasaray[i])
                {
                    case 1:
                        gsbos = gsbos + 1;
                        break;
                    case 2:
                        gsikilik = gsikilik + 1;
                        break;
                    case 3:
                        gsucluk = ucluk + 1;
                        break;

                }
            }
            toplam = serbest + (ikilik * 2) + (ucluk * 3);
            gstoplam = gsserbest + (gsikilik * 2) + (gsucluk * 3);

            Console.WriteLine("Fenerbahçe= " + toplam);
            Console.WriteLine("Galatasaray= " + gstoplam);


            #endregion
        }
    }
}
