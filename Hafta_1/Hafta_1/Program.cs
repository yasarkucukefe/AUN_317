using System;

namespace Hafta_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 2;

            int b = 2 * a;

            string isim = "Yaşar";
            string soyisim = "Küçükefe";

            Console.WriteLine(isim + " " + soyisim);

            fonksiyon_a();

            int deger = tamsayi_return();
            Console.WriteLine(deger);

            if_kontrol(9);

        }

        static void if_kontrol(int x)
        {
            if(x < 5)
            {
                Console.WriteLine("x değeri < 5");
            }
            else
            {
                Console.WriteLine("x değeri >= 5");
            }
        }
        // if_kontrol_2(2,5);
        static void if_kontrol_2(int x, int y)
        {
            if (x < 5 && y > 2)
            {
                Console.WriteLine("Elma");
            }
            else if (x > 5 || y < 9)
            {
                Console.WriteLine("Portakal");
            }
            else
            {
                Console.WriteLine("Ceviz");
            }
        }


        static string if_kontrol_mertcan(int x)
        {
            string mesaj = "";
            if (x < 5)
            {
                mesaj = " Değer 5'ten küçüktür.";
            }
            else
            {
                mesaj = " Değer 5'ten büyük veya eşittir.";
            }
            return mesaj;
        }

        static string if_kontrol_ternary(int x)
        {
            // Ternary operator: (koşul kontrolü) ? koşul_doğru_ise_deger : yanlış_ise_deger
            string mesaj = (x > 5) ? "Değer 5'ten küçüktür" : "Değer 5'ten büyük veya eşittir.";

            return mesaj;
        }



        static void fonksiyon_a()
        {
            Console.WriteLine("Fonksiyon A çalıştı.");
        }


        static int tamsayi_return()
        {
            return 1;
        }

        string string_return()
        {
            return "Istanbul";
        }


        void degiskenler()
        {
            // Değişken deklarasyonu: veri_turu degisken_ad;
            string isim = "Ahmet";
            String soyisim = "Cebe";
            int rakam = 1;
            string meyve1 = "Elma", mevye2 = "Portakal";
            int sayi1 = 3, sayi2 = 4;
            int x, y;
            char harf = 'A'; // Tek tırnak ile
            bool devam_et = true; // Doğru 
            bool deger_kontrol = 2 > 1; //true
            bool deger_kontrol2 = 2 < 4; //false
            double kg_fiyat = 9.99; //ondalık sayılar
            float pi_sayisi = 3.14473F;
            //int cok_buyuk_rakam = 3000000000000; // hata verir, int veri türü en fazla 2,147,483,647 değerini alabilir.
            long cok_buyuk_sayi = 30000000000000L;

        }

    }
}
