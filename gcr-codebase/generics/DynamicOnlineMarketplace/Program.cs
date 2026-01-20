using OnlineMarketplace;

class Program
{
    static void Main()
    {
        var book = new Product<BookCategory>
        {
            Id = 1,
            Name = "Clean Code",
            Price = 500,
            Category = new BookCategory { Genre = "Programming" }
        };

        var clothing = new Product<ClothingCategory>
        {
            Id = 2,
            Name = "T-Shirt",
            Price = 800,
            Category = new ClothingCategory { Size = "M" }
        };

        var catalog = new Catalog<ProductBase>();
        catalog.AddProduct(book);
        catalog.AddProduct(clothing);

        var discountService = new DiscountService();
        discountService.ApplyDiscountAlgo(book, 10);

        catalog.DisplayAll();
    }
}
