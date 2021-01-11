using System;
using System.Collections.Generic;

namespace Hafta14
{
    class Program
    {
        public delegate int ornekDelegate(int x, string str, bool deger, string isim);

        public delegate void hesapDelegate(int rakam);
        public delegate string hesapDelegateStr(int rakam);

        static void Main(string[] args)
        {

            Basla_dlg_str();

            //Basla_dlg();

            
            //Basla(); Odev-1 standart çözüm

            //Delegate ornek
            /*
            ornekDelegate dlg_1 = Metod1_for_ornekDelegate;
            ornekDelegate dlg_2 = Metod2_for_ornekDelegate;

            ornekDelegate ldg_lambda = (int x, string str, bool deger, string isim) =>
            {
                Console.WriteLine($"str=>{str}, deger=>{deger}, isim=>{isim}");
                return x * 2;
            };

            //

            int int_dlg1 = dlg_1.Invoke(2, "dlg-1", true, "dlg-1 isim");
            Console.WriteLine("DLG-1 return int =>" + int_dlg1);
            Console.WriteLine("-----");
            int int_dlg2 = dlg_2.Invoke(4, "dlg-2", false, "dlg-2 isim");
            Console.WriteLine("DLG-2 return int =>" + int_dlg2);

            ldg_lambda.Invoke(3, "str", true, "isim");
            */

        }

        private static int Metod1_for_ornekDelegate(int x, string str, bool deger, string isim)
        {
            Console.WriteLine(str + " string str kullanıldı. METOD-1");
            if (deger)
            {
                Console.WriteLine("bool deger TRUE- METOD-1");
            }
            else
            {
                Console.WriteLine("bool deger TRUE- METOD-1");
            }
            Console.WriteLine(isim + " string isim kullanıldı. METOD-1");
            return x*x*2; //int x kullanıldı.
        }

        private static int Metod2_for_ornekDelegate(int x, string str, bool deger, string isim)
        {
            Console.WriteLine(str + " string str kullanıldı. METOD-2");
            if (deger)
            {
                Console.WriteLine("bool deger TRUE METOD-2");
            }
            else
            {
                Console.WriteLine("bool deger TRUE METOD-2");
            }
            Console.WriteLine(isim + " string isim kullanıldı. METOD-2");
            return x * x * x; //int x kullanıldı.
        }

        private static int Metod3_for_ornekDelegate(int x, string str, bool deger, string isim)
        {
            Console.WriteLine($"str=>{str}, deger=>{deger}, isim=>{isim}");
            return x * 2;
        }

        private static void Basla()
        {
            Console.WriteLine("---\n Yapmak istediğiniz hesaplamayı seçiniz: \n Faktöriyel (f), Fibonacci Dizisi (d) \n Programdan çıkmak için (x)");
            string secim = Console.ReadLine();
            switch (secim.ToLower())
            {
                case "f":
                    HesaplaFaktoriyel();
                    break;
                case "d":
                    HesaplaFibonacci();
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Faktöryel veya Fibonacci dizisi hesaplanabilir.");
                    break;
            }
            Basla();
        }

        private static void Basla_dlg_str()
        {
            Console.WriteLine("---\n Yapmak istediğiniz hesaplamayı seçiniz: \n Faktöriyel (f), Fibonacci Dizisi (d) \n Programdan çıkmak için (x)");
            string secim = Console.ReadLine();
            hesapDelegateStr dlg_fak = Hesapla_Faktoriyel_String;
            hesapDelegateStr dlg_fib = Hesapla_Fibonacci_String;
            switch (secim.ToLower())
            {
                case "f":
                    IslemSecimSonrasiString(dlg_fak, "Faktöriyel hesabı yapılacak sayı? ");
                    break;
                case "d":
                    IslemSecimSonrasiString(dlg_fib, "Fibonacci dizisi kaçıncı sayıya kadar hesaplansın? ");
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Faktöryel veya Fibonacci dizisi hesaplanabilir.");
                    break;
            }
            Basla_dlg();
        }

        private static void Basla_dlg()
        {
            Console.WriteLine("---\n Yapmak istediğiniz hesaplamayı seçiniz: \n Faktöriyel (f), Fibonacci Dizisi (d) \n Programdan çıkmak için (x)");
            string secim = Console.ReadLine();
            hesapDelegate dlg_fak = Hesapla_Faktoriyel;
            hesapDelegate dlg_fib = Hesapla_Fibonacci;
            switch (secim.ToLower())
            {
                case "f":
                    IslemSecimSonrasi(dlg_fak, "Faktöriyel hesabı yapılacak sayı? ");
                    break;
                case "d":
                    IslemSecimSonrasi(dlg_fib, "Fibonacci dizisi kaçıncı sayıya kadar hesaplansın? ");
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Faktöryel veya Fibonacci dizisi hesaplanabilir.");
                    break;
            }
            Basla_dlg();
        }

        private static void IslemSecimSonrasi(hesapDelegate islem, string mesaj)
        {
            int rakam = RakamInput(mesaj);
            islem.Invoke(rakam);
        }

        private static void IslemSecimSonrasiString(hesapDelegateStr islem, string mesaj)
        {
            int rakam = RakamInput(mesaj);
            Console.WriteLine(islem.Invoke(rakam));
        }

        private static string Hesapla_Faktoriyel_String(int rakam)
        {
            int fakt = FaktoriyelHesapla(rakam);
            return $"{rakam} sayısının faktöriyeli {fakt} 'dir";
        }

        private static string Hesapla_Fibonacci_String(int rakam)
        {
            List<int> fib = FinonacciHesapla(new List<int>(), rakam);
            String output = $"{rakam} sayıdan oluşan Fibonacci dizini:\n";
            foreach (int rkm in fib)
            {
                output+="\n"+rkm;
            }
            return output;
        }

        private static void Hesapla_Faktoriyel(int rakam)
        {
            int fakt = FaktoriyelHesapla(rakam);
            Console.WriteLine($"{rakam} sayısının faktöriyeli {fakt} 'dir");
        }

        private static void Hesapla_Fibonacci(int rakam)
        {
            List<int> fib = FinonacciHesapla(new List<int>(), rakam);
            Console.WriteLine($"{rakam} sayıdan oluşan Fibonacci dizini:");
            foreach (int rkm in fib)
            {
                Console.WriteLine(rkm);
            }
        }



        private static void HesaplaFaktoriyel()
        {
            int rakam = RakamInput("Faktöriyel hesabı yapılacak sayı? ");
            int fakt = FaktoriyelHesapla(rakam);
            Console.WriteLine($"{rakam} sayısının faktöriyeli {fakt} 'dir");
        }

        private static void HesaplaFibonacci()
        {
            int rakam = RakamInput("Fibonacci dizisi kaçıncı sayıya kadar hesaplansın? ");
            List<int> fib = FinonacciHesapla(new List<int>(), rakam);
            Console.WriteLine($"{rakam} sayıdan oluşan Fibonacci dizini:");
            foreach (int rkm in fib)
            {
                Console.WriteLine(rkm);
            }
        }

        private static int FaktoriyelHesapla(int sayi)
        {
            if (sayi == 1)
            {
                return sayi;
            }
            else
            {
                return sayi * FaktoriyelHesapla(sayi - 1);
            }
        }

        private static List<int> FinonacciHesapla(List<int> dizin, int say)
        {
            int kacTane = dizin.Count;
            if(say == kacTane) { return dizin; }
            if (kacTane >= 2)
            {
                //int n = dizin[kacTane - 1];
                //int n_1 = dizin[kacTane - 2];
                //int sonraki_n = n + n_1;
                //dizin.Add(sonraki_n);
                dizin.Add(dizin[kacTane - 1] + dizin[kacTane - 2]);                
                return FinonacciHesapla(dizin, say);
            }
            dizin.Add(0);
            dizin.Add(1);
            return FinonacciHesapla(dizin, say);

        }


        private static int RakamInput(string mesaj)
        {
            Console.WriteLine(mesaj);
            int rakam = 0;
            string input = Console.ReadLine();
            if(int.TryParse(input, out rakam))
            {
                if(rakam == 0)
                {
                    Console.WriteLine("Sadece sıfırdan büyük tam sayılar için hesaplama yapılabilir");
                    return RakamInput(mesaj);
                }
                return rakam;       
            }

            Console.WriteLine("Sadece tam sayı girişi yapılabilir");
            return RakamInput(mesaj);
        }
    }
}
