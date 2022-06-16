
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\n-> Mevcut Kurslar\n");
        string[] kurslar = new string[] {
        "Mobil Programlama",
        "Web Programlama",
        "Masaüstü Programlama"};

        for (int i = 0; i < kurslar.Length; i ++)
        {
            Console.WriteLine("- " + kurslar[i]);
        }
        Console.WriteLine("\nLOG:For Listelendi..\n");

        Console.WriteLine("\n-> Mevcut Kurslar\n");
        //Dizi temelli yapıları tek tek dolaşır
        foreach (string kurs in kurslar)
        {
            Console.WriteLine("- " + kurs);
        } 

        Console.WriteLine("\nLOG: Foreach Listelendi..\n");
    }
    
} 
 