using System;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //kelimelere_ayir("Bugün günlerden Salı ve hava çok güzel.");
            /*
            //
            Console.WriteLine("Kare alan ve çevre");
            double kenar_uzunluk = 6;
            Console.WriteLine(kare_alan(kenar_uzunluk));
            Console.WriteLine(kare_cevre(kenar_uzunluk));
 
            //
            Console.WriteLine("Daire alan ve çevre");
            double yariCap = 2;
            Console.WriteLine(daire_alan(yariCap));
            Console.WriteLine(daire_cevre(yariCap));
            */

            //Bir Class'tan nesne türetme
            GeometrikSekil sekil_1 = new GeometrikSekil("Kare");
            sekil_1.kenar = 6;
            sekil_1.ClassInfo();

            GeometrikSekil sekil_2 = new GeometrikSekil("Daire");
            sekil_2.yariCap = 2;

            Console.WriteLine(sekil_1.sekil + " alan: " + sekil_1.alan_hesapla());
            Console.WriteLine(sekil_1.sekil + " cevre: " + sekil_1.cevre_hesapla());
            Console.WriteLine(sekil_1.sekil + " kenar sayısı: " + sekil_1.KenarSayisi());

            Console.WriteLine(sekil_2.sekil + " alan: " + sekil_2.alan_hesapla());
            Console.WriteLine(sekil_2.sekil + " cevre: " + sekil_2.cevre_hesapla());
            Console.WriteLine(sekil_2.sekil + " kenar sayısı: " + sekil_2.KenarSayisi());

            //
            GeometrikSekil sekil_3 = new GeometrikSekil("Diktörtgen");
            sekil_3.a = 5;
            sekil_3.b = 9;
            Console.WriteLine(sekil_3.sekil);
            Console.WriteLine("Alan: " + sekil_3.alan_hesapla());
            Console.WriteLine("Çevre: " + sekil_3.cevre_hesapla());
            Console.WriteLine("Kenar Sayısı: " + sekil_3.KenarSayisi());

            // bos constructor
            GeometrikSekil sekil_4 = new GeometrikSekil();
            sekil_4.sekil = "Kare";
            sekil_4.kenar = 8;
            Console.WriteLine("Şekil: " + sekil_4.sekil);

        }

        

        static double kare_alan(double kenar)
        {
            double alan = kenar * kenar;
            return alan;
        }

        static double kare_cevre(double kenar)
        {
            double cevre = 4 * kenar;
            return cevre;
        }

        static double daire_alan(double yaricap)
        {
            double alan = Math.PI * Math.Pow(yaricap,2);
            return alan;
        }

        static double daire_cevre(double yaricap)
        {
            double cevre = 2 * Math.PI * yaricap;
            return cevre;
        }

        static void kelimelere_ayir(String metin)
        {
            string[] kelimeler = metin.Split(" ");
            foreach(string kelime in kelimeler)
            {
                int kac_harf = kelime.Length;
                string str_kac_harf = " => " + kac_harf + " harf.";
                Console.WriteLine(kelime + str_kac_harf);
            }
        }



    }

    class GeometrikSekil
    {
        public string sekil = "?";
        double alan;
        public double kenar, yariCap;
        public double a, b;
        double cevre;
        public string bilgi = "Bu bir geometrik şekildir.";

        public GeometrikSekil(string sekil_)
        {
            sekil = sekil_;
        }

        public GeometrikSekil()
        {

        }

        public void ClassInfo()
        {
            Console.WriteLine("Bu Class'ı kullanarak bir geometrik şeklin alan, çevre, ve kenar sayısı bilgileri hesaplanabilir.");
        }

        public int KenarSayisi()
        {
            int kenarSay = 0;
            switch (sekil)
            {
                case "Kare":
                    kenarSay = 4;
                    break;
                case "Daire":
                    kenarSay = 0;
                    break;
                case "Diktörtgen":
                    kenarSay = 4;
                    break;
                default:
                    kenarSay = 9;
                    break;
            }
            return kenarSay;
        }

        public double alan_hesapla()
        {
            switch (sekil)
            {
                case "Kare":
                    alan = kenar * kenar;
                    break;
                case "Daire":
                    alan = Math.PI * Math.Pow(yariCap, 2);
                    break;
                case "Diktörtgen":
                    alan = a * b;
                    break;
                default:
                    alan = 0;
                    break;
            }
            return alan;
        }

        public double cevre_hesapla()
        {
            switch (sekil)
            {
                case "Kare":
                    cevre = 4 * kenar;
                    break;
                case "Daire":
                    cevre = Math.PI * 2 * yariCap;
                    break;
                case "Diktörtgen":
                    cevre = 2 * (a + b);
                    break;
                default:
                    cevre = 0;
                    break;
            }
            return cevre;
        }

    }
}
