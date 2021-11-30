using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Util
    {
        public void tekSayilar(int ilk, int son)
        {
            Console.WriteLine(ilk + " - " + son + " arasındaki TEK sayılar:");
            for (int i = ilk; i < son; i++)
            {
                if (i % 2 == 1) { Console.WriteLine(i); }
            }
        }

        public void ciftSayilar(int ilk, int son)
        {
            Console.WriteLine(ilk + " - " + son + " arasındaki ÇİFT sayılar:");
            for (int i = ilk; i < son; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }
        }
    }
}
