namespace OnlineMarketplace
{
    public abstract class ProductBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} - Price: {Price}");
        }
    }
}
