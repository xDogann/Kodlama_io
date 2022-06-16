using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Metotlar
{
    internal class SepetManager
    {
        //               Parametre Ekledik
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
