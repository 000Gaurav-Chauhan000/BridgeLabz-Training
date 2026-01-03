using System;

class Product{
    public static double Discount = 10;
    
    public string ProductName;
    public double Price;
    public int Quantity;
    public readonly int ProductID;

    public Product(int ProductID, string ProductName, double Price, int Quantity){
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
    }

    public void ProcessProduct(object obj){
        if (obj is Product){
            double total = Price * Quantity;
            double finalAmount = total - (total * Discount / 100);

            Console.WriteLine(ProductID);
            Console.WriteLine(ProductName);
            Console.WriteLine(finalAmount);
        }
    }

    static void Main(){
        Product p1 = new Product(001, "CD-Player", 10000, 1);
        Product p2 = new Product(002, "Magnets (oval)", 500, 2);

        Product.UpdateDiscount(15);
        p1.ProcessProduct(p1);
        p2.ProcessProduct(p2);
    }
}
