using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimUygulaması_TP114_Temel
{
    internal class AracGerecler
    {
        static public int SayiAl(string mesaj)
        {
            int sayi;

            do
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine(" Hatalı giriş yapıldı. Tekrar deneyin. ");
                }

            } while (true);

        }

        static public string YaziAl(string yazi, bool gerekli)
        {
            int sayi;

            do
            {
                Console.Write(yazi);
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    Console.WriteLine(" Hatalı işlem tekrar girin. ");
                }
                else if (gerekli && string.IsNullOrEmpty(giris))
                {
                    Console.WriteLine(" Veri girişi yapılamadı, tekrar deneyin. ");
                }
                else
                {
                    return giris;
                }

            } while (true);
        }

        static public DateTime TarihAl(string yazi)
        {
            DateTime tarih;
            do
            {
                Console.Write(yazi);
                string giris = Console.ReadLine();

                if (DateTime.TryParse(giris, out tarih))
                {
                    return tarih;
                }
                else
                {
                    Console.WriteLine(" Hatalı giriş yapıldı, tekrar deneyin. ");
                }

            } while (true);

        }

        static public DateTime TarihAlGuncelle(string yazi)
        {
            DateTime tarih2;
            do
            {
                Console.Write(yazi);
                string giris = Console.ReadLine();

                if (DateTime.TryParse(giris,out tarih2))
                {
                    return tarih2;
                }
                else
                {
                    return DateTime.MinValue;
                }

            } while (true);

        }

        static public CINSIYET KizMiErkekMi(string yazi)
        {
            do
            {
                Console.Write(yazi);
                string giris = Console.ReadLine();


                if (giris.ToUpper() == "K")
                {
                    return CINSIYET.Kiz;
                }
                else if (giris.ToUpper() == "E")
                {
                    return CINSIYET.Erkek;
                }
                else
                {
                    Console.WriteLine(" Hatalı giriş yapıldı, tekrar deneyin. ");
                }


            } while (true);
        }

        static public SUBE SubeAl(string yazi)
        {
            do
            {
                Console.Write(yazi);
                string giris = Console.ReadLine();

                

                if (giris.ToUpper() == "A")
                {
                    return SUBE.A;
                }
                else if (giris.ToUpper() == "B")
                {
                    return SUBE.B;
                }
                else if (giris.ToUpper() == "C")
                {
                    return SUBE.C;
                }
                else
                {
                    Console.WriteLine(" Hatalı giriş yapıldı, tekrar deneyin. ");
                }

            } while (true);
        }

        static public string DersGir()
        {
            while (true)
            {
                Console.Write(" Not eklemek istediğiniz dersi girin:  ");
                return Console.ReadLine().ToUpper();
            }
        }






















    }
}
