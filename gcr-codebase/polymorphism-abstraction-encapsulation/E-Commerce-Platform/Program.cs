using E_Commerce_Platform;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(101, "Laptop", 60000),
            new Clothing(102, "Jacket", 3000),
            new Groceries(103, "Rice Bag", 1200)
        };

        CalculateFinalPrice(products);
    }

    static void CalculateFinalPrice(List<Product> products)
    {
        foreach (Product product in products)
        {
            decimal tax = 0;

            if (product is ITaxable taxableProduct)
            {
                tax = taxableProduct.CalculateTax();
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }

            decimal discount = product.CalculateDiscount();
            decimal finalPrice = product.Price + tax - discount;

            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Base Price: {product.Price}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Final Price: {finalPrice}");
            Console.WriteLine("-----------------------------");
        }
    }
}
