using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void eventDelegate(String urun, int urun_grubu);
        public delegate void baskaDelegate(String urun);

        static void Main(string[] args)
        {
            //eventOrnek();
            //httpIstekOrnek();
            havaDurumu();
            Console.ReadLine();
        }

        static async void httpIstekOrnek()
        {
            string url = "https://openweathermap.org/";
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
        }

        static async void havaDurumu()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Istanbul&appid=90bf1f6964f09d9036c80992c58550d7";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var data = await response.Content.ReadAsStringAsync();
                parseHavaDurumuJson(data);
            }
        }

        static void parseHavaDurumuJson(string json)
        {
            //Console.WriteLine(json);
            try
            {
                dynamic obj = JsonConvert.DeserializeObject(json);
                string sehir = (String) obj["name"];
                string durum = (String) (obj["weather"][0]["description"]);
                double temp = (double)(obj["main"]["temp"]) - 273.0;
                string tempStr = String.Format("{0:F1}", temp);
                Console.WriteLine($"{sehir} \n {durum} \n Sıcaklık: {tempStr} C.");
            }
            catch
            {
                Console.WriteLine("Hatalı JSON formatı");
            }
        }

        static void eventOrnek()
        {
            Urun urun = new Urun();
            urun.yeniUrunEklendi += new eventDelegate(yeniUrunMesajGonder);
            urun.yeniUrunEklendi += new eventDelegate(yeniMalzemeSiparisi);
            urun.yeniUrunEklendi += new eventDelegate(yeniUrunuWebSitesindeGoster);
            urun.yeniUrunEklendi += (String urun, int grup) => Console.WriteLine($"{urun} için event metodları çalıştırıldı. Ürün grubu: {grup}");
            urun.yeni_urun("Çikolatalı Lokma", 5);
            //
            Urun kahve = new Urun();
            kahve.yeniUrunEklendi += new eventDelegate(fiyatListesiniGuncelle);
            kahve.urunIadeEvent += (String urun_) => Console.WriteLine($"{urun_} 'ü beğenmediniz mi?");
            kahve.yeni_urun("Americano", 10);
            kahve.iade_urun();

        }

        private static void fiyatListesiniGuncelle(string urun, int fiyat)
        {
            Console.WriteLine($"Ürün adı: {urun}, fiyat=>{fiyat}");
        }

        private static void yeniUrunMesajGonder(string urun, int grup)
        {
            Console.WriteLine("Yeni ürün hakkında e-posta gönderilsin.");
        }

        private static void yeniMalzemeSiparisi(string urun, int grup)
        {
            Console.WriteLine("Yeni ürün için malzeme sipariş et.");
        }

        private static void yeniUrunuWebSitesindeGoster(string urun, int grup)
        {
            Console.WriteLine("Yeni ürünü web sitemizde göster.");
        }


        public class Urun
        {
            private string urun_ad;
            private int urun_grubu;

            public event eventDelegate yeniUrunEklendi;
            public event baskaDelegate urunIadeEvent;

            public void yeni_urun(String urun_ad_, int urun_grubu_)
            {
                this.urun_ad = urun_ad_;
                this.urun_grubu = urun_grubu_;
                this.yeniUrunEklendi(urun_ad_, urun_grubu_);
            }

            public void iade_urun()
            {
                this.urunIadeEvent(this.urun_ad);
            }
        }

    }
}
