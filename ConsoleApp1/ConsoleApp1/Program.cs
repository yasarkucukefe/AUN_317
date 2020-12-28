using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //getHavaDurumuFromInternet();
            //getHavaDurumu_FromInternet("Izmir", "tr");
            //getHavaDurumu_FromInternet("Ankara", "tr");
            //getHavaDurumu_FromInternet("Istanbul", "tr");
            //downloadDosyaFromInternet("https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Robby_Naish_a-1.jpg/350px-Robby_Naish_a-1.jpg");
            web_adress_icerik();
            Console.ReadLine();
        }

        private static async void web_adress_icerik()
        {
            string url = "http://plantdx.com/docs/eltresis/";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var data = await response.Content.ReadAsStringAsync();
                web_data_parse(data,url);
            }
        }

        private static void web_data_parse(string html,string url)
        {
            //Console.WriteLine(html);
            string[] href_arr = html.Split("<a href=");
            foreach(string href in href_arr)
            {
                if (href.StartsWith("\""))
                {
                    string[] dosyalar = href.Split("\"");
                    if (dosyalar.Length > 0)
                    {
                        string dosya_ad = dosyalar[1];
                        if (dosya_ad.EndsWith(".docx"))
                        {
                            Console.WriteLine("Download: "+dosya_ad);
                            downloadDosya_FromInternet(url + dosya_ad,dosya_ad);
                        }
                    }
                }
                
            }
        }

        private static void downloadDosya_FromInternet(string download_link, string dosya_ad)
        {
            Console.WriteLine("Dosya indiriliyor... " + download_link);
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(download_Completed);
            try
            {
                myWebClient.DownloadFileAsync(new Uri(download_link), dosya_ad);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught. Download error.", e);
            }
        }
        private static void download_Completed(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download completed.");            
        }


        private static void downloadDosyaFromInternet(string download_link)
        {
            Console.WriteLine("Dosya indiriliyor... " + download_link);
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
            try
            {
                myWebClient.DownloadFileAsync(new Uri(download_link), "resim.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught. Download error.", e);
            }
        }

        private static void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Download completed.");
            if (System.IO.File.Exists("resim.jpg"))
            {
                Console.WriteLine("resim.jpg dosyasına kayıt edildi.");
            }
            else
            {
                Console.WriteLine("İndirilen dosya kayıt edilemedi.");
            }
        }

        private async static void getHavaDurumu_FromInternet(string sehir, string ulke_kodu)
        {
            Console.WriteLine("Hava durumu API servisinden veri alınıyor ..."+sehir);
            string api_q = sehir + "," + ulke_kodu;
            string request_url = "http://api.openweathermap.org/data/2.5/weather?q="+api_q+"&APPID=bd99985d8a5acb4bb64ea5fc7c26ee23";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(request_url);
                var data = await response.Content.ReadAsStringAsync();
                parseJSONhavaDurumu(data);
            }
        }

        private async static void getHavaDurumuFromInternet()
        {
            Console.WriteLine("Hava durumu API servisinden veri alınıyor ...");
            string request_url = "http://api.openweathermap.org/data/2.5/weather?q=Istanbul,tr&APPID=bd99985d8a5acb4bb64ea5fc7c26ee23";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(request_url);
                var data = await response.Content.ReadAsStringAsync();
                parseJSON_havaDurumu(data);
            }
        }

        private static void parseJSON_havaDurumu(string json_str)
        {
            if (isValidJSONformat(json_str)) { Console.WriteLine("JSON formatında değil."); return; }
            try
            {
                dynamic json_data = JsonConvert.DeserializeObject(json_str);
                string sehir = (string)json_data["name"];
                string output = "---------\n"+sehir + " için hava durumu:";
                //Console.WriteLine("{0} için hava durumu:", sehir);
                double sicaklik = json_data["main"]["temp"] - 273;//Kelvin->C
                double hissedilen = json_data["main"]["feels_like"] - 273;//Kelvin->C
                int nem = json_data["main"]["humidity"];
                output += "\nSıcaklık:" + sicaklik.ToString("0.#");
                output += "\nHissedilen:" + hissedilen.ToString("0.#");
                output += "\nNem:" + nem;
                //
                JArray hava_durumu = json_data["weather"];
                JObject json_hava_durumu = (JObject)hava_durumu[0];
                string durum = (string)json_hava_durumu["description"];
                output += "\nHava durumu: " + durum;
                Console.WriteLine(output);
            }
            catch (Exception)
            {
                Console.WriteLine("JSON format hatası.");
            }

        }

        private static void parseJSONhavaDurumu(string json_str)
        {
            if (isValidJSONformat(json_str)) { Console.WriteLine("JSON formatında değil.");return; }
            try
            {
                dynamic json_data = JsonConvert.DeserializeObject(json_str);
                string sehir = (string)json_data["name"];
                Console.WriteLine("{0} için hava durumu:",sehir);
                double sicaklik = json_data["main"]["temp"]-273;//Kelvin->C
                double hissedilen = json_data["main"]["feels_like"] - 273;//Kelvin->C
                int nem = json_data["main"]["humidity"];
                Console.WriteLine("Sıcaklık:"+sicaklik.ToString("0.#"));
                Console.WriteLine("Hissedilen:"+hissedilen.ToString("0.#"));
                Console.WriteLine("Nem:" + nem);
                //
                JArray hava_durumu = json_data["weather"];
                JObject json_hava_durumu = (JObject) hava_durumu[0];
                string durum = (string) json_hava_durumu["description"];
                Console.WriteLine("Hava durumu: "+ durum);
            }
            catch (Exception)
            {
                Console.WriteLine("JSON format hatası.");
            }
            
        }

        private static bool isValidJSONformat(string json_string)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject(json_string);
                return false;
            }
            catch (Exception)
            {
                return true;                
            }
        }

    }
}
