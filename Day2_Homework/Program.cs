class Program
{

    static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.UrunAd = "iPhone 12";
        urun1.UrunID = 001;
        urun1.UrunPuan = 4.7;
        
        Urun urun2 = new Urun();
        urun2.UrunAd = "iPhone 13";
        urun2.UrunID = 002;
        urun2.UrunPuan = 5;
        
        Urun urun3 = new Urun();
        urun3.UrunAd = "iPad Pro";
        urun3.UrunID = 003;
        urun3.UrunPuan = 4.9;

        //Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
        Urun[] urunler = new Urun[] { urun1, urun2 , urun3 };

        Console.WriteLine("ID |  URUN  |  PUAN");
        Console.WriteLine("______________________\n");
        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.UrunID + " | " + urun.UrunAd + " | " + urun.UrunPuan);
        }
    }

    class Urun
    {
        public string UrunAd { get; set; }
        public int UrunID { get; set; }
        public double UrunPuan { get; set; }
    }

}