using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //handle_main_args(args);
            // read_text_file();
            args_for_file_io(args);
            
        }

        private static void args_for_file_io(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Argüman belirtilmedi.");
                return;
            }

            switch (args[0])
            {
                case "liste":
                    read_text_file_lines();
                    break;
                case "liste2":
                    read_text_2_file_lines();
                    break;
                case "ekle":
                    dosyaya_yeni_isim_ekle(args);
                    break;
                case "ekle2":
                    dosyaya_yeni_isim_ekle_2(args);
                    break;
                default:
                    Console.WriteLine("Geçersiz argüman: " + args[0]);
                    break;
            }
        }

        private static void dosyaya_yeni_isim_ekle_2(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Eklenecek veriler belirtilmedi. ");
                return;
            }

            string yeni_satir = args[1];
            for (int i = 2; i < args.Length; i++)
            {
                yeni_satir += args[i];
                Console.WriteLine(args[i]+ " yeni_satir:"+yeni_satir);
            }

            Console.WriteLine("Eklenecek yeni satır: " + yeni_satir);

            string file_name = "liste_2.txt";
            string file_folder = @"C:\users\yasar\dersler\";
            //Dosyanın yazılacağı klasör mevcut mu?
            if (System.IO.Directory.Exists(file_folder)) { }
            else { Console.WriteLine("Dosya klasörü mevcut değil veya ulaşılamıyor. " + file_folder); return; }
            string yaz_file = file_folder + file_name;
            string[] yeni_arr = { yeni_satir.ToUpper() };
            System.IO.File.AppendAllLines(yaz_file, yeni_arr);
            Console.WriteLine(yeni_satir + " dosyaya eklendi.");

        }

        private static void read_text_2_file_lines()
        {
            string file_name = "liste_2.txt";
            string file_folder = @"C:\users\yasar\dersler\";
            string read_file = file_folder + file_name;
            Console.WriteLine("Okunacak dosya:" + read_file);
            string[] lines = System.IO.File.ReadAllLines(read_file);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                goster_yas(line);

            }
        }

        private static void goster_yas(string dizin)
        {
            int yas = 0, sene = 2020;
            string[] arr = dizin.Split(";");
            if(arr.Length == 3)
            {
                string dogum_yil_str = arr[1];
                int dogum_yil = 0;
                if(Int32.TryParse(dogum_yil_str, out dogum_yil))
                {
                    yas = sene - dogum_yil;
                    Console.WriteLine("==> Yaş: " + yas);
                }
                else
                {
                    Console.WriteLine("==> Yaş hesaplanamadı! " + dogum_yil_str);
                }
            }
        }

        private static void dosyaya_yeni_isim_ekle(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Eklenecek isim belirtilmedi. ");
                return;
            }

            string yeni_isim = args[1];
            for (int i = 2; i < args.Length; i++)
            {
                yeni_isim += " "+args[i];
            }


            Console.WriteLine("Eklenecek isim: " + yeni_isim);

            string file_name = "liste.txt";
            string file_folder = @"C:\users\yasar\dersler\";
            //Dosyanın okunacağı klasör mevcut mu?
            if (System.IO.Directory.Exists(file_folder)) { } 
            else { Console.WriteLine("Dosya klasörü mevcut değil veya ulaşılamıyor. "+file_folder); return; }
            string yaz_file = file_folder + file_name;
            // System.IO.File.AppendAllText(yaz_file, yeni_isim);
            string[] isimler = {yeni_isim.ToUpper() };
            System.IO.File.AppendAllLines(yaz_file, isimler);
            Console.WriteLine(yeni_isim + " dosyaya eklendi.");
        }

        private static void read_text_file_lines()
        {
            string file_name = "liste.txt";
            string file_folder = @"C:\users\yasar\dersler\";
            string read_file = file_folder + file_name;
            Console.WriteLine("Okunacak dosya:" + read_file);
            string[] lines = System.IO.File.ReadAllLines(read_file);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        private static void read_text_file()
        {
            string file_name = "liste.txt";
            string file_folder = @"C:\users\yasar\dersler\";
            string read_file = file_folder + file_name;
            Console.WriteLine("Okunacak dosya:" + read_file);
            string text = System.IO.File.ReadAllText(read_file);
            Console.WriteLine(text);

        }

        private static void handle_main_args(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Argüman belirtilmedi.");
                return;
            }

            switch (args[0])
            {
                case "help":
                    Console.WriteLine("help argümanı sağlandı. HELP bilgi notunu ekranda göster.");
                    break;
                case "yeni":
                    Console.WriteLine("yeni argümanı sağlandı. YENI işlemini yapacak metodu çalıştır.");
                    break;
                case "sil":
                    Console.WriteLine("sil argümanı sağlandı. SIL işlemini yapacak metodu çalıştır.");
                    break;
                case "listele":
                    Console.WriteLine("listele argümanı sağlandı. LISTELE işlemini yapacak metodu çalıştır.");
                    break;
                case "goster":
                    Console.WriteLine("goster argümanı sağlandı. TC kimlik args[1] ?.");
                    if (args.Length == 2)
                    {
                        string tc_kimlik = args[1];
                        Console.WriteLine(tc_kimlik + " TC kimliği için bilgilere ulaş.");
                        return;
                    }
                    Console.WriteLine("goster argümanı sağlandı ama TC kimlik argümanı mevcut değil:");
                    Console.WriteLine("ConsoleApp1 goster 12345699393");
                    break;
                default:
                    Console.WriteLine("Geçersiz argüman: " + args[0]);
                    return;
            }
        }
    }
}
