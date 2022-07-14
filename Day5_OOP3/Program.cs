using System;

namespace Day5_OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseloggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager); 

            List<IKrediManager> krediler = new List<IKrediManager> {konutKrediManager,ihtiyacKrediManager};
            basvuruManager.KrediOnBilgilendirmeYap(krediler, fileLoggerService);
        }
    }
}
