using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimUygulaması_TP114_Temel
{
    internal class Ogrenci
    {

        public int No;
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;     //get set metotları tanımlanabilir.
        public float Ortalama;
        public SUBE Sube;
        public CINSIYET Cinsiyet;
        public Adres Adres;

        public List<string> Kitaplar = new List<string>();

        public List<DersNotu> Notlar = new List<DersNotu>();

    }

    public enum SUBE
    {
        Empty, A, B, C
    }

    public enum CINSIYET
    {
        Empty, Kiz, Erkek
    }
}
