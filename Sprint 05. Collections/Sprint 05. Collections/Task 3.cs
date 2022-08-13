//Please create a method TotalPrice(ILookup<string, Product> lookup) in which print(Name + " " + Price) from one category and total price for products from these categories (Key + " " + totalPriceForCategory)

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public static void TotalPrice(ILookup<string, Product> lookup)
    {
        decimal total = 0;
        foreach (var group in lookup)
        {
            foreach (var price in group)
            {
                Console.WriteLine(price.Name + " " + price.Price);
                total += price.Price;
            }
            Console.WriteLine(group.Key + " " + total);
            total = 0;
        }
    }
}