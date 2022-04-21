using System;

namespace Sansoyunları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deneme = 0;
            Console.WriteLine("Deneme sayısı girinz.");
            deneme = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] yaziTura = new int[deneme];
            for (int i = 0; i < deneme; i++)
            {
                yaziTura[i] = rnd.Next(2);
            }
            int yazi = 0, tura = 0;

            for (int i = 0; i < deneme; i++)
            {
                if (yaziTura[i] == 0)
                    yazi = yazi + 1;
                else
                    tura = tura + 1;
                
            }
            Console.WriteLine("Tura: " + tura);
            Console.WriteLine("Yazi: " + yazi);
        }
    }
}
