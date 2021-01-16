using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi"+urun.Adi);

          
        }
        public void Ekle2(string urunAdi, string aciklama)
        {
            Console.WriteLine("sepete eklendi:" +urunAdi);
        }
    }
}
