using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length == 2)
            {
                string isim = args[0];
                string soyisim = args[1];
                string adSoyad = isim + " " + soyisim;
                adSoyad = string.Concat(isim, " ", soyisim);
                yaz("Merhaba, " + adSoyad);
            }
            else
            {
                // yaz("Lütfen ad ve soyad belirtiniz. Örnek: ConsoleApp1 Ad Soyad");
            }


            Statik statik = new Statik();

            statik.seneKac();

            Statik.sene_kac("2022");

            // Özel karakterler
            yaz("Üniversitemiz mottosu \"Seni en iyi sen yapar\" ");

            string rakam = "21";
            int sayi = 12;
            int sayi2 = 13;
            bool c = sayi == sayi2;
            if (c) { 
                yaz("elma"); 
            } else { 
                yaz("armut"); 
            }

            yaz(rakam + sayi);

            // Seçenekler: 33, 2112, hata verir, 6

            int kisi = (int) Kisi.Guvenlik;

            if(kisi == (int)Kisi.Guvenlik)
            {

            }

            // Dosya İşlemleri
            string dosyaIcerik = "Ankara 6000000";
            File.WriteAllText("yeni_dosya.txt", dosyaIcerik);

            File.AppendAllText("yeni_dosya.txt", "\nİstanbul 16000000");


        }

        static void yaz(String metin)
        {
            Console.WriteLine(metin);
        }
    }

    enum Kisi{
        Ogrenci, //0
        Idari,  //1
        Akademik, // 2
        Guvenlik, //3
        Temizlik //4
    }



    class Statik
    {
        public string sene = "2021";

        public void seneKac()
        {
            Console.WriteLine(sene);
        }

        public static void sene_kac(string seneParam)
        {
            Console.WriteLine("Statik method => " + seneParam);
        }
    }


}
