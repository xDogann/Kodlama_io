using Day3_ClassMetotDemo;
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Abdüssamed";
            musteri1.LastName = "Doğan";
            musteri1.Age = 18;
            musteri1.Money = 20000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Ali";
            musteri2.LastName = "Yılmaz";
            musteri2.Age = 22;
            musteri2.Money = 20000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Burak";
            musteri3.LastName = "Bal";
            musteri3.Age = 35;
            musteri3.Money = 500;

            // Abdüssamed Doğan - github.com/xDogann

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Müşteri Listeleme\n");
            musteriManager.List(musteriler);
            Console.WriteLine("\nMüşteri Ekleme\n");
            musteriManager.Add(musteri1);
            Console.WriteLine("\n Müşteri Silme\n");
            musteriManager.Delete(musteri2);
            
            


        }
    }
}