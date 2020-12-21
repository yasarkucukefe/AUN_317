using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hafta_12
{
    class Program
    {
        public delegate void myDelegate(String input);
        public delegate bool baskaDelagate(int deger, bool durum);
        public delegate void yeniUrunDelegate(String urun, int urun_grubu);

        public static int k_progress = 0;
        public static int[] kr_progress = { 0 };
        public static bool[] kv_progress = { false, false, false, false };
        static void Main(string[] args)
        {
            //event_ornek();
            //event_ornek_magaza();
            async_await_ornek_kahvalti();
        }

        private static void async_await_ornek_kahvalti()
        {
            //Kahvaltı
            //tost, çay, omlet, peynir tabağı
            tostu_hazirla();
            cayi_demle();
            omleti_hazirla();
            //peynir_tabak();

            var t1 = new Thread(new ThreadStart(peynir_tabak));
            t1.Start();
            //Task.WaitAll(t1);
            Console.ReadLine();
            
        }

        private static void kahvalti_hazir_mi()
        {
            if (kr_progress[0] == 4) { Console.WriteLine("Kahvaltı hazır."); }
        }

        private static void kahvalti_hazir_mi_bool()
        {
            foreach(bool durum in kv_progress) { if (!durum) { return; } }
            Console.WriteLine("Kahvaltı hazır.");
        }

        private static async void peynir_tabak()
        {
            await Task.Run(() =>
            {
               Console.WriteLine("Peynir tabağı hazırlanıyor...");
               Thread.Sleep(3000);
               Console.WriteLine("Peynir tabağı hazır.");
                
                lock (kr_progress)
                {
                    kr_progress[0] += 1;
                }               

                kahvalti_hazir_mi();
                
                kv_progress[0] = true; 
                kahvalti_hazir_mi_bool();
            });
           
        }

        private static async void omleti_hazirla()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Omlet hazırlanıyor...");
                Thread.Sleep(4000);
                Console.WriteLine("Omlet hazır.");

                lock (kr_progress)
                {
                    kr_progress[0] += 1;
                }
                kahvalti_hazir_mi();

                kv_progress[1] = true;
                kahvalti_hazir_mi_bool();
            });
            
        }

        private static async void cayi_demle()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Çayı demleniyor...");
                Thread.Sleep(3000);
                Console.WriteLine("Çay hazır.");

                lock (kr_progress)
                {
                    kr_progress[0] += 1;
                }
                kahvalti_hazir_mi();

                kv_progress[2] = true;
                kahvalti_hazir_mi_bool();
            });
        }

        private static async void tostu_hazirla()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Tost hazırlanıyor...");
                Thread.Sleep(3000);
                Console.WriteLine("Tost hazır.");

                lock (kr_progress)
                {
                    kr_progress[0] += 1;
                }
                kahvalti_hazir_mi();

                kv_progress[3] = true;
                kahvalti_hazir_mi_bool();
            });
        }

        private static void event_ornek_magaza()
        {
            Urun urun = new Urun();
            urun.yeniUrunEklendi += new yeniUrunDelegate(urun_kataloguna_ekle);
            urun.yeniUrunEklendi += new yeniUrunDelegate(urun_hakkinda_eposta);
            urun.yeniUrunEklendi += new yeniUrunDelegate(urun_web_sitesinde_goster);
            urun.yeniUrunEklendi += (String urun, int grup) => Console.WriteLine("Log: {0} eklendi. Grup {1}", urun, grup);
            urun.set_urun("Asus Laptop", 1);
        }

        private static void urun_web_sitesinde_goster(string urun_ad, int urun_grup)
        {
            Console.WriteLine("Yeni ürünü web sitesinde göster.");
        }

        private static void urun_hakkinda_eposta(string urun_ad, int urun_grup)
        {
            Console.WriteLine("Yeni ürün hakkında e-posta gönder.");
        }

        private static void urun_kataloguna_ekle(string urun_ad, int urun_grup)
        {
            Console.WriteLine("Yeni ürün kataloğa eklendi.");
        }

        public class Urun
        {
            private string urun_name;
            private int urun_grubu;

            public event yeniUrunDelegate yeniUrunEklendi;

            public void set_urun(string name, int grup)
            {
                this.urun_name = name;
                this.urun_grubu = grup;
                this.yeniUrunEklendi(name, grup);
            }

        }

        private static void event_ornek()
        {
            EventPublisher obj = new EventPublisher();
            obj.eventGerceklesti += new myDelegate(event_print_name);
            obj.eventGerceklesti += new myDelegate(event_add_name);

            obj.eventGerceklesti += delegate (string val)
            {
                Console.WriteLine("event log: " + val);
            };

            obj.eventGerceklesti += (string val) => Console.WriteLine("Lambda " + val);

            obj.urunName = "Android Telefon";
            Console.WriteLine(obj.urunName);
        }

        private static void event_print_name(String urun)
        {
            Console.WriteLine("Urun Adı {0}", urun);
        }
        private static void event_add_name(String urun)
        {
            Console.WriteLine("Urun stoğa eklendi {0}", urun);
        }


        private class EventPublisher
        {
            private string deger;

            public event myDelegate eventGerceklesti;

            public string urunName
            {
                set
                {
                    this.deger = value;
                    this.eventGerceklesti(deger);
                }
                get
                {
                    return this.deger;
                }
            }

        }


        public interface sekil
        {
            double cevre();
            double alan();
        }

        public class kare:sekil
        {
            public double a;
            public double cevre() { return 4 * a; }
            public double alan() { return a * a; }
        }

        public class daire:sekil
        {
            public double r;
            public double cevre() { return Math.PI*r*2; }
            public double alan() { return Math.PI * r * r; }
        }


    }
}
