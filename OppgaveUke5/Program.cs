namespace OppgaveUke5;
class Program
{
    static void Main(string[] args)
    {
        /*
         * Tests in seprate project
         */
        ClothingItem shirt = new ClothingItem("Men's T-Shirt", 50, 20.99, "Large", "Blue");
        ClothingItem jacket = new ClothingItem("Womans's T-Shirt", 6, 18.22, "Large", "Blue");
        ElectronicItem phone = new ElectronicItem("iPhone X", 25, 799.99, "1 year");
        ElectronicItem tv = new ElectronicItem("TV", 1, 9000, "1 year", 240);

        double shirtSalePrice = shirt.CalculateSalePrice();
        double jacketSalePrice = jacket.CalculateSalePrice();
        double phoneSalePrice = phone.CalculateSalePrice();
        double tvSalePrice = tv.CalculateSalePrice();

        Console.WriteLine($"The sale price of the shirts are: {shirtSalePrice}");
        Console.WriteLine($"The sale price of the jackets are: {jacketSalePrice}");
        Console.WriteLine($"The sale price of the phones are: {phoneSalePrice}");
        Console.WriteLine($"The sale price of the tv is: {tvSalePrice}");
    }
}