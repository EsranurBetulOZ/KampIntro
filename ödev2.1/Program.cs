using System;

namespace ödev2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0; // değişkenlerin başlangıç değeri 0 olarak ayarlandı
            while (sayi % 2 == 0)  // koşulda sayi değişkeninin çift olup olmadıgına bakılıyor
            {
                toplam = toplam + sayi;
                //sayi değikeninin değeri toplama ekleniyor
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Girilen Çift Sayıların Toplamı = " + toplam);

            ////While faktoriyel hesaplama 
            //int i = 1;
            //double faktoriyel = 1;
            //Console.WriteLine("faktöriyeli alınacak sayıyı giriniz");
            //double sayi = Convert.ToInt32(Console.ReadLine());


            //while (sayi >= i)
            //{
            //    faktoriyel *= i;
            //    i++;

            //}
            //Console.WriteLine("sonuç" + faktoriyel);


        }
    }
}
