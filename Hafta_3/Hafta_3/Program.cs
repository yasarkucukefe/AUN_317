using System;

namespace Hafta_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // type_casting_ornek();
            // user_input_func();
            // user_dogum_yili();
            // hata_kontrol_user_dogum_yili();
            // if_else_kontrolu();
            // ulke_baskentleri();
            ulke_baskentleri_switch();

        }

        private static void ulke_baskentleri_switch()
        {
            Console.WriteLine("Başkentini öğrenmek istediğiniz Ülke adı:");
            string ulke = Console.ReadLine().ToLower();
            string baskent = "?";
            switch (ulke)
            {
                case "turkey":
                    baskent = "Ankara";
                    break;
                case "iran":
                    baskent = "Tahran";
                    break;
                case "france":
                    baskent = "Paris";
                    break;
                case "germany":
                    baskent = "Berlin";
                    break;
                default:
                    baskent = "Listede yok.";
                    break;
            }
            Console.WriteLine($"{ulke}'nin başkenti {baskent}");
        }

        private static void ulke_baskentleri()
        {
            Console.WriteLine("Başkentini öğrenmek istediğiniz Ülke adı:");
            string ulke = Console.ReadLine().ToLower();
            string baskent = "?";
            if(ulke == "turkey")
            {
                baskent = "Ankara";
            }
            else if(ulke == "iran")
            {
                baskent = "Tahran";
            }
            else if (ulke == "france")
            {
                baskent = "Paris";
            }
            else if (ulke == "germany")
            {
                baskent = "Berlin";
            }
            else
            {
                baskent = "Listede yok.";
            }
            Console.WriteLine($"{ulke}'nin başkenti {baskent}");
        }

        private static void if_else_kontrolu()
        {
            int sene = DateTime.Now.Year;
            int dogum_sene = user_input_dogum_yili();
            // Doğum yılı
            //1. 2020 yılından daha büyük olmamalı
            //2. 1900 yılın daha küçük olmamalı
            if (dogum_sene > sene)
            {
                Console.WriteLine("Doğum yılı ileri bir tarih olamaz.");
                if_else_kontrolu();
            }
            else if(dogum_sene < 1900)
            {
                Console.WriteLine("Doğum yılı 1900 yılında öncesi olmaz.");
                if_else_kontrolu();
            }
            else
            {                
                int yas = sene - dogum_sene;
                string str_yas = Convert.ToString(yas);
                Console.WriteLine($"Yaşınız: {str_yas}");
                //Yaşa bağlı olarak mesaj oluşturalım
                string chat_msg = "Yaşa bağlı olarak belirlenecek chat mesajı";
                if(yas < 10)
                {
                    chat_msg = "Uygulamaya devam etmek için 10 yaş ve üzeri olmalısınız.";
                }else if(yas >=10 && yas < 20)
                {
                    chat_msg = "Yaşınız 10 ve 20 arasında.";
                }else if (yas >= 20 && yas < 40)
                {
                    chat_msg = "Yaşınız 20 ve 40 arasında.";
                }
                else
                {
                    chat_msg = "Size başka bir uygulama öneriyoruz.";
                }
                Console.WriteLine(chat_msg);
            }
        }



        private static int user_input_dogum_yili()
        {
            Console.WriteLine("Doğum yılınız?");
            try
            {
                int dogum_yili = Convert.ToInt32(Console.ReadLine());
                return dogum_yili;
            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata oluştu. Doğum yılı değeri geçersiz.");
                return user_input_dogum_yili();
            }
        }


        private static void hata_kontrol_user_dogum_yili()
        {
            int sene = 2020;
            Console.WriteLine("Doğum yılınız?");
            try
            {
                Console.WriteLine("try bloğu:");
                int dogum_yili = Convert.ToInt32(Console.ReadLine());
                int yas = sene - dogum_yili;
                string str_yas = Convert.ToString(yas);
                Console.WriteLine($"Yaşınız: {str_yas}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Bir hata oluştu. Doğum yılı değeri geçersiz.");
            }
            finally
            {
                Console.WriteLine("Finally bloğundaki bu konsol çıktısı her durumda (hata veya normal) gösterilir.");
            }
        }

        private static void user_dogum_yili()
        {
            int sene = 2020;

            Console.WriteLine("Doğum yılınız?");

            string input_dogum = Console.ReadLine();
            int dogum_yili;

            bool can_convert = Int32.TryParse(input_dogum, out dogum_yili);

            if (can_convert) {
                int yas = sene - dogum_yili;
                string str_yas = Convert.ToString(yas);
                Console.WriteLine($"Yaşınız: {str_yas}");
            } else
            {
                Console.WriteLine("Hata:" +input_dogum + " geçerli bir yıl değil.");
                user_dogum_yili();
            }

            

            //int dogum_yili = Convert.ToInt32(input_dogum);

            /* 

            
            */


        }

        static private void user_input_func()
        {
            Console.WriteLine("Kullanıcı adınız:");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName} kullanıcı adı için şifre:");
            string userPass = Console.ReadLine();

            Console.WriteLine($"{userName} kullanıcı adı ve {userPass} şifre kontrol ediliyor ...");
        }


        static private void type_casting_ornek()
        {
            //integer casting
            double sayiDouble = 9.38;
            int tamSayi = (int) sayiDouble;
            bool deger = false;

            //conversions
            int a = Convert.ToInt32(sayiDouble);
            string str_from_double = Convert.ToString(sayiDouble);
            string str_from_bool = Convert.ToString(deger);

            Console.WriteLine(sayiDouble + "; casting:" + tamSayi +", conversion:"+a);
            Console.WriteLine("Conversion to string from double: " + str_from_double);
            Console.WriteLine("Conversion to string from boolean: " + str_from_bool);
        }
    }
}
