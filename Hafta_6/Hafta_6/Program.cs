using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Hafta_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //yeni_film_nesneleri();
            //yeni_film_constructor();
            //yeni_film_liste();
            // film_liste_ve_detay();
            // film_private_method();

            Sekil kare = new Sekil(2);
            Sekil dikdorgen = new Sekil(3, 4);
            Sekil ucgen = new Sekil(5, 6, 7);
            Console.WriteLine("Kare için Çevre: " + kare.Cevre());
            Console.WriteLine("Dikdörgen Çevre: " + dikdorgen.Cevre());
            Console.WriteLine("Ucgen Çevre: " + ucgen.Cevre());
        }

        private static void film_private_method()
        {
            List<Film> filmler = film_listesi_as_list();
            listele_filmler(filmler);
            uint film_id = user_input_film_id(filmler.Count);
            string film_yonetmen_oyuncu = filmler[(int)film_id].film_basrol_yonetmen();
            Console.WriteLine(film_yonetmen_oyuncu);
        }

        private static void film_liste_ve_detay()
        {
            List<Film> filmler = film_listesi_as_list();
            listele_filmler(filmler);
            uint film_id = user_input_film_id(filmler.Count);
            //Film secilen_film = filmler[(int)film_id];
            goster_film_detay(filmler[(int)film_id]);
            filmler[(int)film_id].goster_film_detay();
        }

        private static void listele_filmler(List<Film> filmler)
        {
            int i = 0;
            foreach (Film film in filmler)
            {
                Console.WriteLine(i + " => " + film.film_info()); i++;
            }
        }

        private static void goster_film_detay(Film secilen_film)
        {
            Console.WriteLine("******** Method Çıktısı ******");
            Console.WriteLine("Film Adı: " + secilen_film.film_isim);
            Console.WriteLine("Film Türü: " + secilen_film.film_turu);
            Console.WriteLine("Yapım Yılı:" + secilen_film.film_sene);
            Console.WriteLine("Yönetmen: " + secilen_film.film_yonetmen);
            Console.WriteLine("Oyuncular: " + secilen_film.film_basrol);
        }

        private static uint user_input_film_id(int film_say)
        {
            Console.WriteLine("Film hakkında bilgiye erişmek için film numarasını yazınız:");
            string film_id_str = Console.ReadLine();
            uint film_id;
            bool film_input = UInt32.TryParse(film_id_str, out film_id);
            if (film_input && film_id < film_say)
            {
                return film_id;
            }
            else
            {
                return user_input_film_id(film_say);
            }
        }

        private static List<Film> film_listesi_as_list()
        {
            List<Film> filmler = new List<Film>();
            filmler.Add(new Film("Esaretin Bedeli", "Drama", 1994, "Frank Darabot", "Tim Robbins; Morgan Freeman; Bob Gunton"));
            filmler.Add(new Film("The Shining", "Korku", 1980, "Stanley Kubrick", "Jack Nickolson; Shalley Duvall"));
            filmler.Add(new Film("Shutter Island", "Gerilim", 2009, "Martin Scorsese", "Leonardo De Caprio; Emily Mortimer"));
            return filmler;
        }

        private static void yeni_film_liste()
        {
            List<Film> filmler = new List<Film>();
            filmler.Add(new Film("Esaretin Bedeli", "Drama", 1994, "Frank Darabot", "Tim Robbins; Morgan Freeman; Bob Gunton"));
            filmler.Add(new Film("The Shining", "Korku", 1980, "Stanley Kubrick", "Jack Nickolson; Shalley Duvall"));
            filmler.Add(new Film("Shutter Island", "Gerilim", 2009, "Martin Scorsese", "Leonardo De Caprio; Emily Mortimer"));
            //
            //for ile listeleme
            for(int i = 0; i < filmler.Count; i++)
            {
                Console.WriteLine(filmler[i].film_info());
            }

            //foreach ile listeleme
            Console.WriteLine("foreach ile listeleme:");
            foreach(Film film in filmler)
            {
                Console.WriteLine(film.film_info());
            }
        }

        private static void yeni_film_constructor()
        {
            Film film_1 = new Film("Esaretin Bedeli", "Drama", 1994, "Frank Darabot", "Tim Robbins; Morgan Freeman; Bob Gunton");
            Film film_2 = new Film("The Shining", "Korku", 1980, "Stanley Kubrick", "Jack Nickolson; Shalley Duvall");
            Film film_3 = new Film("Shutter Island", "Gerilim", 2009, "Martin Scorsese", "Leonardo De Caprio; Emily Mortimer");

            string film_bilgi = film_1.film_info(); Console.WriteLine(film_bilgi);
            Console.WriteLine(film_2.film_info());
            Console.WriteLine(film_3.film_info());
        }

        private static void yeni_film_nesneleri()
        {
            Film film_1 = new Film();
            film_1.film_isim = "Esaretin Bedeli";
            film_1.film_turu = "Drama";
            film_1.film_sene = 1994;
            film_1.film_yonetmen = "Frank Darabot";
            film_1.film_basrol = "Tim Robbins; Morgan Freeman; Bob Gunton";
            //
            Film film_2 = new Film();
            film_2.film_isim = "The Shining";
            film_2.film_turu = "Korku";
            film_2.film_sene = 1980;
            film_2.film_yonetmen = "Stanley Kubrick";
            film_2.film_basrol = "Jack Nickolson; Shalley Duvall";
            //
            Film film_3 = new Film();
            film_3.film_isim = "Shutter Island";
            film_3.film_turu = "Gerilim";
            film_3.film_sene = 2009;
            film_3.film_yonetmen = "Martin Scorsese";
            film_3.film_basrol = "Leonardo De Caprio; Emily Mortimer";

            string film_bilgi = film_1.film_info();Console.WriteLine(film_bilgi);
            Console.WriteLine(film_2.film_info());
            Console.WriteLine(film_3.film_info());

        }
    }

    class Sekil
    {
        string hangi_sekil="";
        double a, b, c;
        public Sekil(double a)
        {
            Console.WriteLine("Bu bir karedir");
            this.a = a;
            this.hangi_sekil = "kare";
        }

        public Sekil(double en, double boy)
        {
            Console.WriteLine("Bu bir Diktörtgendir");
            this.a = en;
            this.b = boy;
            this.hangi_sekil = "dikdortgen";
        }

        public Sekil(double a, double b, double c)
        {
            Console.WriteLine("Bu bir Üçgendir");
            this.hangi_sekil = "ucgen";
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Cevre()
        {
            switch (this.hangi_sekil)
            {
                case "kare":
                    return 4 * this.a;
                case "diktorgen":
                    return 2 * (this.a + this.b);
                case "ucgen":
                    return this.a + this.b + this.c;
                default:
                    return 0;
            }
        }
    }
        class Film
        {
        public string film_isim;
        public string film_turu;
        public int film_sene;
        public string film_yonetmen;
        public string film_basrol;
        string film_bilgi;
        public Film()
        {

        }

        public Film(string film_isim, string film_turu, int film_sene, string film_yonetmen, string film_basrol)
        {
            this.film_isim = film_isim;
            this.film_turu = film_turu;
            this.film_sene = film_sene;
            this.film_yonetmen = film_yonetmen;
            this.film_basrol = film_basrol;
        }

        public string film_info()
        {
            film_bilgi = film_isim + ", " + film_turu + ", sene:"+film_sene;
            return film_bilgi;
        }

        public string film_basrol_yonetmen()
        {
            return prv_film_basrol_yonetmen();
        }

        private string prv_film_basrol_yonetmen()
        {
            return "Yonetmen:" + this.film_yonetmen + ", \n Oyuncular: " + this.film_basrol;
        }

        public void goster_film_detay()
        {
            Console.WriteLine("******** Class Method Çıktısı *****");
            Console.WriteLine("Film Adı: " + this.film_isim);
            Console.WriteLine("Film Türü: " + this.film_turu);
            Console.WriteLine("Yapım Yılı:" + this.film_sene);
            Console.WriteLine("Yönetmen: " + this.film_yonetmen);
            Console.WriteLine("Oyuncular: " + this.film_basrol);
        }
    }
}
