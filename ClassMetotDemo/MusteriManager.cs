using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("-> " + musteri.Name + " " + musteri.LastName + " Veri tabanından siliniyor.");
        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adı: ");
            string name = Console.ReadLine();
            Console.WriteLine("Müşterinin Soyadı: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Müşterinin Yaşı: ");
            string age = Console.ReadLine();
            Console.WriteLine("Müşterinin Parası: ");
            string money = Console.ReadLine();

            Console.WriteLine("Müşteri Sisteme Eklendi");

            // Abdüssamed Doğan - github.com/xDogann

        }
        public void List(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("> " + musteri.Name + " " + musteri.LastName);
            }

        }

    }

}
