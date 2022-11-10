
// https://www.w3schools.com/cs/index.php

class Program
{
    static public void Main(String[] args)
    {
        //fonksiyon();
        //string_birlestir()
        // Nesneye Yönelik Programlama https://www.w3schools.com/cs/cs_oop.php
        int sonuc = hangisi_en_buyuk(3, 5);
        Console.WriteLine(sonuc);
        Console.WriteLine(hangisi_en_kucuk(3,5));
        //Math kütüphanesini kullanarak
        Console.WriteLine(Math.Max(3,5));
        Console.WriteLine(Math.Min(3,5));
        //Mutlak değer hesaplama
        sonuc = mutlak_deger_hesapla(-3);
        int mutlak = Math.Abs(-3);
        // Math.floor() en yakın tam sayıya yuvarlar
        double c = Math.Floor(9.99); //10.0
        c = Math.Floor(9.49); //9.0


    }

    private static int alternatif2(int v)
    {
        return v < 0 ? -v : v;
    }
    private static int alternatif(int v)
    {
        if (v < 0) return -v;
        return v;
    }

    private static int mutlak_deger_hesapla(int v)
    {
        if (v < 0) return -1 * v;
        return v;
    }

    private static int hangisi_en_kucuk(int v1, int v2)
    {
        if (v1 < v2) return v1;
        return v2;
    }

    private static int hangisi_en_buyuk(int v1, int v2)
    {
        if (v1 > v2) return v1;
        return v2;
    }

    private static void string_birlestir()
    {
        string str1 = "Elma";
        string str2 = "Portakal";
        Console.WriteLine(str1+","+str2);
        string str = string.Concat(str1,",",str2);
        Console.WriteLine(str);
        //Interpolation
        string str_ = $"{str1},{str2}";
        Console.WriteLine(str_);
        //Ozel karakterler
        // Tolstoy'en en sevdiğim kitabı "Savaş ve Barış" tır.
        Console.WriteLine("Tolstoy'en en sevdiğim kitabı \"Savaş ve Barış\" tır.");

    }

    static private void fonksiyon()
    {
        String mesaj = "Bugün günlerden Perşembe.";
        Console.WriteLine(mesaj.Length);
        int kac_karakter = kac_karakter_var(mesaj);
        Console.WriteLine("Method tarafından hesaplanan: " + kac_karakter);

        if (tamami_buyuk_yeni_yontem(mesaj))
        {
            Console.WriteLine("Tamamı büyük harf");
        }
        else
        {
            Console.WriteLine("Tamamı büyük harfli değil. " + mesaj);
        }

    }

    static private bool tamami_buyuk_yeni_yontem(String mesaj)
    {
        return mesaj.ToUpper() == mesaj;
    }

    static private int kac_karakter_var(String mesaj)
    {
        int say = 0;
        foreach (char c in mesaj) { say++; }
        return say;
    }

    static private bool tamami_buyuk_harfli_mi(String metin)
    {
        Console.WriteLine(metin.ToUpper());
        Console.WriteLine(metin.ToLower());

        foreach(char c in metin)
        {
            if (Char.IsLower(c)) { return false; }
        }
        return true;
    }

}