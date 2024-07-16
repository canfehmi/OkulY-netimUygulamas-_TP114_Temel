namespace OkulYönetimUygulaması_TP114_Temel
{
    internal class Program
    {
        static Okul Okul = new Okul();
        static void Main(string[] args)
        {
            Uygulama();
        }

        static void Uygulama()
        {
            SahteVeriGir();
            SahteAdresGir();
            SahteKitapEkle();
            Menu();
            while (true)
            {
                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                        TumOgrenciler();
                        break;
                    case "2":
                        SubeyeGoreOgrenci();
                        break;
                    case "3":
                        CinsiyeteGoreOgrenci();
                        break;
                    case "4":
                        TarihtenSonraDogan();
                        break;
                    case "5":
                        IllereGoreOgrenciler();
                        break;

                    default:
                        break;
                }
            }
        }

        static void TumOgrenciler()
        {
            Console.WriteLine("1-Bütün Ögrencileri Listele --------------------------------------------------");
            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Okulda hiç öğrenci yok.");
                return;
            }
            Listeleme(Okul.Ogrenciler);

        }
        static void SubeyeGoreOgrenci()
        {
            Console.WriteLine("2- Şubeye göre öğrencileri listele-----------------------------------");

            SUBE sube = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi seçin (A/B/C): ");

            List<Ogrenci> SubeyeGore = new List<Ogrenci>();
            SubeyeGore = Okul.Ogrenciler.Where(a => a.Sube == sube).ToList();
            Listeleme(SubeyeGore);

        }
        static void CinsiyeteGoreOgrenci()
        {
            Console.WriteLine("3- Cinsiyetine göre öğrenci listeleme------------------------------------");
            CINSIYET cinsiyet = AracGerecler.KizMiErkekMi("Hangi cinsiyete göre listelemek istediğinizi seçin (K/E):");
            List<Ogrenci> cins = new List<Ogrenci>();
            cins = Okul.Ogrenciler.Where(a => a.Cinsiyet == cinsiyet).ToList();
            Listeleme(cins);
        }
        static void TarihtenSonraDogan()
        {

        }
        static void IllereGoreOgrenciler()
        {

        }


        static void Listeleme(List<Ogrenci> liste)
        {
            Console.WriteLine("Sube".PadRight(10, ' ') + "No".PadRight(10, ' ') +
               "Adı" + " " + "Soyadı".PadRight(21, ' ') +
               "Not Ort.".PadRight(15, ' ') + "Okuduğu Kitap Say.");
            Console.WriteLine("".PadRight(70, '-'));


            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) + item.Ad.PadRight(10) + item.Soyad.PadRight(21) + item.No.ToString().PadRight(15));
            }

        }
        static void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 5 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20 - Öğrencinin notunu gir");
            Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın.");
        }

        static string SecimAl()
        {
            Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            return Console.ReadLine().ToUpper();
        }

        static void NotGir()
        {
            try
            {
                Console.WriteLine("20-Not gir ---------------------------");

                Console.WriteLine("Öğrencinin Numarası : ");
                int no = int.Parse(Console.ReadLine());

                //bu numaralı öğrencinin bilgileri bulunup ekrana yazdırılacak.

                string dersAdi = Console.ReadLine(); //--- Hangi ders?

                int adet = int.Parse(Console.ReadLine()); //kaç adet ders notu girilecek.

                for (int i = 1; i < adet; i++)
                {
                    Console.WriteLine(i + ".Notu Giriniz");
                    int not = int.Parse(Console.ReadLine());

                    Okul.NotEkle(no, dersAdi, not);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        static void SahteVeriGir()
        {
            Okul.OgrenciEkle(1, "Ali", "Soyad", new DateTime(2000, 5, 27), SUBE.A, CINSIYET.Kiz);
            Okul.OgrenciEkle(2, "Cenk", "Tosun", new DateTime(2004, 8, 5), SUBE.A, CINSIYET.Erkek);
            Okul.OgrenciEkle(3, "Gizem", "Küçük", new DateTime(2001, 11, 19), SUBE.B, CINSIYET.Kiz);
            Okul.OgrenciEkle(4, "Mert", "Aydoğan", new DateTime(2002, 1, 30), SUBE.B, CINSIYET.Erkek);
            Okul.OgrenciEkle(5, "Damla", "Sözer", new DateTime(2000, 7, 14), SUBE.C, CINSIYET.Kiz);
            Okul.OgrenciEkle(6, "Aytaç", "Kuru", new DateTime(2003, 3, 18), SUBE.C, CINSIYET.Erkek);
            Okul.OgrenciEkle(7, "Elif", "Ateş", new DateTime(2001, 5, 24), SUBE.A, CINSIYET.Kiz);
            Okul.OgrenciEkle(8, "Berkay", "Öz", new DateTime(2004, 12, 16), SUBE.A, CINSIYET.Erkek);
            Okul.OgrenciEkle(9, "Melike", "Türk", new DateTime(2002, 4, 20), SUBE.B, CINSIYET.Kiz);
            Okul.OgrenciEkle(10, "Yiğit", "Demir", new DateTime(2001, 2, 10), SUBE.B, CINSIYET.Erkek);


            //Başka öğrenciler de eklenebilir.

            //Adres, DersNotu, Kitap Bilgileri gibi veriler için de sahte veri oluşturubabilir.
        }

        static void SahteAdresGir()
        {

            Okul.AdresEkle(1, "Bursa", "Nilüfer", "Konak");
            Okul.AdresEkle(2, "Bursa", "Mudanya", "Güzelyalı");
            Okul.AdresEkle(3, "Bursa", "İznik", "Çilekli");
            Okul.AdresEkle(4, "Yalova", "Armutlu", "Bayır");
            Okul.AdresEkle(5, "Yalova", "Altınova", "Cumhuriyet");
            Okul.AdresEkle(6, "Yalova", "Çınarcık", "Çamlık");
            Okul.AdresEkle(7, "Kocaeli", "Gölcük", "Atatürk");
            Okul.AdresEkle(8, "Kocaeli", "İzmit", "Tavşantepe");
            Okul.AdresEkle(9, "Kocaeli", "Başiskele", "Barbaros");
            Okul.AdresEkle(10, "Sakarya", "Akyazı", "İnönü");

        }

        static void SahteKitapEkle()
        {

            string[] kitaplar = new string[20];
            kitaplar[0] = ("Sokrates’in Savunması - Platon");
            kitaplar[1] = ("Babalar ve Oğullar - Ivan Sergeyeviç Turgenyev");
            kitaplar[2] = ("Üç Silahşörler - Alexandre Dumas");
            kitaplar[3] = ("Oliver Twist - Charles Dickens");
            kitaplar[4] = ("Tom Sawyer - Mark Twain");
            kitaplar[5] = ("Peter Pan - James Matthew Barrie");
            kitaplar[6] = ("Seksen Günde Dünya Turu - Jules Verne");
            kitaplar[7] = ("Define Adası - Robert Louis Stevenson");
            kitaplar[8] = ("Vadideki Zambak - Honoré de Balzac");
            kitaplar[9] = ("Sefiller - Victor Hugo");
            kitaplar[10] = ("İnsan Neyle Yaşar? - Lev Nikolayeviç Tolstoy");
            kitaplar[11] = ("Robinson Crusoe - Daniel Defoe");
            kitaplar[12] = ("Beyaz Diş - Jack London");
            kitaplar[13] = ("Ölü Canlar - Nikolay Vasilyeviç Gogol");
            kitaplar[14] = ("Suç ve Ceza - Fyodor Mihayloviç Dostoyevski");
            kitaplar[15] = ("Mutlu Prens - Oscar Wilde");
            kitaplar[16] = ("Devlet - Platon");
            kitaplar[17] = ("Zeytindağı - Falih Rıfkı Atay");
            kitaplar[18] = ("Mai ve Siyah - Halid Ziya Uşaklıgil");
            kitaplar[19] = ("Sergüzeşt - Samipaşazade Sezai");


            Random rnd = new Random();
            for (int i = 1; i < 10; i++)
            {
                Okul.KitapEkle(i, kitaplar[rnd.Next(0, 20)]);
            }
            
            static void SahteNotGir()
            {
                string[] dizi = new string[4];
                dizi[0] = "Türkçe";
                dizi[1] = "Matematik";
                dizi[2] = "Fen";
                dizi[3] = "Sosyal";
                Random rnd = new Random();

                for (int i = 1; i <= 10; i++)
                {
                    for (int d = 0; d < 4; d++)
                    {
                        Okul.NotEkle(i, dizi[d], rnd.Next(0, 100));
                    }
                }
            }
            static void SahteNot()
            {
                Okul.NotEkle(1, "Türkçe", 90);
                Okul.NotEkle(1, "Matematik", 70);
                Okul.NotEkle(1, "Fen", 55);
                Okul.NotEkle(1, "Sosyal", 85);
                Okul.NotEkle(2, "Türkçe", 50);
                Okul.NotEkle(2, "Matematik", 40);
                Okul.NotEkle(2, "Fen", 60);
                Okul.NotEkle(2, "Sosyal", 83);
                Okul.NotEkle(3, "Türkçe", 88);
                Okul.NotEkle(3, "Matematik", 64);
                Okul.NotEkle(3, "Fen", 50);
                Okul.NotEkle(3, "Sosyal", 72);
                Okul.NotEkle(4, "Türkçe", 100);
                Okul.NotEkle(4, "Matematik", 97);
                Okul.NotEkle(4, "Fen", 85);
                Okul.NotEkle(4, "Sosyal", 95);
                Okul.NotEkle(5, "Türkçe", 52);
                Okul.NotEkle(5, "Matematik", 35);
                Okul.NotEkle(5, "Fen", 27);
                Okul.NotEkle(5, "Sosyal", 70);
                Okul.NotEkle(6, "Türkçe", 79);
                Okul.NotEkle(6, "Matematik", 91);
                Okul.NotEkle(6, "Fen", 73);
                Okul.NotEkle(6, "Sosyal", 99);
                Okul.NotEkle(7, "Türkçe", 85);
                Okul.NotEkle(7, "Matematik", 70);
                Okul.NotEkle(7, "Fen", 91);
                Okul.NotEkle(7, "Sosyal", 80);
                Okul.NotEkle(8, "Türkçe", 50);
                Okul.NotEkle(8, "Matematik", 47);
                Okul.NotEkle(8, "Fen", 76);
                Okul.NotEkle(8, "Sosyal", 28);
                Okul.NotEkle(9, "Türkçe", 87);
                Okul.NotEkle(9, "Matematik", 65);
                Okul.NotEkle(9, "Fen", 93);
                Okul.NotEkle(9, "Sosyal", 58);
                Okul.NotEkle(10, "Türkçe", 96);
                Okul.NotEkle(10, "Matematik", 50);
                Okul.NotEkle(10, "Fen", 65);
                Okul.NotEkle(10, "Sosyal", 100);
            }





        }
    }
}