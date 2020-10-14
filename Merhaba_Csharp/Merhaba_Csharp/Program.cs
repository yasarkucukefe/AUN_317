using System;
using System.Linq;

namespace Merhaba_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Datatype çeşitleri:");
            //Açıklama amaçlı yorumlar bu şekilde yazılabilir.
            // Datatypes: int, double, char, string, bool
            // Arrays

            /*
             int fiyat = 10;
             int miktar = 5;
             int toplam = fiyat * miktar;
            */

            //Console.WriteLine($"Toplam tutar = {toplam}");

            /*

            String metin = "The world is bracing for a new wave of Covid-19 infections, as the coronavirus pandemic has infected more than 38.1 million people and killed more than 1,080,000 globally since late January. Efforts many countries took to stamp out the pneumonia-like illness led to entire nations enforcing lockdowns, widespread halts of international travel, mass layoffs and battered financial markets. Recent attempts to revive social life and financial activities have resulted in another surge in cases and hospitalizations, though new drugs and improved care may help more people who get seriously ill survive.";

            Console.WriteLine(metin);

            string[] kelimeler = metin.Split();
            Console.WriteLine("--------------- Kelimeler------------");
            Console.WriteLine(kelimeler.Length + " kelime var.");
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            */

            string dosya_name = "Ydjq.d02.dadfa-da.dadfasd.asdfasdf-adfas.name_yeni.dwd.xlsx";
            Console.WriteLine(dosya_name);

            //Seçenek-1:
            string[] dosya_split = dosya_name.Split('.');
            int ext_pos = dosya_split.Length - 1;
            string dosya_ext = dosya_split[ext_pos];
            Console.WriteLine("Dosya uzantısı: " + dosya_ext);

            //Seçenek-2:
            string[] dosya_split_2 = dosya_name.Split('.');
            Console.WriteLine("Seçenek-2 ile Dosya uzantısı: " + dosya_split_2[dosya_split_2.Length-1]);


            //Seçenek-3:
            Console.WriteLine("Seçenek-3 Built-in C# LINQ fonksiyonu ile bulunan uzantı : " + dosya_name.Split('.').Last());
        


        }
    }
}
