using System.Reflection.Metadata.Ecma335;

namespace Hafta_13
{
    internal class Program
    {

        private delegate void Yaz(string a);

        // return int ve input argümanları (int,int,bool,string) olan fonksiyon için delegate
        public delegate int SablonFonk1(int a, int b, bool kontrol, string mesaj);


        private static int genelToplam;

        static void Main(string[] args)
        {


            //lambdaOrnek();

            //cs_actions();

            delegateOrnek();

        }

        static void delegateOrnek()
        {
            SablonFonk1 test1 = new SablonFonk1(fonk1);
            SablonFonk1 test2 = new SablonFonk1(fonk2);
            int sonuc = useDelegate(test1, test2);
            Console.WriteLine(sonuc);
        }

        static int useDelegate(SablonFonk1 func1, SablonFonk1 func2)
        {
            int sonuc1 = func1(1, 2, true, "Mesaj");
            int sonuc2 = func2(2, 3, false, "Message");
            return sonuc1 + sonuc2;
        }

        static int fonk1(int i, int j, bool test, string msg)
        {
            return 1;
        }

        static int fonk2(int i, int j, bool test, string msg)
        {
            return 0;
        }


        private static void cs_actions()
        {
            //Action
            Action<string> yazdir = (mesaj) => Console.WriteLine(mesaj);
            yazdir("Merhaba");


            Yaz yaz = new Yaz(yazdir);

            Action<int, int, string, string, string, Yaz> actionOrnek = (a, b, msg1, msg2, msg3, yazdir) =>
            {
                if (a > b) { yazdir(msg1); }
                else if (b > a) { yazdir(msg2); }
                else { yazdir(msg3); }
            };

            actionOrnek(3, 4, "İlk rakam büyüktür", "İkinci rakam büyüktür", "Rakamlar eşittir", yaz);

            methodKullan(3, 4, "İlk rakam büyüktür", "İkinci rakam büyüktür", "Rakamlar eşittir", yaz);
        }

        static void methodKullan(int a, int b, string msg1, string msg2, string msg3, Yaz msgyaz)
        {
            if (a > b) { msgyaz(msg1); }
            else if (b > a) { msgyaz(msg2); }
            else { msgyaz(msg3); }
        }


        static void lambdaOrnek()
        {
            // Lambda functions: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

            Func<int, int> square = x => x * x;

            Console.WriteLine(square(5));
            Console.WriteLine(kareAl(5));

            int kareAl(int x)
            {
                return x * x;
            }

            // return type: bool (en son veri türü)
            Func<double, double, bool> esitMi = (a, b) => a == b;
            Console.WriteLine(esitMi(5, 9));

            // daire alan
            Func<double, double> daireAlan = (r) => 3.14 * Math.Pow(r,2); // ! sinav sorusu olabilir

            // Math.Pow(x,y) => x^y (x'in y'inci kuvveti)
            // Math.Pow(3,2) = 9




        }

        static void async_ornek()
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