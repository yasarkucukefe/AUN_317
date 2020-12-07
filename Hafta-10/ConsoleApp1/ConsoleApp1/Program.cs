using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //struct_ornek();
            //enum_ornek();
            //string_builder_ornek();
            //reference_arg_method();
            //array_list_ornek();
            list_ornek();
        }

        private static void list_ornek()
        {
            List<int> asalSayilar = new List<int>();
            asalSayilar.Add(1);
            asalSayilar.Add(2);
            asalSayilar.Add(3);

            List<string> sehirler = new List<string>() { "İzmir" };
            //var sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            //
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() {Id=1, Isim="Mehmet Mert", Ders="YBS-317"},
                new Ogrenci() {Id=2, Isim="Ayşe Koru", Ders="YBS-317"},
                new Ogrenci() {Id=3, Isim="Ali Kanat", Ders="YBS-317"},
            };

            Ogrenci ogrenci = ogrenciler[0];
            Console.WriteLine($"{ogrenci.Isim} => {ogrenci.Ders}");

            //LINQ : Linear Integrated Query
            var linq_ogrenci = from ogrenci_ in ogrenciler
                               where ogrenci_.Isim == "Ali Kanat"
                               select ogrenci_;
            //var linq_ogr_ = from ogrenci_ in ogrenciler
            //                            where ogrenci_.Isim == "Ali Kanat"
            //                            select ogrenci_;
            Console.WriteLine("LINQ:");
            foreach (var item in linq_ogrenci)
            {
                Console.WriteLine($"{item.Isim} => {item.Ders}");
            }
            

        }

        class Ogrenci
        {
            public int Id;
            public string Isim;
            public string Ders;
        }

        private static void array_list_ornek()
        {
            string[] meyveler = { "Elma", "Portakal", "Mandalina" };

            ArrayList arr_list = new ArrayList();
            // var arr_list = new ArrayList();
            arr_list.Add("Elma");
            arr_list.Add("Portakal");
            arr_list.Add(3);
            arr_list.Add('C');
            arr_list.Add(true);
            arr_list.Add(null);

            ArrayList arr_list_2 = new ArrayList() {"Elma", "Portakal", 3, null, true };

            int deger =(int) arr_list[2];//return: 3
            string meyve =(string) arr_list[0];// return: Elma

            arr_list[1] = "Mandalina";
            arr_list[2] = false;

            foreach (var item in arr_list)
            {
                if(item == null) { Console.WriteLine("null"); continue; }
                Console.WriteLine($"{item} => type: {item.GetType()}");
                //Console.WriteLine(item + " => type:" + item.GetType());
            }
            Console.WriteLine("------");
            //insert
            arr_list.Insert(2, "insert edildi");
            foreach (var item in arr_list)
            {
                if (item == null) { Console.WriteLine("null"); continue; }
                Console.WriteLine($"{item} => type: {item.GetType()}");
                //Console.WriteLine(item + " => type:" + item.GetType());
            }
            Console.WriteLine("------");
            //
            // Contains
            string meyve_ = "Limon";
            Console.WriteLine($"{meyve_} ? {arr_list.Contains(meyve_)}");
            Console.WriteLine("------");

            //remove
            arr_list.Remove("Elma");//Elma array listesinden çıkarıldı
            foreach (var item in arr_list)
            {
                if (item == null) { Console.WriteLine("null"); continue; }
                Console.WriteLine($"{item} => type: {item.GetType()}");
                //Console.WriteLine(item + " => type:" + item.GetType());
            }
            arr_list.RemoveAt(2);//2 no'lu index elemanını array list'ten çıkarır
            arr_list.RemoveRange(0, 3); //0. index'ten başlayarak 3 tane eleman çıkar
            Console.WriteLine("------");

            //reverse ve sort
            print_array_list(arr_list);
            //arr_list.Sort();
            //print_array_list(arr_list);
            arr_list.Reverse();
            print_array_list(arr_list);
            arr_list.Clear();
            print_array_list(arr_list);

        }

        private static void print_array_list(ArrayList arr_list)
        {
            foreach (var item in arr_list)
            {
                if (item == null) { Console.WriteLine("null"); continue; }
                Console.WriteLine($"{item} => type: {item.GetType()}");
                //Console.WriteLine(item + " => type:" + item.GetType());
            }
        }

        private static void reference_arg_method()
        {
            int a = 2;
            Console.WriteLine(a);
            make_10(out a);
            Console.WriteLine(a);
            make_square(ref a);
            Console.WriteLine(a);
        }

        private static void make_10(out int a)
        {
            a = 10;
            Console.WriteLine(a);
        }

        private static void make_square(ref int a)
        {
            a = a * a;
            Console.WriteLine(a);
        }

        private static void string_builder_ornek()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Merhaba ");
            sb.Append("Dünya! ");
            sb.Append("Merhaba ");
            sb.Append("C#");
            string yeni = "yeni bir string";
            sb.AppendLine();
            sb.Append(yeni);
            string diger = "Merhaba Dünya! Merhaba C# \nyeni bir string"; 
            Console.WriteLine(sb);
            Console.WriteLine(diger);
            //
            string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Elif" };
            //Ahmet(5 harf), Mehmet(6 harf), Ayşe(4 harf), Elif(4 harf),
            string isim_harf_say = "";
            foreach(string isim in isimler)
            {
                isim_harf_say += isim + "(" + isim.Length + " harf),";
                //isim_harf_say = isim_harf_say + isim + "(" + isim.Length + " harf),";
            }
            Console.WriteLine(isim_harf_say);
            //
            StringBuilder sb_ = new StringBuilder();
            foreach (string isim in isimler)
            {
                sb_.Append(isim + "(" + isim.Length + " harf),");
            }
            Console.WriteLine(sb_);
            //Insert
            StringBuilder sb_2 = new StringBuilder("Merhaba Dünya");
            sb_2.Insert(8, "C# ve ");
            Console.WriteLine(sb_2);
            //Remove
            sb_2.Remove(8, 6);
            Console.WriteLine(sb_2);
            //Replace
            sb_2.Replace("Dünya", "C#");
            Console.WriteLine(sb_2);
            //
            Console.WriteLine(sb_2.GetType());
            string sb_string = sb_2.ToString();
            Console.WriteLine(sb_string.GetType());
            //

        }

        enum Kategoriler
        {
            Elektronik = 10,
            Sebze_Meyve = 1,
            Deterjanlar = 3,
            Oyuncak = 5,
            Et = 7
        }

        enum HaftaGunleri
        {
            Pazartesi, //0
            Sali, //1
            Carsamba, //2
            Persembe,  //3
            Cuma, //4
            Cumartesi, //5
            Pazar //6
        }

        private static void enum_ornek()
        {
            string[] WeekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(HaftaGunleri.Carsamba + " index degeri:"+(int) HaftaGunleri.Carsamba);
            Console.WriteLine(WeekDays[2]);
            //Kategoriler
            Console.WriteLine(Kategoriler.Deterjanlar + " => index :" + (int)Kategoriler.Deterjanlar);
            //
            Console.WriteLine("Enum iteration:");
            foreach(Kategoriler kategori in Enum.GetValues(typeof(Kategoriler)))
            {
                Console.WriteLine(kategori+" => index:"+(int) kategori);
            }


        }

        private static void struct_ornek()
        {
            Coordinate nokta = new Coordinate();
            Console.WriteLine(nokta.x);
            Console.WriteLine(nokta.y);
            Console.WriteLine(nokta.lokasyon);
            //
            Coordinate nokta_2; //struct değişkenlerini ayrıca başlatmak gerekiyor
            nokta_2.x = 21;
            nokta_2.y = 12;
            Console.WriteLine(nokta_2.x);
            //
            Coordinate nokta_3 = new Coordinate(3, 5, "merkez");
            Console.WriteLine(nokta_3.x);
            Console.WriteLine(nokta_3.y);
            Console.WriteLine(nokta_3.lokasyon);

        }

        struct Coordinate
        {
            public int x;
            public int y;
            public string lokasyon;

            public Coordinate(int x, int y, string lokasyon)
            {
                this.x = x;
                this.y = y;
                this.lokasyon = lokasyon;

            }
        }
    }
}
