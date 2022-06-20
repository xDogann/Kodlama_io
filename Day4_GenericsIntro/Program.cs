using System;
using System.Collections.Generic;

namespace Day4_GenericsIntro 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Doğan");
            Console.WriteLine(isimler);
            Console.WriteLine(isimler.Count);
            isimler.Add("Ali");
            isimler.Add("mustafa");
            Console.WriteLine(isimler.Count);
        }
    }
}