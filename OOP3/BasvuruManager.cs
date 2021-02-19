using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {     //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerServise loggerServise )

        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerServise.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }

        }

    }
}
