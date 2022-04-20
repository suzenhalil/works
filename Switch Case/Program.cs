using System;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KullaniciAdi, KullaniciAdi1, Parola;
            Console.WriteLine("Kullanıcı Adı Giriniz.");
            KullaniciAdi = Console.ReadLine();
           

            Console.WriteLine("Parola Giriniz.");
            Parola = Console.ReadLine();
            
            switch (KullaniciAdi)
            {
                case "admin":
                    switch (Parola)
                    {
                        case "1234":
                            Console.WriteLine("Kullanıcı Adınız ve Parolanız Doğru.");
                            break;
                        default:
                            Console.WriteLine("Kullanıcı Adı doğru, şifre yanlış");
                            break;

                    }
                    break;

                default:
                    Console.WriteLine("Kullanıcı Adın yanlış.");
                    break;
            }

                        
                        

                  
              
            }
             
        }
    }

