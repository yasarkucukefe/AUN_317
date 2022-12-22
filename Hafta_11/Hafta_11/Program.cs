namespace Hafta_11
{
    internal class Program
    {
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
        static void Main(string[] args)
        {
            //kullanUtil();
            //kahvaltiHazirla();
            //KahvaltiHazirla_Async();
            //ornekTask();
            //dosyaOkuSync();
            dosyaOkuAsync();
            Console.ReadKey();
        }

        static private void dosyaOkuAsync()
        {
            Task task1 = new Task(() => dosyaOku("dosya1.txt"));
            Task task2 = new Task(() => dosyaOku("dosya2.txt"));
            Task task3 = new Task(() => dosyaOku("dosya3.txt"));
            var watch = System.Diagnostics.Stopwatch.StartNew();
            task1.Start();
            task2.Start();
            task3.Start();
            Task.WaitAll(task1, task2, task3);
            Console.WriteLine("Toplam Süre (Async): " + watch.Elapsed.ToString());
        }

        static private void dosyaOkuSync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string dosya1_icerik = dosyaOku("dosya1.txt");
            string dosya2_icerik = dosyaOku("dosya2.txt");
            string dosya3_icerik = dosyaOku("dosya3.txt");
            Console.WriteLine("Toplam Süre (Sync): " + watch.Elapsed.ToString());
            Console.WriteLine(dosya1_icerik);
            Console.WriteLine(dosya2_icerik);
            Console.WriteLine(dosya3_icerik);

        }

        static private string dosyaOku(string dosya)
        {
            Console.WriteLine(dosya + " okunuyor...");
            try
            {
                using (StreamReader reader = new StreamReader(dosya))
                {
                    string okunan = reader.ReadToEnd();
                    Console.WriteLine(dosya + " okundu.");
                    return okunan;
                }
            }
            catch (FileNotFoundException)
            {

                return "Dosya bulunamadı. " + dosya;
            }
        }

        static private void ornekTask()
        {
            Task task_cay = new Task(cayiDemle);
            Task task_tost = new Task(tostYap);
            Task task_yumurta = new Task(yumurtaKaynat);
            Task task_pankek = new Task(panKekYap);

            task_cay.Start();
            task_tost.Start();
            task_yumurta.Start();
            task_pankek.Start();

            Task.WaitAll(task_cay, task_tost, task_yumurta, task_pankek);
            Console.WriteLine("Kahvaltı tamamlandı");
        }

        static private void panKekYap()
        {
            Console.WriteLine("PanKek hazırlanıyor...");
            Thread.Sleep(10000);
            Console.WriteLine("PanKek hazır. Afiyet olsun :)");
        }

        static private void KahvaltiHazirla_Async()
        {
            cayi_Demle_Async();
            yumurta_Kaynat_Async();
            tost_yap_Async();
            PanKek_Async();
        }

        static private async Task PanKek_Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("PanKek hazırlanıyor...");
                Thread.Sleep(10000);
                Console.WriteLine("PanKek hazır. Afiyet olsun :)");
            });
        }

        static private async Task cayi_Demle_Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Çay demleniyor...");
                Thread.Sleep(5000);
                Console.WriteLine("Çay hazır.");
            });
        }

        static private async Task yumurta_Kaynat_Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Yumurta kaynatılıyor...");
                Thread.Sleep(3000);
                Console.WriteLine("Yumurta hazır.");
            });
        }

        static private async Task tost_yap_Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Tost yapılıyor...");
                Thread.Sleep(2000);
                Console.WriteLine("Tost hazır.");
            });
        }


        static private String kahvaltiHazirla()
        {
            // Metodlar sıra ile çalıştırılıyor. Bir tanesi bittikten sonra diğer başlıyor.
            cayiDemle();
            tostYap();
            yumurtaKaynat();
            return "Kahvaltı hazır.";
        }

        private static void yumurtaKaynat()
        {
            Console.WriteLine("Yumurta kaynatılıyor...");
            Thread.Sleep(3000);
            Console.WriteLine("Yumurta hazır.");
        }

        private static void tostYap()
        {
            Console.WriteLine("Tost yapılıyor...");
            Thread.Sleep(2000);
            Console.WriteLine("Tost hazır.");
        }

        static private void cayiDemle()
        {
            Console.WriteLine("Çay demleniyor...");
            Thread.Sleep(5000);
            Console.WriteLine("Çay hazır.");
        }


        static private void kullanUtil()
        {
            Util util = new Util();
            util.tekSayilar(5, 12);
            util.ciftSayilar(8, 15);
            util.allCaps("Günlerden Perşembe");
        }
    }

}