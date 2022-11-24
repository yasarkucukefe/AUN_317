
class Program
{
    static public void Main(string[] args)
    {
        // Bir Pizzacı için Pizza Class'ı oluşturunuz.

        Pizza pizza = new Pizza(false);
        pizza.setMalzemeler("zeytin, sucuk, sosis, mantar");
        pizza.setBoy("orta");
        pizza.setFiyat(95.00);

        Pizza pizza2 = new Pizza(true);
        pizza2.setMalzemeler("domates, mantar, enginar, biber");
        pizza2.setBoy("büyük");
        pizza2.setFiyat(60);

        //Print
        pizza.printOzellikler();
        pizza2.printOzellikler();
    }
}


class Pizza
{
    string malzemeler;
    string boyut;
    double fiyat;
    bool vegan;

    public Pizza(bool vegan_) {
        this.vegan = vegan_;
    }

    public void setMalzemeler(string malzemeler_) { this.malzemeler = malzemeler_; }

    public void setBoy(string boy_) { this.boyut = boy_; }

    public void setFiyat(double fiyat_) { this.fiyat = fiyat_;}

    public void printOzellikler()
    {
        Console.WriteLine("\n Pizza:");
        string veganMi = this.vegan ? "Vegan" : "Standard";
        Console.WriteLine(veganMi);
        Console.WriteLine(this.malzemeler);
        Console.WriteLine(this.boyut);
        Console.WriteLine(this.fiyat);
    }

}