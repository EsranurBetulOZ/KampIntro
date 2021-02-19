using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "5461651656";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 5456;
            musteri2.MusteriNo = "265656565";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "155565155";



            //Gerçek müşteri- Tüzel müşteri
            //SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
