using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary operatörü
            int x = 30, y = 50;
            var result = x > y ? "x büyüktür y'den" : "y buyuktur";
            Console.WriteLine(result);

            int a = 50, b = 50;
            string sonuc = a > b ? "a buyuk b'den" : a < b ? "b buyuk" : a == b ? "eşittirler" : "sonuç bulanamadı";
            Console.WriteLine(sonuc);

            int k = 2, l = 10, z = 15;
            int resultt = k * 3 > l ? k : l > z ? l : z;
            Console.WriteLine(resultt);

            //SWİTCH İFADELERİ

            int day = 6;
            switch (day)
            {
                case 1:
                    Console.WriteLine("pazartesi");
                    break;
                case 2:
                    Console.WriteLine("salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("perşembe");
                    break;
                case 5:
                    Console.WriteLine("cuma");
                    break;
                default:
                    Console.WriteLine("hafta sonu");
                    break;
                    //While faktoriyel hesaplama ama çalışmadı
                    int i = 1;
                    double faktoriyel = 1;
                    Console.WriteLine("faktöriyeli alınacak sayıyı giriniz");
                    double sayi = Convert.ToInt32(Console.ReadLine());


                    while (sayi >= i)
                    {
                        faktoriyel *= i;
                        i--;

                    }
                    Console.WriteLine("sonuç" + faktoriyel);




            }

        }
    }
}