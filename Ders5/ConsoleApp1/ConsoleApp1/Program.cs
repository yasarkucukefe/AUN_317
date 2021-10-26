using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Papatya papatya = new Papatya();
            //throwOrnek();

            String[] isimler = { "Ahmet", "Mehmet", "Ayşe" };
            Console.WriteLine(isimler[-1]); // IndexOutOfRangeException

        }

        static void throwOrnek()
        {
            int yas = 15;

            try
            {
                if (yas < 18)
                {
                    throw new ArithmeticException("Yaşınız 18 yaşından büyük olmalı.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("throw error");
            }

           
        }

        //Polymorphism: Türetilen sınıfların bir üst sınıfın metodlarını yeniden tanımlayabilmesi

        static void polyMorphism()
        {
            Sekil sekil = new Sekil();
            sekil.sekil_ad = "Kare";
            sekil.sekilAdiPrint();

            // Türetilmiş class
            Alan alan = new Alan();
            alan.sekil_ad = "Daire";
            alan.sekilAdiPrint();
        }


        interface HayvanClass
        {
            public void hayvanSesi();
            public void ayakSayisi();
            public void hayvanTuru();
            public void yasamAlani();
        }

        class kedi : HayvanClass
        {
            public void ayakSayisi()
            {
                // method tanımı ...
            }

            public void hayvanSesi()
            {
                // method tanımı ...
            }

            public void hayvanTuru()
            {
                // method tanımı ...
            }

            public void yasamAlani()
            {
                // method tanımı ...
            }
        }

        class Alan : Sekil
        {
            public void sekilAdiPrint()
            {
                Console.WriteLine("Alan sınıfı ile print: " + sekil_ad);
            }
        }

        abstract class Bitki
        {
            public abstract void isim();

            public void renkNedir()
            {
                Console.WriteLine("Bitkinin rengi yeşildir.");
            }
        }

        class Papatya : Bitki
        {
            public override void isim()
            {
                Console.WriteLine("Bitkinin ismi: Papatya");

            }
        }

        class Sekil
        {
            public string sekil_ad = "";
            public int kac_tane = 0;

            public Sekil()
            {
              
            }

            public void sekilAdiPrint()
            {
                Console.WriteLine("Sekil sınıfı ile print: "+sekil_ad);
            }

            public Sekil(string sekil_ad_)
            {
                sekil_ad = sekil_ad_;
            }

            public Sekil(int kac_tane)
            {

            }
        }
    }
}
