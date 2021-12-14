using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate int SablonFonk1(int a, int b, bool kontrol, string mesaj);

        private delegate int IkiRakamTopla(int a, int b);

        private delegate void Yaz(string a);
        
        private static int genelToplam;

        static int fonk1(int i, int j, bool test, string msg)
        {
            return 1;
        }

        static int fonk2(int i, int j, bool test, string msg)
        {
            return 0;
        }


        static void Main(string[] args)
        {
            //odev_ornek();

            //delegateOrnek();

            //lambdaOrnek();

            lambdaOrnek2();

            Console.ReadLine();
        }

        static void lambdaOrnek2()
        {
            IkiRakamTopla toplaIslem = new IkiRakamTopla(topla2rakam);
            Console.WriteLine(toplaIslem(3, 4));
            // Lamda ile kullanım
            Func<int, int, int> toplaIslem2 = (a, b) => a + b;
            Console.WriteLine(toplaIslem2(9, 10));
            //
            IkiRakamTopla islem2 = new IkiRakamTopla(toplaIslem2);
            Console.WriteLine(islem2(5, 8));
            //
            Func<int, int, string, string, string> baskaIslem = (a, b, msg1, msg2) =>
            {
                if (a > b) { return msg1; }
                if (b > a) { return msg2; }
                return "=";
            };
            Console.WriteLine(baskaIslem(3, 4, "İlk rakam büyüktür", "İkinci Rakam büyüktür"));
            //

            Action<string> print = (msg) => Console.WriteLine(msg);

            Action<int, int, string, string, Yaz> noVoidIslem = (a, b, msg1, msg2,print) =>
            {
                if (a > b) { print(msg1); }
                else if (b > a) { print(msg2); }
                else { Console.WriteLine("="); }
            };

            Yaz yaz = new Yaz(print);
            noVoidIslem(4, 1, "İlk rakam >", "İkinci rakam >", yaz);

        }

        static int topla2rakam(int a, int b)
        {
            return a + b;
        }

        static void lambdaOrnek()
        {
            int a = 3;
            Console.WriteLine(isTekSayi(a));
            Console.WriteLine(isTek_lambda(a));
        }

        static Func<int,bool> isTek_lambda = (rakam) => rakam % 2 == 1;

        static bool isTekSayi(int rakam)
        {
            return rakam % 2 == 1;
        }

        static void delegateOrnek()
        {
            SablonFonk1 test1 = new SablonFonk1(fonk1);
            SablonFonk1 test2 = new SablonFonk1(fonk2);
            int sonuc = useDelegate(test1, test2);
        }

        static int useDelegate(SablonFonk1 func1, SablonFonk1 func2)
        {
            int sonuc1 = func1(1,2,true,"Mesaj");
            int sonuc2 = func2(2, 3, false, "Message");
            return sonuc1 + sonuc2;
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
            Console.WriteLine($"Genel Toplam: {genelToplam}");
        }

        static async Task<int> topla(int ilk, int son)
        {
            Console.WriteLine($"Toplam hesapla: {ilk}->{son}");
            int sum = 0;
            for (int i = ilk; i <= son; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            genelToplam = genelToplam + sum;
            return sum;
        }
    }
}
