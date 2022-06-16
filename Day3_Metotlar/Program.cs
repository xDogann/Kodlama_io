using System;


namespace Day3_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Urun Türünde (Classında) urun1 adında oluşturuyoruz.
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 8.5;
            urun2.Aciklama = "Adana Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe - tip güvenli
            foreach (var urun in urunler) // Foreach ürün kadar döngüye girer. Örn. Dizide 10 ürün kayıtlı, 10 kere döner..
            {

                Console.WriteLine("- Ürün Adı: " + urun.Adi);
                Console.WriteLine("- Ürün Fiyatı: " + urun.Fiyat);
                Console.WriteLine("- Ürün Açıklaması: " + urun.Aciklama);
                Console.WriteLine("-----\n");
            }

            Console.WriteLine("\n-----------------Metotlar-------------\n");

            //İnstance - Örnek
            //Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            /*sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Kiraz", "Nopolyon Kiraz", 30);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 8);*/

        }

        // Dont repeat yourself - DRY - Clean Code - Best Prectice
    }
}