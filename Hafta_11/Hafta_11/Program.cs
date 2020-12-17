using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hafta_11
{
    public delegate void MyDelegate(string mesaj); //delegate
    class Program
    {
        static void Main(string[] args)
        {
            //sozluk_ornek(); //Dictionary
            //hashtable_ornek(); //Hashtable
            //tuple_ornek();
            //soru_ve_veri_girisi();
            //async_await_ornek();
            //delegate_ornek();
            delegate_ornek_2();
            Console.ReadLine();
        }

        private static void delegate_ornek_2()
        {
            islem_ve_delegate(Delegate_Metodu, "bordrolar hesaplansın.");
            islem_ve_delegate(Delegate_Metodu_2, " fazla mesailer hesaplandı.");
        }

        private static void delegate_ornek()
        {
            MyDelegate del = Delegate_Metodu;

            MyDelegate del_2 = (string msg) => Console.WriteLine("Delegate output Lambda: " + msg);

            del("Delegate del");
            del_2.Invoke("Delegate del_2");

        }

        private static void Delegate_Metodu(string msg)
        {
            Console.WriteLine("Delegate output: "+msg);
        }

        private static void Delegate_Metodu_2(string msg)
        {
            Console.WriteLine("Delegate-2 output: " + msg);
        }

        private static void islem_ve_delegate(MyDelegate xyz, string islem)
        {
            string sonuc = islem + " tamamlandı.";
            xyz(sonuc);
        }


        private static async void async_await_ornek()
        {
            method_1();
            method_2();
            int toplam = await method_3();
            method_4(toplam);
        }

        private static async void method_1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method-1 => " + i);
                    Thread.Sleep(1000);//Zaman işlem yapılıyor.
                }
            });
        }


        private static async void method_2()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Method-2 => " + i);
                    Thread.Sleep(500);//Zaman işlem yapılıyor.
                }
            });
        }

        private static async Task<int> method_3()
        {
            int toplam = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Method-3 => " + i);
                    Thread.Sleep(300);//Zaman işlem yapılıyor.
                    toplam += i;
                }
            });
            return toplam;
        }

        private static void method_4(int toplam)
        {
            Console.WriteLine($"Method-3 i-toplam : {toplam} ");
        }


        private static void soru_ve_veri_girisi()
        {

            //string user_input = Util.sor("Yaşınız");
            int yas = Util.sor_tamsayi("Yaşınız?",true);
            int dogum_yili = 2020 - yas;
            Console.WriteLine($"Doğum yılınız {dogum_yili}");
            //

        }

        private static void tuple_ornek()
        {
            var renkler = Tuple.Create("Siyah","Beyaz","Mavi","Kırmızı","Yeşil","Sarı","Pembe","Mor");
            Console.WriteLine(renkler.Item2); //Beyaz
            Console.WriteLine(renkler.Rest); //Mor
            //8'den fazla eleman ihtiyacında ValueTuple kullanılabilir (.NET 4.7 ve sonrası için)


        }

        private static void hashtable_ornek()
        {
            Hashtable rakamIsimleri = new Hashtable();
            rakamIsimleri.Add(1, "Bir");
            rakamIsimleri.Add(2, "İki");
            rakamIsimleri.Add(3, "Üç");
            rakamIsimleri.Add("4", "Dört");
            rakamIsimleri.Add("5", "Beş");

            int rakam = 5;
            if (rakamIsimleri.ContainsKey(rakam))
            {
                Console.WriteLine(rakamIsimleri[rakam]);
            }
            else
            {
                Console.WriteLine($"{rakam} anahtar değeri mevcut değil.");                
            }

            string rakam_ = "5";
            if (rakamIsimleri.ContainsKey(rakam_))
            {
                Console.WriteLine(rakamIsimleri[rakam_]);
            }
            else
            {
                Console.WriteLine($"{rakam_} anahtar değeri mevcut değil.");
            }

            foreach (DictionaryEntry de in rakamIsimleri)
            {
                Console.WriteLine($"Key: {de.Key}, Deger: {de.Value}");
            }

        }

        private static void sozluk_ornek()
        {
            var sehirler = new Dictionary<string, string>()
            {
                {"İngiltere", "Londra, Manchester, Birmingham" },
                {"Türkiye","Ankara, İstanbul, İzmir" },
                {"Hindistan","Yeni Delhi, Mumbai, Bangalore" }
            };

            string ulke = "Fransa";
            if (sehirler.ContainsKey(ulke))
            {
                Console.WriteLine(sehirler[ulke]);
            }
            else
            {
                Console.WriteLine($"{ulke} sözlükte bulunmuyor.");
            }
            
            for(int i=0; i<sehirler.Count; i++)
            {
                Console.WriteLine("Key: {0}, Deger: {1}", sehirler.ElementAt(i).Key, sehirler.ElementAt(i).Value);
            }

            //Remove
            if (sehirler.ContainsKey(ulke))
            {
                sehirler.Remove(ulke);
            }

            //update
            if (sehirler.ContainsKey(ulke))
            {
                sehirler[ulke]="yeni deger";
            }

            //Yeni Ekleme
            sehirler.Add("Almanya", "Berlin,Köln,Münih");

            
        }
    }
}
