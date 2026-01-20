namespace SmartWarehouse
{
    public abstract class WarehouseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Quantity: {Quantity}");
        }
    }
}
