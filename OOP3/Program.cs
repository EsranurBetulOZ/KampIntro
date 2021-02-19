using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();       
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerServise databaseLoggerService =new DatabaseLoggerService
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
