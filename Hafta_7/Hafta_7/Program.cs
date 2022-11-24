using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance, Polymorphism, Abstraction, Interface");

        //polymorphism();

        //abstractOrnek();

        //interfaceOrnek();

        // enumOrnek();

        dosyaYazOku();
    }

    private static void dosyaYazOku()
    {
        File.WriteAllText("yeniDosya.txt", "Bu yeni bir dosyadır.\n c# ile oluşturulmuştur");

        Console.WriteLine("Yeni dosya oluşturuldu.");

        String dosyaIcerigi = File.ReadAllText("yeniDosya.txt");
        Console.WriteLine(dosyaIcerigi);

        String dosyaIcerigi2 = File.ReadAllText("yeniDosya.txt");
        Console.WriteLine(dosyaIcerigi2);
    }




    // https://www.w3schools.com/cs/cs_enums.php
    private static void enumOrnek()
    {

        int hangiGun = (int)Gunler.Pazartesi;
        Console.WriteLine(hangiGun);

        int secilenGun = 5;
        if (secilenGun == 5 || secilenGun == 6)
        {
            Console.WriteLine("Tatil");
        }

        // enum kullanarak
        if (secilenGun == (int)Gunler.Cumartesi || secilenGun == (int)Gunler.Pazar)
        {
            Console.WriteLine("Enum Tatil");
        }

        int lamba = 30;
        if (lamba == (int)TrafikLamba.Yesil)
        {
            Console.WriteLine("Yeşil => geç");
        }

    }

    enum TrafikLamba
    {
        Kirmizi = 10,
        Sari = 20,
        Yesil = 30,
    }

    enum Gunler
    {
        Pazartesi, //0
        Sali, //1
        Carsamba, // 2
        Persembe, // 3
        Cuma, //4
        Cumartesi, // 5
        Pazar //6
    }


    private static void interfaceOrnek()
    {
        Cat kedi = new Cat();
        Dog kopek = new Dog();

        kedi.sesCikar();
        kedi.besle();

        kopek.sesCikar();
        kopek.besle();
    }

    interface I_patiliDostlar
    {
        void besle();
        void sesCikar();
    }

    class Cat : I_patiliDostlar
    {
        public void besle() { Console.WriteLine("mama ver"); }

        public void sesCikar() { Console.WriteLine("miyav miyav"); }
    }


    class Dog : I_patiliDostlar
    {
        public void besle() { Console.WriteLine("kemik ver"); }

        public void sesCikar() { Console.WriteLine("hav hav"); }
    }


    // https://www.w3schools.com/cs/cs_abstract.php
    private static void abstractOrnek()
    {
        Kedi kedi = new Kedi();
        kedi.sesCikar();
        kedi.besle();

        Kopek kopek = new Kopek();
        kopek.sesCikar();
        kopek.besle();

        kedi.uyu();
        kopek.uyu();

    }

    abstract class PatiliDostlar
    {
        public abstract void sesCikar();

        public abstract void besle();
        public void uyu()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Kedi : PatiliDostlar
    {
        public override void sesCikar()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("miyav miyav");
        }

        public override void besle()
        {
            Console.WriteLine("mama ver");
        }
    }

    class Kopek : PatiliDostlar
    {
        public override void sesCikar()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("hav hav");
        }

        public override void besle()
        {
            Console.WriteLine("Kemik ver");
        }

        public void uyu() { Console.WriteLine("....."); }
    }



    // https://www.w3schools.com/cs/cs_polymorphism.php
    static void polymorphism()
    {
        Araba araba1 = new Araba();
        araba1.setYakit("Dizel");
        araba1.gosterYakitTuru();

        ElektrikliAraba araba2 = new ElektrikliAraba();

        araba2.setYakit();
        araba2.gosterYakitTuru();
    }


}

// Polymorphism
// Inherit edilen bir class'taki metod ile aynı isimde yeni metodlar oluşturulabilir.

class Araba
{
    public string yakit_turu;

    public Araba() { }

    public void setYakit(string yakit)
    {
        this.yakit_turu = yakit;
    }

    public void gosterYakitTuru() { Console.WriteLine("Araba class: " + this.yakit_turu); }
}

class ElektrikliAraba : Araba
{
    public ElektrikliAraba() { }

    public void setYakit()
    {
        this.yakit_turu = "Elektrikli";
    }

    public void gosterYakitTuru() { Console.WriteLine("ElektrikliAraba class: " + this.yakit_turu); }

}





// overloading: Bir class içerisinde aynı isimde metodlar farklı sayıda (veya datatype) olması şartı ile oluşturulabilir.

class Sekil
{
    public string sekil = "?";
    float r,a,b;

    public Sekil(float r) 
    { 
        this.sekil = "Daire"; 
        this.r = r; 
    }

    public Sekil(float a, float b) // dikdortgen
    {
        this.sekil = "Dikdortgen";
        this.a = a;
        this.b = b;
    } 

    public float getAlan(float a, float b)
    { 
        return a* b;
    }

    public float getAlan(float r)
    {
        return 3.14F * r * r;
    }
    
}

