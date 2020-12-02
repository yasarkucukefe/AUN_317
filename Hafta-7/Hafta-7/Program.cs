using System;

namespace Hafta_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //arac_class_1();
            //arac_inheritance();
            //arac_2_inheritance();
            // arac_referans();
            //switch_ornek(2);
            //for_loop_dongu();
            //while_loop_dongu();
            //do_while_loop_dongu();
            //try_catch_finally();
            //int faktoriyel = faktoriyel_hesapla(5);
            //Console.WriteLine(faktoriyel);
            yeni_sekil();
        }




        private static void yeni_sekil()
        {
            Sekil sekil = new Sekil(2);
        }
        class Sekil
        {
            public Sekil(int cap)
            {
                Console.WriteLine("Daire");
            }
            public Sekil(int a, int b)
            {
                Console.WriteLine("Kare");
            }
        }

        private static int faktoriyel_hesapla(int rakam)
        {
            if(rakam == 1) 
            { 
                return rakam; 
            }
            else 
            { 
                return rakam * faktoriyel_hesapla(rakam-1); 
            }
        }

        private static void try_catch_finally()
        {
            Console.WriteLine("Dogum yiliniz:");
            string dogum_senesi = Console.ReadLine();

            try
            {
                int yas = 2020 - Int16.Parse(dogum_senesi);
                Console.WriteLine("Yasiniz: " + yas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bir hata oluştu:"+e.ToString());
            }
            finally
            {
                Console.WriteLine("Finally 37");
            }            
        }

        private static void do_while_loop_dongu()
        {
            int ust_limit = 10;
            int i = 0;
            do
            {                
                i++;
                if (i > 8) { break; } // i=9 ve 10 için döngü çalışmamalı!
                Console.WriteLine(i);
                if (i > 5) { continue; } //Takip eden döngü içindeki kodu çalıştırma, ama döngüye devam et
                Console.WriteLine(i % 2 == 1);
            } while (i <= ust_limit);
        }

        private static void for_loop_dongu()
        {
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i > 8) { break; } // i=9 ve 10 için döngü çalışmamalı!
                if (i > 5) { continue; } //Takip eden döngü içindeki kodu çalıştırma, ama döngüye devam et
                Console.WriteLine(i % 2 == 1);                
            }
        }

        private static void switch_ornek(int rakam)
        {
            switch (rakam)
            {
                case 0:
                    Console.WriteLine("A ilacını almalısınız");
                    break;
                case 1:
                    Console.WriteLine("B ilacını almalısınız");
                    break;
                case 2:
                    Console.WriteLine("C ilacını almalısınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("D ilacını almalısınız");
                    break;
                default:
                    Console.WriteLine("F ilacını almalısınız");
                    break;
            }
        }

        private static void arac_referans()
        {
            Arac a = new Arac();
            a.model = "Palio";
            a.uretici = "Fiat";
            //
            Arac b = a;
            b.model = "Egea";
            //
            Console.WriteLine("A-model:" + a.model + " \n" + "B-model:" + b.model);
        }

        private static void arac_2_inheritance()
        {
            Arac_sesi arac_Sesi = new Arac_sesi();
            arac_Sesi.uretici = "Mercedes";
            arac_Sesi.model = "C180";
            arac_Sesi.set_sene(2020);
            arac_Sesi.yakit = "dizel";
            arac_Sesi.yakit_tuketimi = 4.5f;
            arac_Sesi.arac_sesi = 120;

        }

        private static void arac_inheritance()
        {
            Yakit_tuketimi yakit_Tuketimi = new Yakit_tuketimi();
            yakit_Tuketimi.uretici = "Fiat";
            yakit_Tuketimi.model = "Egea";
            yakit_Tuketimi.set_sene(2010);
            yakit_Tuketimi.yakit = "Benzinli";
            yakit_Tuketimi.yakit_tuketimi = 7.6f;
        }

        private static void arac_class_1()
        {
            Arac arac = new Arac();
            arac.uretici = "Ford";
            arac.model = "Focus";
            arac.set_sene(2015);
            arac.renk = "Mavi";
            Console.WriteLine(arac.uretici+" "+arac.model+" "+arac.get_sene()+" "+arac.renk);
        }
    }

    

    class Arac_sesi : Yakit_tuketimi
    {
        public int arac_sesi;
    }

    class Yakit_tuketimi : Arac
    {
        public float yakit_tuketimi;
    }

    class Arac
    {
        public string uretici;
        public string model;
        private int sene;
        public string renk { get; set; }
        public string yakit;
        public void set_sene (int sene)
        {
            this.sene = sene;
        }

        public int get_sene ()
        {
            return this.sene;
        }

    }
}
