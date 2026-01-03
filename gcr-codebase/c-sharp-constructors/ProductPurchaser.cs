using System;

class ProductPurchaser{
    string productName;
    double price;
    static int totalProducts = 0;

    public ProductPurchaser(string name, double price){
        this.productName = name;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails(){
        Console.WriteLine("Product Name: " + productName);

        Console.WriteLine("Price: " + price);
    }

    public static void DisplayTotalProducts(){
        Console.WriteLine("Total Products: " + totalProducts);
    }
     static void Main(){
        ProductPurchaser p1 = new ProductPurchaser("Laptop", 55000);
        ProductPurchaser p2 = new ProductPurchaser("Mouse", 500);

        p1.DisplayProductDetails();
        Console.WriteLine();

        p2.DisplayProductDetails();
        Console.WriteLine();

        ProductPurchaser.DisplayTotalProducts();
    }
}