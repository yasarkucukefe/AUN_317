using System;

namespace Hafta_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //isleInputArgs(args);
            //yasHesapla(args);

            Console.WriteLine("Adınız?");
            string isim = Console.ReadLine();

            Console.WriteLine("Doğum yılınız?");
            string dogumYil = Console.ReadLine();

            int yas = yasHesaplaFonksiyonu(dogumYil);

            if(yas < 0){
                Console.WriteLine("Lütfen geçerli bir yıl giriniz.");
            }
            else
            {
                Console.WriteLine("isim: " + isim + ", yaş:" + yas);
            }

        }

        static void readInputFromProgram()
        {
            Console.WriteLine("Adınız?");
            string isim = Console.ReadLine();

            Console.WriteLine("Doğum yılınız?");
            string dogumYil = Console.ReadLine();

            int mevcutYil = DateTime.Now.Year; // İçinde bulunulan sene

            try
            {
                int yas = mevcutYil - Int32.Parse(dogumYil); // Int32.Parse() => bir string değerini tamsayıya (integer) dönüştür.

                Console.WriteLine("isim: " + isim + ", yaş:" + yas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lütfen geçerli bir yıl giriniz.");
            }

        }

        static int yasHesaplaFonksiyonu(string dogumYil)
        {
            int mevcutYil = DateTime.Now.Year; // İçinde bulunulan sene
            try
            {
                int yas = mevcutYil - Int32.Parse(dogumYil); // Int32.Parse() => bir string değerini tamsayıya (integer) dönüştür.

                return yas;
            }
            catch (Exception e)
            {
                //Console.WriteLine("Lütfen geçerli bir yıl giriniz.");
                return -1;
            }

           

        }

        private static void yasHesapla(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Lütfen isim ve doğum yılı bilgilerini giriniz.");
                return;
            }

            string isim = args[0];
            string dogumYil = args[1];

            int mevcutYil = DateTime.Now.Year; // İçinde bulunulan sene
            int yas = mevcutYil - Int32.Parse(dogumYil); // Int32.Parse() => bir string değerini tamsayıya (integer) dönüştür.

            Console.WriteLine("isim: " + isim + ", yaş:" + yas);





        }

        static void isleInputArgs(string[] args)
        {
            Console.WriteLine("Uygulama çalıştırıldı. Argumanlar: (args)");
            // args bir string array'dir
            foreach (String arg in args)
            {
                Console.WriteLine(arg);
            }
        }


        static void tryCatchFinally()
        {
            String[] sehirler = { "İstanbul", "Ankara", "İzmir", "Tekirdağ" };

            int index = 5;

            //String sehir2 = sehirler[5]; // olmayan index: System.IndexOutOfRangeException

            try // hata yok ise çalışır, hata var ise çalışmaz
            {
                String sehir = sehirler[index]; //
                Console.WriteLine(sehir);
            }
            catch (Exception e) // try bloğunda hata var ise çalışır.
            {
                Console.WriteLine("Şehir indeks en fazla 3 olabilir");
            }
            finally // hata olsa da olmasa da çalışır.
            {
                Console.WriteLine("Finally block");
            }

            Console.WriteLine("Program başarıyla çalıştı.");
        }

        static void tryCatchOrnek()
        {
            String[] sehirler = { "İstanbul", "Ankara", "İzmir", "Tekirdağ" };
            String sehir = sehirler[0]; // istanbul

            //String sehir2 = sehirler[5]; // olmayan index: System.IndexOutOfRangeException

            try
            {
                String sehir2 = sehirler[5]; // olmayan index:
            }
            catch (Exception e)
            {
                Console.WriteLine("Şehir indeks en fazla 3 olabilir");
            }

            Console.WriteLine("Program başarıyla çalıştı.");
        }

        static void foreachOrnek()
        {
            String[] haftaGunleri = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            foreach (string gun in haftaGunleri)
            {
                Console.WriteLine(gun);
            }

            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }
        }

        static void arrayLengthOrnek()
        {
            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            int kacTaneRakam = rakamlar.Length;
            Console.WriteLine("array'de " + kacTaneRakam + " eleman bulunuyor.");

            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine(rakamlar[i]);
            }
        }

        static void arrayOrnek()
        {
            String[] haftaGunleri = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool[] trueFalse = { true, true, true, false, false };

            String gun = haftaGunleri[1]; // Salı, sıfır index sistem
            int rakam = rakamlar[3]; // 3

            // for ile haftanın günleri
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(haftaGunleri[i]);
            }

            // while ile
            Console.WriteLine("--- While ---");
            int j = 0;
            while (j < 7)
            {
                Console.WriteLine(haftaGunleri[j]);
                j++;
            }

            // while ile 2. yöntem
            Console.WriteLine("--- While ---");
            int k = 0;
            while (true)
            {
                if (k > 7) { break; }
                Console.WriteLine(haftaGunleri[k]);
                k++;
            }
        }

        static void whileLoopOrnek()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }


            i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }

                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
        }

        static void forLoopOrnek()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------");
            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------");

            for (int i = 0; i < 10; i++)
            {
                // Modulus operator % => i % 2 = ? (i değerinin 2'ye bölünmesinden kalan değer 
                if (i % 2 == 1) // tek sayılar
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("------");

            for (int i = 0; i < 10; i++)
            {
                // Modulus operator % => i % 2 = ? (i değerinin 2'ye bölünmesinden kalan değer 
                Console.WriteLine(i);
                if (i > 5)
                {
                    break;
                }

            }
            Console.WriteLine("------");

            for (int i = 0; i < 10; i++)
            {
                // Modulus operator % => i % 2 = ? (i değerinin 2'ye bölünmesinden kalan değer 
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
                if (i > 5)
                {
                    break;
                }

            }
        }

        static void ornek1()
        {
            double a = 2.0, b = 5.2;
            double topla = a + b;
            double bolme = b / a; //2.5;

            int bolmeInt = ((int)b / (int)a);

            Console.WriteLine("float:" + bolme + ", int:" + bolmeInt);

            int sonuc = (int)3.8;
            Console.WriteLine(sonuc); // 3
        }



        static void fonksiyon_ornek()
        {
            int a = 1, b = 2;
            int toplam = a + b;
            Console.WriteLine(toplam);
            //
            int toplam2 = topla(5, 6);
            Console.WriteLine(toplam2);
        }

        static int topla(int a, int b)
        {
            int toplam = a + b;
            return toplam;
        }


        static void switchCaseOrnek()
        {
            String gun = "Pazartesi";
            Console.WriteLine("Gün: " + gun);
            switch (gun)
            {
                case "Pazartesi":
                    Console.WriteLine("Alışveriş günü");
                    break;
                case "Salı":
                    Console.WriteLine("Spor günü");
                    break;
                case "Çarşamba":
                    Console.WriteLine("Okul günü");
                    break;
                default:
                    Console.WriteLine("Dinlen.");
                    break;
            }
        }

        static void ifBlok()
        {
            String gun = "Pazar";
            Console.WriteLine("Gün: " + gun);
            if (gun == "Pazartesi")
            {
                Console.WriteLine("Alışveriş günü");
            }
            else if (gun == "Salı")
            {
                Console.WriteLine("Spor günü");
            }
            else if (gun == "Çarşamba")
            {
                Console.WriteLine("Okul günü");
            }
            else
            {
                Console.WriteLine("Dinlen.");
            }
        }

        static void stringConcat()
        {
            String isim = "Mehmet", soyisim = "Uçar";
            int yas = 34;

            String mesaj = isim + " " + soyisim;
            Console.WriteLine(mesaj);

            String mesaj_yas = isim + " " + soyisim + ": " + yas;
            Console.WriteLine(mesaj_yas);

            String rakam_txt = "1";
            Console.WriteLine(rakam_txt + yas); // "1" + 34 => 134

            Console.WriteLine("1" + 2 + "3"); // 123
        }
    }
}
