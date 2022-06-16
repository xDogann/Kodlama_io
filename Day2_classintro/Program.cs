class Program
{

    static void Main(string[] args)
    {
        string isim = "Ali";
        string soyiisim = "Yıldız";

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Abdüssamed Doğan";
        kurs1.IzlenmeOrani = 78;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Engin demiroğ";
        kurs2.IzlenmeOrani = 34;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Engin demiroğ";
        kurs3.IzlenmeOrani = 34;

        // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[]{kurs1,kurs2,kurs3};
        Console.WriteLine("Kurs - Eğitmen  \n");
        foreach (var kurs in kurslar)
        {
            Console.WriteLine("- " + kurs.KursAdi + " : " + kurs.Egitmen);
        }

    }
        
    class Kurs
    {
      //prop ile yeni veri oluşturuyoruz.
      //Tür - Veri Türü - Veri Adı  
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }   

}

