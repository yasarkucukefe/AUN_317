using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            yeniNesneler();
        }

        static void yeniNesneler()
        {
            Araba araba1 = new Araba("Nissan", "Qashkai", "mavi", 2010);
            Araba araba2 = new Araba("Ford", "Focus", "kırmızı", 2020);
            //hangisiDahaYeni(araba1, araba2);
            araba1.sanzuman = "Otomatik";
            Console.WriteLine(araba1.sanzuman);
            araba2.sanzuman = "Manuel";
            Console.WriteLine(araba2.sanzuman);
        }

        static void hangisiDahaYeni2(Araba arac1, Araba arac2)
        {
            Console.WriteLine("Araba-1 => " + arac1.kacYas());
            Console.WriteLine("Araba-2 => " + arac2.kacYas());
            if (arac1.kacYas() > arac2.kacYas())
            {
                Console.WriteLine("Arac-2 daha yenidir.");
            }else if(arac1.kacYas() < arac2.kacYas())
            {
                Console.WriteLine("Arac-1 daha yenidir.");
            }
            else
            {
                Console.WriteLine("Arac-1 ve Arac-2 aynı yaştadırlar.");
            }
        }

        static void hangisiDahaYeni(Araba arac1, Araba arac2)
        {
            
            if(arac1.kacYas() > arac2.kacYas())
            {
                Console.WriteLine("Arac-2 daha yenidir.");
                return;
            }

            if (arac1.kacYas() < arac2.kacYas())
            {
                Console.WriteLine("Arac-1 daha yenidir.");
                return;
            }
            Console.WriteLine("Arac-1 ve Arac-2 aynı yaştadırlar.");
        }
    }

    class elektrikliArabalar : Araba
    {
        int menzil;

        public elektrikliArabalar(string marka_, string model_, string renk_, int sene_, int menzil_) : base (marka_, model_, renk_, sene_)
        {
           menzil = menzil_;
        }
       
    }

    class Bataryalar
    {
        string tur;
    }

    class Araba
    {
        string marka;
        string model;
        string renk;
        int sene;
        public string sanzuman;

        public Araba(string marka_, string model_, string renk_, int sene_)
        {
            marka = marka_;
            model = model_;
            renk = renk_;
            sene = sene_;
        }

        public int arabaSene() { return sene; }

        public int kacYas()
        {
            int buYil = DateTime.Now.Year;
            int kacYas = buYil - sene;
            return kacYas;
        }

    }
}
