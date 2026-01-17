class Products
{
    public string ProductName { get; private set; }
    public int ProductID { get; private set; }
    public double ProductPrice { get; set; }
    public bool IsDiscounted { get; set; }
    public double Discount { get; set; }

    public Products(string name, int id, double price, double discount)
    {
        ProductName = name;
        ProductID = id;
        ProductPrice = price;
        Discount = discount;
        IsDiscounted = discount > 0;
    }
}
