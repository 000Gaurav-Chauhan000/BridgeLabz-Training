namespace SmartWarehouse
{
    public class Electronics : WarehouseItem
    {
        public int WarrantyYears { get; set; }
    }

    public class Groceries : WarehouseItem
    {
        public DateTime ExpiryDate { get; set; }
    }

    public class Furniture : WarehouseItem
    {
        public string Material { get; set; }
    }
}
