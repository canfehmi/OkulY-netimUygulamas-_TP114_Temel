using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimUygulaması_TP114_Temel
{
     
    internal class Okul
    {
        //Okula ait herhangi bir verinin değiştirilmesi işi bu sınıfta yazılır.


        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumTarihi, SUBE sube, CINSIYET cinsiyet)
        {
            Ogrenci o = new Ogrenci();

            o.No = no;
            o.Ad = ad;
            o.Soyad = soyad;
            o.DogumTarihi = dogumTarihi;
            o.Sube = sube;
            o.Cinsiyet = cinsiyet;

            Ogrenciler.Add(o); 

            

            //diğer bilgiler eklenecek.

            //.Add(o);
        }

        public void NotEkle(int no, string dersAdi, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                o.Notlar.Add(new DersNotu(dersAdi, not));
            }
        }

        public void AdresEkle(int no, string il, string ilce, string mahalle)  
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            if (o != null)
            {
                //o.AdresEkle(il, ilce, mahalle);
            }
        }

        public void KitapEkle(int no, string kitapAdi)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                //o.KitapEkle(kitapAdi);
            }
        }

    }
}
