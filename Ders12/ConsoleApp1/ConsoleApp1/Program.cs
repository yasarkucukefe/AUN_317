using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate int islem(String a, String b);
        public delegate bool logicalIslem(int a, String b, bool c);

        static void Main(string[] args)
        {
            //async_await_ornek();
            //odev_ornek();
            //await_ornek();
            hesapMakinesi();
            Console.ReadLine();
        }



        static void hesapMakinesi()
        {
            Console.WriteLine("İşlem seçiniz: 0->Toplam, 1->Çarpma");
            string islem = Console.ReadLine();

            Console.WriteLine("İlk rakam:");
            string rakam1 = Console.ReadLine();
            Console.WriteLine("İkinci rakam:");
            string rakam2 = Console.ReadLine();
            int sonuc = 0;

            islem islemTopla = new islem(toplama);
            islem islemCarpma = new islem(carpma);

            if (islem.Equals("0")){
                sonuc = islemYap(rakam1, rakam2, islemTopla);
            }else if (islem.Equals("1"))
            {
                sonuc = islemYap(rakam1, rakam2, islemCarpma));
            }
            else
            {
                sonuc = -1;
            }
            Console.WriteLine($"Sonuc: {sonuc}");
        }

        static int islemYap(string rakam1, string rakam2, islem islemInstance)
        {
            int sonuc = islemInstance(rakam1, rakam2);
            return sonuc;
        }


        static int toplama(string rakam1, string rakam2)
        {
            int sonuc = 0;
            sonuc = Convert.ToInt32(rakam1) + Convert.ToInt32(rakam2);
            return sonuc;
        }

        static int carpma(string rakam1, string rakam2)
        {
            int sonuc = 0;
            sonuc = Convert.ToInt32(rakam1) * Convert.ToInt32(rakam2);
            return sonuc;
        }











        static async void await_ornek()
        {
            int toplam = await method();
            Console.WriteLine(toplam);
        }

        static async Task<int> method()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    count += 1;
                }
            });
            return count;
        }

        static void odev_ornek()
        {
            Task toplam1 = new Task(() => topla(1, 10));
            Task toplam2 = new Task(() => topla(11, 20));
            Task toplam3 = new Task(() => topla(21, 30));

            toplam1.Start();
            toplam2.Start();
            toplam3.Start();

            Task.WaitAll(toplam1, toplam2, toplam3);
        }

        static async Task<int> topla(int ilk, int son)
        {
            Console.WriteLine($"Toplam hesapla: {ilk}->{son}");
            int sum = 0;
            for(int i=ilk; i<=son; i++)
            {
                sum = sum + i;
                Console.WriteLine($"İşlem {ilk}->{son} => {sum}");
                Thread.Sleep(1000);
            }
            Console.WriteLine(sum);
            return sum;
        }

        static void async_await_ornek()
        {
            islem_1(10);
            islem_2(5);
            
        }

        static async Task islem_1(int say)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < say; i++)
                {
                    //Console.WriteLine("Rakam => " + i);    
                    Console.WriteLine($"İşlem -1 rakam => {i}");
                    Thread.Sleep(1000);
                }
            });
        }

        static async Task islem_2(int say)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < say; i++)
                {
                    //Console.WriteLine("Rakam => " + i);    
                    Console.WriteLine($"İşlem-2 rakam => {i}");
                    Thread.Sleep(2000);
                };
            });
            
        }
    }
}
