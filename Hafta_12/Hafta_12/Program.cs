using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace Hafta_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hava_durumu("Istanbul");

            dosya_download("https://plantdxcdn.s3-us-west-2.amazonaws.com/start_plant_dx.png");

            Console.ReadLine();
        }

        private static async void dosya_download(string file_url)
        {
            using (var client = new HttpClient())
            {
                using(var stream = await client.GetStreamAsync(file_url))
                {
                    try
                    {
                        using (var fileStream = new FileStream("dosya.png", FileMode.Create))
                        {
                            await stream.CopyToAsync(fileStream);
                            Console.WriteLine("Dosya download tamamlandı.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Dosya zaten mevcut");
                    }
                    
                }
            }
        }

        private static async void hava_durumu(string sehir)
        {
            string api_key = "90bf1f6964f09d9036c80992c58550d7";
            string url = "https://api.openweathermap.org/data/2.5/weather";
            url = url + "?q=" + sehir + "&appid=" + api_key;

            // HttpClient()
            using(var client = new HttpClient())
            {
                Console.WriteLine("Url isteği gönderiyor...");
                var response = await client.GetAsync(url);
                var data = await response.Content.ReadAsStringAsync();
                json_hava_durumu(data);
            }
        }

        static void json_hava_durumu(string data)
        {
            try
            {
                dynamic obj = JsonConvert.DeserializeObject(data);
                string sehir = (string)obj["name"];
                string durum = (string)obj["weather"][0]["description"];
                double sicaklik = (double)(obj["main"]["temp"]) - 273.0;
                string tmp = String.Format("{0:F1}", sicaklik);
                Console.WriteLine($"{sehir} : {durum} \nSıcaklık:{tmp} C");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}