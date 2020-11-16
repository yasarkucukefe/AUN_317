using System;
using System.Collections.Generic;
using System.Linq;

namespace Hafta_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // ternary_if_operator(10);
            // for_while_loop_method();
            // for_break_continue_method();
            // film_listesi();
            // list_array_film_listesi();
            Genre genre = new Genre();
            genre.Name = "Hello";
            Console.WriteLine(genre.Name);
            
        }

        private class Genre
        {
            public String Name;
        }

        private static void list_array_film_listesi()
        {
            List<string> film_ismi = new List<string>();
            List<string> film_turu = new List<string>();
            List<int> film_sene = new List<int>();
            List<string> film_yonetmen = new List<string>();
            List<string> film_basroller = new List<string>();

            List<string> marketten_al = new List<string>();
            //
            //Film isimleri
            film_ismi.Add("Esaretin Bedeli");
            film_ismi.Add("The Shining");
            film_ismi.Add("Shutter Island");
            //film_turleri
            film_turu.Add("Drama");
            film_turu.Add("Korku");
            film_turu.Add("Gerilim");
            //Film yılları
            film_sene.Add(1994);
            film_sene.Add(1980);
            film_sene.Add(2009);
            //Film Yönetmenleri
            film_yonetmen.Add("Frank Darabot");
            film_yonetmen.Add("Stanley Kubrick");
            film_yonetmen.Add("Martin Scorsese");
            //Başroller
            film_basroller.Add("Tim Robbins; Morgan Freeman; Bob Gunton");
            film_basroller.Add("Jack Nickolson; Shalley Duvall");
            film_basroller.Add("Leonardo De Caprio; Emily Mortimer");

            Console.WriteLine("Film arşivinizde " + film_ismi.Count() + " film bulunuyor.");
            //Film listesi - seçenek-1
            //for(int i = 0; i < film_ismi.Count(); i++)
            //{
            //    Console.WriteLine(film_ismi[i] + " (" + i + ")");
            //}
            //Seçenek-2
            // Console.WriteLine("Foreach ile listeleme");
            int j = 0;
            foreach(string film in film_ismi)
            {
                Console.WriteLine(film + " (" + j + ")");j++;
            }
            //User input
            int film_id = (int) user_input_film_id(film_ismi.Count());
            //Film bilgileri
            Console.WriteLine("*************");
            Console.WriteLine(film_ismi[film_id].ToUpper());
            Console.WriteLine("Yönetmen:" + film_yonetmen[film_id]);
            Console.WriteLine("Tür:" + film_turu[film_id]);
            Console.WriteLine("Yapım Yılı: " + film_sene[film_id]);
            Console.WriteLine("Başrol oyuncaları: " + film_basroller[film_id]);
        }

        private static void film_listesi()
        {
            int arr_boyut = 100;
            string[] film_ismi = new string[arr_boyut];
            string[] film_turu = new string[arr_boyut];
            int[] film_sene = new int[arr_boyut];
            string[] film_yonetmen = new string[arr_boyut];
            string[] film_basroller = new string[arr_boyut];

            int i = 0;
            //Esaretin Bedeli
            film_ismi[i] = "Esaretin Bedeli";
            film_turu[i] = "Drama";
            film_sene[i] = 1994;
            film_yonetmen[i] = "Frank Darabot";
            film_basroller[i] = "Tim Robbins; Morgan Freeman; Bob Gunton";

            i++;//The shining 
            film_ismi[i] = "The Shining";
            film_turu[i] = "Korku";
            film_sene[i] = 1980;
            film_yonetmen[i] = "Stanley Kubrick";
            film_basroller[i] = "Jack Nickolson; Shalley Duvall";

            i++;//Shutter Island
            film_ismi[i] = "Shutter Island";
            film_turu[i] = "Gerilim";
            film_sene[i] = 2009;
            film_yonetmen[i] = "Martin Scorsese";
            film_basroller[i] = "Leonardo De Caprio; Emily Mortimer";

            //Output
            Console.WriteLine("Film arşivinizin " + film_ismi.Length + " film kapasitesi var.");
            int film_say = 0;
            for (int j = 0; j < film_ismi.Length; j++)
            {
                string film = string.IsNullOrEmpty(film_ismi[j]) ? "null / empty" : film_ismi[j] + " ("+j+")";   
                if(film.Equals("null / empty")) { film_say = j; break; }
                Console.WriteLine(film);
            }

            Console.WriteLine("Film arşivinizde " + film_say + " film bulunuyor.");


            uint film_id = user_input_film_id(film_say);
            Console.WriteLine("*************");
            Console.WriteLine(film_ismi[film_id].ToUpper());
            Console.WriteLine("Yönetmen:" + film_yonetmen[film_id]);
            Console.WriteLine("Tür:" + film_turu[film_id]);
            Console.WriteLine("Yapım Yılı: " + film_sene[film_id]);
            Console.WriteLine("Başrol oyuncaları: " + film_basroller[film_id]);

        }

        private static uint user_input_film_id(int film_say)
        {
            Console.WriteLine("Film hakkında bilgiye erişmek için parantez içindeki sayıyı yazınız:");
            string film_id_str = Console.ReadLine();
            uint film_id;
            bool film_input = UInt32.TryParse(film_id_str, out film_id);
            if (film_input && film_id<film_say)
            {
                return film_id;
            }
            else
            {
                return user_input_film_id(film_say);
            }
        }

        private static void for_break_continue_method()
        {
            string[] modeller = { "Ford", "Toyota", "Tesla", "Nissan", "TOGG" };
            //break : döngü tamamen durdurulur
            Console.WriteLine("Break");
            for (int i = 0; i < modeller.Length; i++)
            {
                Console.WriteLine("Model =>" + modeller[i]);
                if (i > 1) { break; }
                Console.WriteLine("i<=1 ==> " + modeller[i]);
            }
            //Continue: geçerli olan döngü devam etmez
            Console.WriteLine("Continue");
            for (int i = 0; i < modeller.Length; i++)
            {
                Console.WriteLine("Model =>" + modeller[i]);
                if (i > 1) { continue; }
                Console.WriteLine("i<=1 ==> " + modeller[i]);
            }
        }

        private static void for_while_loop_method()
        {
            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for loop: i=>"+i);
            }
            //String array
            string[] modeller = { "Ford", "Toyota", "Tesla" };
            for (int i=0; i < modeller.Length; i++)
            {
                Console.WriteLine("Model =>" + modeller[i]);
            }

            // While
            int j = 0;
            while (j<10)
            {
                Console.WriteLine("while loop: j=>" + j);
                j++;
            }

            // do while j=10
            do
            {
                Console.WriteLine("do while loop: j=>" + j);
                j++;
            } while (j < 10);


        }

        private static void ternary_if_operator(int a) //console output "az" if a <10; "fazla" if a>=10
        {
            // sonuc = kosul ? durum 1 : durum 2
            
            String mesaj = a<10 ? "az" : "fazla";

            /* 
            if (a < 10) 
            {
                mesaj = "az";
            }
            else
            {
                mesaj = "fazla";
            }
            */

            Console.WriteLine(mesaj);
            
        }
    }
}
