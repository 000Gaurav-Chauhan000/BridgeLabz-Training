namespace OnlineMarketplace
{
    public class Product<TCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public TCategory Category { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} - Price: {Price}");
        }
    }
}
