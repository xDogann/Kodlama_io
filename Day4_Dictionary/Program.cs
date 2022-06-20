using System;

namespace Day4_Dictionary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, string>();


            //string tempNick;
            //string tempPass;

            Console.WriteLine("Kullanıcı Adı: ");
            string tempNick = Console.ReadLine();
            Console.WriteLine("Şifre: ");
            string tempPass = Console.ReadLine();

            myDictionary.Add(tempNick, tempPass);

            Console.WriteLine("\nBaşarıyla Giriş Yapıldı!\n");

            Console.WriteLine("\n\nVeri Tabanına Kayıtlı Kullanıcı Adı" +
                " ve Şifreler Yazdırılıyor..\n");

            myDictionary.Add("xDogann", "Abdussamed78.");
            myDictionary.Add("BookHauser", "Booker52");
            myDictionary.Add("Fansalt", "12348s.");
            myDictionary.Add("exept", "Exepc4");

            foreach (KeyValuePair<string, string> dic in myDictionary)
            {
                Console.WriteLine("\n- Kullanıcı Adı: {0}\n- Şifre: {1}", dic.Key, dic.Value);
            }


            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"},
                {"Turkey", "Ankara, İstanbul, Karabük" }
            };

            // Anahtar ve Değerleri yazdırıyor.
            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            // Ülkeler arasında Fransa var mı yok mu kontrol ediyor.
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }
            else 
            {
                Console.WriteLine("France unknow");
            }


        }
    }
}

