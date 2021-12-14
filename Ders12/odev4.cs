using System;

namespace odev4
{
    class Program
    {
        public delegate string Islem1(string a, string b);
        public delegate int Islem2(int a, string b, bool c);
        public delegate bool Islem3(int a, int b);

        static void Main(string[] args)
        {
            basla();
        }

        static void basla()
        {
            Islem1 islem1 = new Islem1(method1);
            Islem2 islem2 = new Islem2(method2);
            Islem3 islem3 = new Islem3(method3);

            methodlar(islem1, islem2, islem3);
        }

        static string method1(string a, string b)
        {
            // kod
        }
        static int method2(int a, string b, bool c)
        {
            // kod
        }

        static bool method3(int a, int b)
        {
            // kod
        }

        static void methodlar(Islem2 islem2, Islem3 islem3, Islem1 islem1)
        {
            islem1("a", "b", "c");
            islem2(1, 2, true);
            islem3(2, 4, 5);
        }
    }
}