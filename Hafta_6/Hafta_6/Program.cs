using System;

namespace Hafta_6
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

            Kiyafet gomlek1 = new Kiyafet("gomlek", "yaz", 2021);
            Kiyafet pantalon1 = new Kiyafet("pantalon", "kış", 2022);
            Kiyafet kazak1 = new Kiyafet("kazak", "sonbahar", 2019);
            Kiyafet gomlek2 = new Kiyafet("gomlek", "bahar", 2018);

            //pantalon1
            Console.WriteLine("Pantalon-1 Sene: " + pantalon1.getSene());

            Console.WriteLine("Gömlek-2 bilgileri: " + gomlek2.detaylar());


            // Inheritance
            IthalKiyafetler ithalGomlek1 = new IthalKiyafetler("mont", "kış", 2022, "USA", 125);
            Console.WriteLine(ithalGomlek1.getSene());

            elektrikliArabalar togg1 = new elektrikliArabalar("TOGG", "togg", "mavi", 2023, 300);

            Console.WriteLine(togg1.getOzellikler());
            togg1.setTork(95);




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

            // Yeni nesneler
            yeniNesneler();

            // GeometrikSekil
            GeometrikSekil yeniSekil = new GeometrikSekil();
            yeniSekil.sekil = "Daire";
            yeniSekil.yariCap = 6;
            Console.WriteLine("Alan: " + yeniSekil.alan_hesapla());

            // Araba
            Araba araba1 = new Araba("BMW","3.16t","Kırmızı",2002); //Uğurcan'ın arabası
            araba1.setTork(65);
            Console.WriteLine("Araba-1 Özellikler:");
            Console.WriteLine(araba1.getOzellikler());
            Console.WriteLine(araba1.getTork());

        }

        static void yeniNesneler()
        {
            Araba araba1 = new Araba("Nissan", "Qashkai", "mavi", 2010);
            Araba araba2 = new Araba("Ford", "Focus", "kırmızı", 2020);
            //hangisiDahaYeni(araba1, araba2);
            araba1.sanzuman = "Otomatik";
            Console.WriteLine(araba1.sanzuman);
            araba2.sanzuman = "Manuel";
            Console.WriteLine(araba2.sanzuman);
        }

        static void hangisiDahaYeni2(Araba arac1, Araba arac2)
        {
            Console.WriteLine("Araba-1 => " + arac1.kacYas());
            Console.WriteLine("Araba-2 => " + arac2.kacYas());
            if (arac1.kacYas() > arac2.kacYas())
            {
                Console.WriteLine("Arac-2 daha yenidir.");
            }
            else if (arac1.kacYas() < arac2.kacYas())
            {
                Console.WriteLine("Arac-1 daha yenidir.");
            }
            else
            {
                Console.WriteLine("Arac-1 ve Arac-2 aynı yaştadırlar.");
            }
        }

        static void hangisiDahaYeni(Araba arac1, Araba arac2)
        {

            if (arac1.kacYas() > arac2.kacYas())
            {
                Console.WriteLine("Arac-2 daha yenidir.");
                return;
            }

            if (arac1.kacYas() < arac2.kacYas())
            {
                Console.WriteLine("Arac-1 daha yenidir.");
                return;
            }
            Console.WriteLine("Arac-1 ve Arac-2 aynı yaştadırlar.");
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
            double alan = Math.PI * Math.Pow(yaricap, 2);
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
            foreach (string kelime in kelimeler)
            {
                int kac_harf = kelime.Length;
                string str_kac_harf = " => " + kac_harf + " harf.";
                Console.WriteLine(kelime + str_kac_harf);
            }
        }





    }

    class IthalKiyafetler : Kiyafet
    {
        string cesit;
        string mevsim;
        int sene;
        string ulke;
        double ithalFiyat;

        public IthalKiyafetler(string cesit_, string mevsim_, int sene_, string ulke_, double ithalFiyat_) : base(cesit_, mevsim_, sene_)
        {
            this.ulke = ulke_;
            this.ithalFiyat = ithalFiyat_;
        }

    }

    class Kiyafet
    {
        string cesit;
        string mevsim;
        int sene;

        public Kiyafet(string cesit, string mevsim, int sene)
        {
            this.cesit = cesit;
            this.mevsim = mevsim;
            this.sene = sene;
        }

        public int getSene() { return sene; }

        public string detaylar()
        {
            return "Çeşit: " + this.cesit + ", Mevsim: " + this.mevsim + ", sene:" + this.sene; 
        }
    }

    class elektrikliArabalar : Araba
    {
        int menzil;

        public elektrikliArabalar(string marka_, string model_, string renk_, int sene_, int menzil_) : base(marka_, model_, renk_, sene_)
        {
            menzil = menzil_;
        }

    }

    class Bataryalar
    {
        string tur;
    }

    class Araba
    {
        string marka;
        string model;
        string renk;
        int sene;
        public string sanzuman;
        double tork;

        public Araba(string marka_, string model_, string renk_, int sene_)
        {
            marka = marka_;
            model = model_;
            renk = renk_;
            sene = sene_;
        }

        public string getOzellikler()
        {
            string ozellik = this.marka + "\n" + this.model + "\n" + this.sene;
            return ozellik;
        }

        public int arabaSene() { return sene; }

        public void setTork(double tork_) { this.tork= tork_; }

        public double getTork() { return tork; }

        public int kacYas()
        {
            int buYil = DateTime.Now.Year;
            int kacYas = buYil - sene;
            return kacYas;
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