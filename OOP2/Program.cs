using System;

namespace Day5_OOP2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri
            {
                MusteriNo="1535156",TcNo="152671365124", Id=1,
                Adi="Doğan",Soyadi="Yıldız"
            };

            TuzelMusteri musteri2 = new TuzelMusteri
            {
                Id = 2,
                MusteriNo = "15156",
                SirketAdi = "Kodlama.io",
                VergiNo = "15616352156"
            };

            // Gerçek - Tüzel
            //  SOLID - L

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


        }
    }
}