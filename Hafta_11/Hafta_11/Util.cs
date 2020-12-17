using System;

namespace Hafta_11
{
    class Util
    {
        public static string sor(string soru)
        {
            Console.WriteLine(soru);
            return Console.ReadLine();
        }

        public static int sor_tamsayi(string soru, bool positif)
        {
            Console.WriteLine(soru);
            string user_input = Console.ReadLine();
            int yas;
            if (int.TryParse(user_input, out yas))
            {
                if(!positif || yas>0)
                {
                    return yas;
                }
                Console.WriteLine("Hatalı giriş. 0'dan daha büyük bir değer girmelisiniz.");
                return sor_tamsayi(soru, positif);
            }
            else
            {
                Console.WriteLine("Hatalı giriş. ");
                return sor_tamsayi(soru, positif);
            }
        }

        public static int sor_int(string soru)
        {
            Console.WriteLine(soru);
            string user_input = Console.ReadLine();
            int yas;
            if (int.TryParse(user_input, out yas))
            {
                return yas;
            }
            else
            {
                Console.WriteLine("Hatalı giriş. ");
                return sor_int(soru);
            }
        }

        public static int sor_int_positif(string soru)
        {
            Console.WriteLine(soru);
            string user_input = Console.ReadLine();
            int yas;
            if (int.TryParse(user_input, out yas))
            {
                if(yas > 0)
                {
                    return yas;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş. 0'dan daha büyük bir değer girmelisiniz.");
                    return sor_int_positif(soru);
                }                
            }
            else
            {
                Console.WriteLine("Hatalı giriş. ");
                return sor_int(soru);
            }
        }
    }
}
