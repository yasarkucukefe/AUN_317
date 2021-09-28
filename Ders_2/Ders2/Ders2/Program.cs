using System;


namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenler();
            //yas_hesap_konsol();
            // convert_data();

            int zaman = 10;
            // ternary operatörü
            string selam = (zaman > 18) ? "iyi akşamlar" : "iyi günler";
            Console.WriteLine(selam);

            double fiyat = 4;
            if(fiyat > 5)
            {
                //fiyat 5'ten büyükse çalışacak kod
                Console.WriteLine("elma");
            }
            else if (fiyat > 4)
            {
                //fiyat 4'ten büyük ise
                Console.WriteLine("portakal");
            }
            else
            {
                // fiyat 5'e küçük veya 5'ten küçük ise çalıcacak kod
                Console.WriteLine("incir");
            }


            string isim = "Ali";
            string soyisim = "Cenk";
            string isim_soyisim = isim + " " + soyisim;
            string isim_concat = string.Concat(isim, " ", soyisim);


            Math.Min(3, 4); // minimum => 3
            Math.Max(4.4, 9.1); //Maksimum => 9.1
            double rakam =Math.Round(9.55);
            Console.WriteLine(rakam);


        }

        static void mantik_sonuc()
        {
            int x = 3;
            int y = 4;

            bool sonuc = ((x > y) == false) || true;
            Console.WriteLine(sonuc);
        }

        static void aritmetik()
        {
            int x = 3, y = 4;
            x++; // x = x + 1;
            y--;
            y--;
            x += 4; // x = x + 4;
            int toplam = x + y;
            Console.WriteLine(toplam);
        }

        static void convert_data()
        {
            int ucret = 123;
            double toplam = (double)ucret;
            string dogum_yili = "2000";
            int yas = 2021 - string_to_integer(dogum_yili);
            Console.WriteLine(yas);
        }

        static int string_to_integer(string sene)
        {
            int int_sene = Convert.ToInt32(sene);
            return int_sene;
        }

        static void yas_hesap_konsol()
        {
            int dogum_yili = 2000;
            int yas = yas_hesapla(dogum_yili);
            string konsol_ciktisi = yas + " yaşındasınız.";
            Console.WriteLine(konsol_ciktisi);
        }

        static int yas_hesapla(int dogum_yili)
        {
            int yas = 2021 - dogum_yili;
            return yas;
        }

        static void degiskenler()
        {
            // degişkenler ilan edilirken (declare)
            // veri-türü değişken-adı 
            string isim="Mustafa";
            int fiyat = 12;
            string sehir = "İstanbul";
            char harf = 'A';
            bool devam_et = true;
            double cay_fiyat = 1.75;
            float pi_sayisi = 3.14473F;
            long cok_buyuk_tam_sayi = 9223372036854775807L;

            Console.WriteLine(isim);
            Console.WriteLine(fiyat);

        }
    }
}
