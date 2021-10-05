using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //haftalik_plan_switch("Salı");
            //dongu_for_ile();
            //dongu_for_2(10, 1);
            //dongu_while_ile();
            //dongu_while_2(20, 5);


            /*
            int[] tek_sayilar = { 1, 3, 5, 7, 9 };
            string gun_adi = hafta_gun_ismi_2(-1);
            Console.WriteLine(gun_adi);
            */
            //Console.WriteLine(hafta_gun_try_catch(2));

            //kac_yasindasin();

            string[] hafta_gunleri = { "", "Pazartesi", "Salı", "Çarşama", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for(int i=0; i < hafta_gunleri.Length; i++)
            {
                if (i == 0) { continue; }
                Console.WriteLine(hafta_gunleri[i]);
            }

            foreach(string gun in hafta_gunleri)
            {
                if (gun == "") { continue; }
                Console.WriteLine(gun);
            }

        }

        static void kac_yasindasin()
        {
            Console.WriteLine("Doğum yılınız? ");
            string dogum_yil = Console.ReadLine();

            int bu_sene = DateTime.Now.Year;

            try
            {
                int yas = bu_sene - Convert.ToInt32(dogum_yil);
                Console.WriteLine(yas + " yaşındasınız.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Geçerli bir yıl yazınız");
                kac_yasindasin();
            }
            
        }

        static string hafta_gun_try_catch(int kacinci_gun)
        {
            string[] hafta_gunleri = { "", "Pazartesi", "Salı", "Çarşama", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string gun = "?";
            try
            {
                gun = hafta_gunleri[kacinci_gun];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }finally{
                Console.WriteLine("Her durumda çalışacak kod");
            }
            return gun;
        }


        static string hafta_gun_ismi_2(int kacinci_gun)
        {
            string[] hafta_gunleri = { "", "Pazartesi", "Salı", "Çarşama", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            if (kacinci_gun>0 && kacinci_gun < hafta_gunleri.Length)
            {
                return hafta_gunleri[kacinci_gun];
            }
            else
            {
                return "Hatalı gün indeksi!";
            }
            //return "Hatalı gün indeksi!";
        }

        static string hafta_gun_ismi(int kacinci_gun)
        {
            if (kacinci_gun < 0) { return "Hatalı gün indeksi!"; }
            if (kacinci_gun > 7) { return "Haftanın günleri arasında böyle bir gün yok."; }
            string[] hafta_gunleri = {"", "Pazartesi", "Salı", "Çarşama", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            return hafta_gunleri[kacinci_gun];
        }



        static void dongu_while_2(int basla, int bitis)
        {
            int i = basla;
            while (i > bitis)
            {
                if(i % 2 == 0) { i--; continue; }
                Console.WriteLine(i);
                i--;
            }
        }

        static void dongu_while_ile()
        {
            int i = 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i = i + 2;
                if (i > 6) { break; }
            }
        }

        static void dongu_for_2(int basla, int bitir)
        {
            for(int i=basla; i>=bitir; i--)
            {
                Console.WriteLine(i);
            }
        }
        

        static void dongu_for_ile()
        {
            for(int j=1; j<=10; j++)
            {
                if(j > 8)
                {
                    break;
                }


                if(j % 2 == 0)
                {
                    continue;
                }
                
                Console.WriteLine(j);

                
            }

        }


        static void haftalik_plan_switch(string gun)
        {
            switch (gun)
            {
                case "Pazartesi":
                    Console.WriteLine("Meyve teslimatı olacak");
                    break;
                case "Salı":
                    Console.WriteLine("Et teslimatı olacak");
                    break;
                case "Çarşamba":
                    Console.WriteLine("Tavuk teslimatı olacak");
                    break;
                case "Perşembe":
                    Console.WriteLine("Meşrubat teslimatı olacak.");
                    break;
                case "Cuma":
                    Console.WriteLine("Sebze teslimatı olacak");
                    break;
                default:
                    Console.WriteLine("Bugün teslimat olmayacak");
                    break;
            }
        }

        static void haftalik_plan(string gun)
        {
            if(gun == "Pazartesi")
            {
                Console.WriteLine("Meyve teslimatı olacak");
            }
            else if(gun == "Salı")
            {
                Console.WriteLine("Et teslimatı olacak");
            }
            else if(gun == "Çarşamba")
            {
                Console.WriteLine("Tavuk teslimatı olacak");
            }else if(gun == "Perşembe")
            {
                Console.WriteLine("Meşrubat teslimatı olacak.");
            }
            else if(gun == "Cuma")
            {
                Console.WriteLine("Sebze teslimatı olacak");
            }
            else
            {
                Console.WriteLine("Bugün teslimat olmayacak");
            }
        }
    }
}
