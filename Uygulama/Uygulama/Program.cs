
class Program
{

    static public void Main(string[] args)
    {

        Console.WriteLine("Rakamları birer boşluk kalacak şekilde yazınız.");
        string input = Console.ReadLine();

        Console.WriteLine("Girdiğiniz rakamlar:");
        double en_buyuk = 1e-10;
        foreach (string rakam in input.Split(' ')){
            Console.WriteLine(rakam);
            double sayi = double.Parse(rakam);
            Console.Write($" => Double: {sayi} \n");
            if (sayi > en_buyuk) { en_buyuk = sayi; }
        }

        Console.WriteLine($"En büyük sayi : {en_buyuk}");



    }
}
