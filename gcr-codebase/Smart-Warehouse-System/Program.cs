using SmartWarehouse;

class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();

        electronicsStorage.AddItem(new Electronics
        {
            Id = 1,
            Name = "Laptop",
            Quantity = 10,
            WarrantyYears = 2
        });

        electronicsStorage.AddItem(new Electronics
        {
            Id = 2,
            Name = "Mobile",
            Quantity = 25,
            WarrantyYears = 1
        });

        electronicsStorage.DisplayItems();
    }
}
