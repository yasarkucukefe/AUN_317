using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] arabalar = { "Ford", "Tesla", "BMW", "Mercedes" };
            // arabalar[4] = "Nissan"; ! Hata verir. C# ve Java'da Array'lere yeni eleman eklenemez.

            //List kullanmak için using System.Collections.Generic kütüphanesi import edilmeli.;
            List<string> arabaListe = new List<string>();
            arabaListe.Add("Ford");
            arabaListe.Add("Tesla");
            arabaListe.Add("BMW");
            arabaListe.Add("Mercedes");


            List<int> rakamlar = new List<int>();
            rakamlar.Add(0);
            rakamlar.Add(1);
            //...

            Console.WriteLine(arabaListe[2]);
            Console.WriteLine(rakamlar[1]);

            Araba araba1 = new Araba("Ford", 2020, 100000);
            Araba araba2 = new Araba("Nissan", 2021, 200000);

            // Class'lar bir List'in elemanları olarak listelenebilirler.
            List<Araba> arabalarList = new List<Araba>();
            arabalarList.Add(new Araba("Toyota", 2019, 150000));
            arabalarList.Add(araba1);
            arabalarList.Add(araba2);
            arabalarList.Add(new Araba("TOGG", 2022, 80000));

            int toplam = arabalarList.Count;

            //Console.WriteLine(arabalarList[1].get_firma()); //

            listele(arabalarList);

            //LINQ
            Console.WriteLine("Foreach LINQ");
            arabalarList.ForEach(araba => { Console.WriteLine(araba.get_firma() + " => " + araba.fiyat); });

            //List filtreleme
            List<Araba> pahaliArabalar = pahaliArabalarList(arabalarList, 100000);

            Console.WriteLine("Pahalı arabalar (>=100000)");
            pahaliArabalar.ForEach(pahaliAraba => { Console.WriteLine(pahaliAraba.firma + " => " + pahaliAraba.fiyat); });

            // LINQ ile filtreleme
            // using System.Linq;
            var pahaliArabalarLINQ = from araba in arabalarList
                                     where araba.fiyat >= 100000.0
                                     select araba;

            Console.WriteLine("LINQ filtre ile hesaplanan Pahalı arabalar (>=100000)");
            foreach (Araba araba in pahaliArabalarLINQ)
            {
                Console.WriteLine(araba.get_firma() + " => " + araba.fiyat);
            }

            // Insert (bir listeye yeni eleman eklemek
            arabalarList.Add(new Araba("Fiat", 2018, 120000)); // listenin sonuna eklenir
            listele(arabalarList); // Add => listenin sonuna ekler
            Araba araba5 = new Araba("Hyundai", 2021, 90000);
            arabalarList.Insert(1, araba5);
            listele(arabalarList);

            // Listeden bir elemanı çıkarmak (remove etmek)
            arabalarList.Remove(araba5);
            listele(arabalarList);

            arabalarList.RemoveAt(1);
            listele(arabalarList);

            arabalarList.RemoveRange(0, arabalarList.Count - 1);
            listele(arabalarList);
        }

        static void forEachOrnek()
        {
            int[] rakamlar = { 0, 1, 2, 3, 4 };
            foreach (int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }
        }

        static void listele(List<Araba> listAraba)
        {
            Console.WriteLine("Foreach loop");
            foreach (Araba araba in listAraba)
            {
                Console.WriteLine(araba.get_firma() + " => " + araba.fiyat);
            }
        }

        static List<Araba> pahaliArabalarList(List<Araba> listAraba, int fiyatYuksek)
        {
            List<Araba> pahali_arabalar = new List<Araba>();

            foreach (Araba araba in listAraba)
            {
                if (araba.fiyat >= fiyatYuksek)
                {
                    pahali_arabalar.Add(araba);
                }
            }

            return pahali_arabalar;
        }

    }

    class Araba
    {
        public String firma;
        public int modelYili;
        public int fiyat;
        public String model { get; set; }

        public Araba(String firma_, int modelYili_, int fiyat_)
        {
            firma = firma_;
            modelYili = modelYili_;
            fiyat = fiyat_;
        }

        public string get_firma() { return firma; }
    }
}
