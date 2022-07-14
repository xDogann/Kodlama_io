using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuru Bilgileri Değerlendirme
            //
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler,ILoggerService loggerService)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                loggerService.Log();
            }
        }
    }
}
