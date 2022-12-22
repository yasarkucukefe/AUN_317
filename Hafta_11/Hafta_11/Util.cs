using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_11
{

    class Util
    {

        public void allCaps(string metin)
        {
            metin= metin.ToUpper();
            Console.WriteLine(metin);
        }

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
